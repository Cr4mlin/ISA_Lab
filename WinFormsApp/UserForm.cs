using System.Data;
using DataAccessLayer;
using Logic;
using Logic.Services;
using Logic.Exceptions;
using Microsoft.Data.SqlClient;
using Ninject;
using Model;

namespace WinFormsApp
{
    public partial class UserForm : Form
    {
        private ISchoolService _schoolService;
        private IUserCourseService _userCourseService;
        private readonly User _currentUser;
        private bool _showingPurchasedCourses = false;

        public UserForm(ISchoolService schoolService, IUserCourseService userCourseService, User currentUser)
        {
            _schoolService = schoolService;
            _userCourseService = userCourseService;
            _currentUser = currentUser;
            InitializeComponent();
            this.Text = $"Пользователь: {_currentUser.Login}";
            RefreshCoursesList();
        }

        private void RefreshCoursesList()
        {
            try
            {
                var courses = _schoolService.GetActiveCourses();
                dataGridViewCourses.DataSource = courses;
                ConfigureDataGridView();
                _showingPurchasedCourses = false;
                lblCurrentView.Text = "Отображение: Доступные курсы";
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных при загрузке курсов: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataLoadException ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных курсов: {ex.Message}", "Ошибка загрузки",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            if (dataGridViewCourses.Columns.Count > 0)
            {
                dataGridViewCourses.Columns["Id"].HeaderText = "ID";
                dataGridViewCourses.Columns["Name"].HeaderText = "Название";
                dataGridViewCourses.Columns["Description"].HeaderText = "Описание";
                dataGridViewCourses.Columns["Duration"].HeaderText = "Длительность (ч)";
                dataGridViewCourses.Columns["Price"].HeaderText = "Цена (руб)";
                dataGridViewCourses.Columns["TeacherName"].HeaderText = "Преподаватель";
                dataGridViewCourses.Columns["IsActive"].HeaderText = "Активен";

                dataGridViewCourses.Columns["Price"].DefaultCellStyle.Format = "N2";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm(_schoolService);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                dataGridViewCourses.DataSource = searchForm.SearchResults;
                ConfigureDataGridView();
                _showingPurchasedCourses = false;
                lblCurrentView.Text = "Отображение: Результаты поиска";
            }
        }

        private void btnPriceRange_Click(object sender, EventArgs e)
        {
            var priceForm = new PriceRangeForm(_schoolService);
            if (priceForm.ShowDialog() == DialogResult.OK)
            {
                dataGridViewCourses.DataSource = priceForm.FilteredCourses;
                ConfigureDataGridView();
                _showingPurchasedCourses = false;
                lblCurrentView.Text = "Отображение: Фильтр по цене";
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshCoursesList();
        }

        private void btnPurchaseCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count > 0)
            {
                var selectedCourse = dataGridViewCourses.SelectedRows[0].DataBoundItem as Course;
                if (selectedCourse != null)
                {
                    var result = MessageBox.Show(
                        $"Вы уверены, что хотите купить курс '{selectedCourse.Name}' за {selectedCourse.Price:N2} руб.?",
                        "Подтверждение покупки",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _userCourseService.PurchaseCourse(_currentUser.Id, selectedCourse.Id);
                            MessageBox.Show($"Курс '{selectedCourse.Name}' успешно куплен!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (CourseAlreadyPurchasedException ex)
                        {
                            MessageBox.Show(ex.Message, "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (CourseNotFoundException ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (DatabaseException ex)
                        {
                            MessageBox.Show($"Ошибка базы данных при покупке курса: {ex.Message}", "Ошибка базы данных",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите курс для покупки", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMyPurchases_Click(object sender, EventArgs e)
        {
            try
            {
                var purchasedCourses = _userCourseService.GetPurchasedCourses(_currentUser.Id);
                dataGridViewCourses.DataSource = purchasedCourses;
                ConfigureDataGridView();
                _showingPurchasedCourses = true;
                lblCurrentView.Text = $"Отображение: Мои купленные курсы ({purchasedCourses.Count})";

                if (purchasedCourses.Count == 0)
                {
                    MessageBox.Show("У вас пока нет купленных курсов", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных при загрузке купленных курсов: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataLoadException ex)
            {
                MessageBox.Show($"Ошибка при загрузке купленных курсов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectConnection_Click(object sender, EventArgs e)
        {
            using (var form = new DbConnectionForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string selectedConnection = form.SelectedConnectionType;
                    IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule(selectedConnection));
                    _schoolService = ninjectKernel.Get<ISchoolService>();
                    _userCourseService = ninjectKernel.Get<IUserCourseService>();
                    MessageBox.Show($"Вы подключились через: {selectedConnection}");
                    RefreshCoursesList();
                }
            }
        }

        private void dataGridViewCourses_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridViewCourses.SelectedRows.Count > 0;
            btnPurchaseCourse.Enabled = hasSelection && !_showingPurchasedCourses;
        }

        private void dataGridViewCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_showingPurchasedCourses)
            {
                var selectedCourse = dataGridViewCourses.Rows[e.RowIndex].DataBoundItem as Course;
                if (selectedCourse != null)
                {
                    string statusMessage = _userCourseService.HasPurchasedCourse(_currentUser.Id, selectedCourse.Id)
                        ? "Вы уже купили этот курс"
                        : "Курс доступен для покупки";

                    MessageBox.Show(
                        $"Название: {selectedCourse.Name}\n" +
                        $"Описание: {selectedCourse.Description}\n" +
                        $"Преподаватель: {selectedCourse.TeacherName}\n" +
                        $"Длительность: {selectedCourse.Duration} часов\n" +
                        $"Цена: {selectedCourse.Price:N2} руб.\n\n" +
                        $"Статус: {statusMessage}",
                        "Информация о курсе",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
