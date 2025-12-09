using Shared;
using Shared.DTO;

namespace WinFormsApps
{
    public partial class OwnerCoursesForm : Form, ICoursesView
    {
        public OwnerCoursesForm()
        {
            InitializeComponent();

            btnSearch.Click += (s, e) => SearchRequested?.Invoke(this, searchBox.Text);
            btnAdd.Click += (s, e) => AddRequested?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            btnChangeStatus.Click += (s, e) => ChangeStatusRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? AddRequested;
        public event EventHandler? EditRequested;
        public event EventHandler? DeleteRequested;
        public event EventHandler? ChangeStatusRequested;
        public event EventHandler<string>? SearchRequested;

        public void DisplayCourses(IEnumerable<CourseDto> courses)
        {
            try
            {
                var courseList = courses.ToList();

                OwnerCoursesGridView.DataSource = null;
                OwnerCoursesGridView.DataSource = courseList;
                OwnerCoursesGridView.Refresh();

                if (courseList.Count == 0)
                {
                    ShowInfo("Курсы не найдены");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при отображении курсов: {ex.Message}");
            }
        }

        public CourseDto? GetSelectedCourse()
        {
            if (OwnerCoursesGridView.SelectedRows.Count == 0)
            {
                ShowInfo("Выберите курс");
                return null;
            }

            return (CourseDto)OwnerCoursesGridView.SelectedRows[0].DataBoundItem;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public CourseDto? RequestNewCourseData()
        {
            using (var form = new AddEditForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    return form.CourseData;
                }
                return null;
            }
        }

        public CourseDto? RequestCourseUpdate(CourseDto course)
        {
            using (var form = new AddEditForm(course))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    return form.CourseData;
                }
                return null;
            }
        }

        public bool ConfirmDelete(string courseName)
        {
            var result = MessageBox.Show($"Вы уверены, что хотите удалить курс '{courseName}'?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
    }
}
