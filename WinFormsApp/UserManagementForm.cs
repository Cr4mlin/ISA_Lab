using Logic.Services;
using Logic.Exceptions;
using Model;
using DataAccessLayer;

namespace WinFormsApp
{
    public partial class UserManagementForm : Form
    {
        private readonly IUserManagementService _userManagementService;
        private readonly IUserRepository _userRepository;
        private readonly User _currentUser;

        public UserManagementForm(IUserManagementService userManagementService, IUserRepository userRepository, User currentUser)
        {
            _userManagementService = userManagementService;
            _userRepository = userRepository;
            _currentUser = currentUser;
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var users = _userManagementService.GetAllUsers();

                // Remove event handler first to avoid multiple attachments
                dataGridViewUsers.DataBindingComplete -= DataGridViewUsers_DataBindingComplete;

                // Attach event handler
                dataGridViewUsers.DataBindingComplete += DataGridViewUsers_DataBindingComplete;

                dataGridViewUsers.DataSource = users;
                lblTotalUsers.Text = $"Всего пользователей: {users.Count}";
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка при загрузке пользователей из базы данных: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataLoadException ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка загрузки",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewUsers_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            if (dataGridViewUsers.Columns.Count > 0)
            {
                // Скрываем пароль сразу
                if (dataGridViewUsers.Columns.Contains("Password"))
                {
                    dataGridViewUsers.Columns["Password"].Visible = false;
                }

                // Скрываем числовой ID роли
                if (dataGridViewUsers.Columns.Contains("Role"))
                {
                    dataGridViewUsers.Columns["Role"].Visible = false;
                }

                dataGridViewUsers.Columns["Id"].HeaderText = "ID";
                dataGridViewUsers.Columns["Id"].Width = 60;

                dataGridViewUsers.Columns["Login"].HeaderText = "Логин";
                dataGridViewUsers.Columns["Login"].Width = 200;

                // Добавляем колонку с текстовым представлением роли только один раз
                if (!dataGridViewUsers.Columns.Contains("RoleName"))
                {
                    var roleNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "RoleName",
                        HeaderText = "Роль",
                        Width = 150,
                        ReadOnly = true
                    };
                    dataGridViewUsers.Columns.Add(roleNameColumn);
                }

                // Заполняем названия ролей и подсвечиваем текущего пользователя
                foreach (DataGridViewRow row in dataGridViewUsers.Rows)
                {
                    if (!row.IsNewRow && row.DataBoundItem is User user)
                    {
                        // Получаем название роли из базы данных
                        string roleName = _userRepository.GetRoleName(user.Role);

                        // Проверяем, что ячейка существует перед присвоением значения
                        if (row.Cells["RoleName"] != null)
                        {
                            row.Cells["RoleName"].Value = roleName;
                        }

                        // Подсвечиваем текущего пользователя
                        if (user.Id == _currentUser.Id)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                    }
                }
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridViewUsers.SelectedRows.Count > 0;
            bool canChangeRole = false;

            if (hasSelection && dataGridViewUsers.SelectedRows[0].DataBoundItem is User selectedUser)
            {
                canChangeRole = selectedUser.Id != _currentUser.Id;

                if (selectedUser.Id == _currentUser.Id)
                {
                    lblInfo.Text = "⚠ Это ваш аккаунт - изменение роли недоступно";
                    lblInfo.ForeColor = Color.DarkOrange;
                }
                else
                {
                    string currentRole = selectedUser.Role == 1 ? "Администратор" : "Пользователь";
                    string newRole = selectedUser.Role == 1 ? "Пользователь" : "Администратор";
                    lblInfo.Text = $"Выбран: {selectedUser.Login} ({currentRole}) → Изменить на: {newRole}";
                    lblInfo.ForeColor = Color.DarkBlue;
                }
            }
            else
            {
                lblInfo.Text = "Выберите пользователя для изменения роли";
                lblInfo.ForeColor = Color.Gray;
            }

            btnChangeToAdmin.Enabled = canChangeRole;
            btnChangeToUser.Enabled = canChangeRole;
        }

        private void btnChangeToAdmin_Click(object sender, EventArgs e)
        {
            ChangeUserRole(1);
        }

        private void btnChangeToUser_Click(object sender, EventArgs e)
        {
            ChangeUserRole(2);
        }

        private void ChangeUserRole(int newRoleId)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var selectedUser = dataGridViewUsers.SelectedRows[0].DataBoundItem as User;
                if (selectedUser != null)
                {
                    if (selectedUser.Id == _currentUser.Id)
                    {
                        MessageBox.Show("Нельзя изменить роль самому себе", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string currentRoleName = selectedUser.Role == 1 ? "Администратор" : "Пользователь";
                    string newRoleName = newRoleId == 1 ? "Администратор" : "Пользователь";

                    var result = MessageBox.Show(
                        $"Изменить роль пользователя '{selectedUser.Login}'?\n\n" +
                        $"Текущая роль: {currentRoleName}\n" +
                        $"Новая роль: {newRoleName}\n\n" +
                        $"Вы уверены?",
                        "Подтверждение изменения роли",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _userManagementService.ChangeUserRole(selectedUser.Id, newRoleId, _currentUser.Id);
                            MessageBox.Show(
                                $"Роль пользователя '{selectedUser.Login}' успешно изменена на '{newRoleName}'",
                                "Успех",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LoadUsers();
                        }
                        catch (UnauthorizedRoleChangeException ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка доступа",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (CourseNotFoundException ex)
                        {
                            MessageBox.Show(ex.Message, "Пользователь не найден",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (DatabaseException ex)
                        {
                            MessageBox.Show($"Ошибка базы данных при изменении роли: {ex.Message}", "Ошибка базы данных",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для изменения роли", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadUsers();
                return;
            }

            try
            {
                var allUsers = _userManagementService.GetAllUsers();
                var filteredUsers = allUsers.Where(u =>
                    u.Login.ToLower().Contains(searchText) ||
                    u.Id.ToString().Contains(searchText)
                ).ToList();

                // Remove event handler first to avoid multiple attachments
                dataGridViewUsers.DataBindingComplete -= DataGridViewUsers_DataBindingComplete;

                // Attach event handler
                dataGridViewUsers.DataBindingComplete += DataGridViewUsers_DataBindingComplete;

                dataGridViewUsers.DataSource = filteredUsers;
                lblTotalUsers.Text = $"Найдено пользователей: {filteredUsers.Count}";
            }
            catch (SearchException ex)
            {
                MessageBox.Show($"Ошибка при поиске пользователей: {ex.Message}", "Ошибка поиска",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных при поиске: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                var allUsers = _userManagementService.GetAllUsers();
                var adminUsers = allUsers.Where(u => u.Role == 1).ToList();

                // Remove event handler first to avoid multiple attachments
                dataGridViewUsers.DataBindingComplete -= DataGridViewUsers_DataBindingComplete;

                // Attach event handler
                dataGridViewUsers.DataBindingComplete += DataGridViewUsers_DataBindingComplete;

                dataGridViewUsers.DataSource = adminUsers;
                lblTotalUsers.Text = $"Администраторов: {adminUsers.Count}";
            }
            catch (FilterException ex)
            {
                MessageBox.Show($"Ошибка при фильтрации пользователей: {ex.Message}", "Ошибка фильтрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных при фильтрации: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterUser_Click(object sender, EventArgs e)
        {
            try
            {
                var allUsers = _userManagementService.GetAllUsers();
                var regularUsers = allUsers.Where(u => u.Role == 2).ToList();

                // Remove event handler first to avoid multiple attachments
                dataGridViewUsers.DataBindingComplete -= DataGridViewUsers_DataBindingComplete;

                // Attach event handler
                dataGridViewUsers.DataBindingComplete += DataGridViewUsers_DataBindingComplete;

                dataGridViewUsers.DataSource = regularUsers;
                lblTotalUsers.Text = $"Пользователей: {regularUsers.Count}";
            }
            catch (FilterException ex)
            {
                MessageBox.Show($"Ошибка при фильтрации пользователей: {ex.Message}", "Ошибка фильтрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных при фильтрации: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsers();
        }
    }
}
