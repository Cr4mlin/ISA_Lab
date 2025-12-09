using Shared;
using Shared.DTO;

namespace WinFormsApps
{
    public partial class OwnerUsersViewForm : Form, IUsersView
    {
        public OwnerUsersViewForm()
        {
            InitializeComponent();

            btnSearch.Click += (s, e) => SearchRequested?.Invoke(this, searchBox.Text);
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            btnChangeRole.Click += (s, e) => ChangeRoleRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? DeleteRequested;
        public event EventHandler? ChangeRoleRequested;
        public event EventHandler<string>? SearchRequested;

        public void DisplayUsers(IEnumerable<UserDto> users)
        {
            try
            {
                var userList = users.ToList();

                UserCoursesGridView.DataSource = null;
                UserCoursesGridView.DataSource = userList;

                if (userList.Count == 0)
                {
                    ShowInfo("Пользователи не найдены");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при отображении пользователей: {ex.Message}");
            }
        }

        public UserDto? GetSelectedUser()
        {
            if (UserCoursesGridView.SelectedRows.Count == 0)
            {
                ShowInfo("Выберите пользователя");
                return null;
            }

            return (UserDto)UserCoursesGridView.SelectedRows[0].DataBoundItem;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ConfirmDelete(string userName)
        {
            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить пользователя '{userName}'?\n\nЭто действие необратимо!",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        public int? RequestNewRole(string userName, int currentRole)
        {
            string currentRoleName = currentRole == 1 ? "Администратор" : "Пользователь";
            string newRoleName = currentRole == 1 ? "Пользователь" : "Администратор";

            var result = MessageBox.Show(
                $"Изменить роль пользователя '{userName}'?\n\n" +
                $"Текущая роль: {currentRoleName}\n" +
                $"Новая роль: {newRoleName}",
                "Изменение роли", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return currentRole == 1 ? 2 : 1;
            }

            return null;
        }
    }
}
