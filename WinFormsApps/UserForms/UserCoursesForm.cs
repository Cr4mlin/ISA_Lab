using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;
using Shared.DTO;

namespace WinFormsApps
{
    public partial class UserCoursesForm : Form, IUserCoursesView
    {
        public UserCoursesForm()
        {
            InitializeComponent();

            btnSearch.Click += (s, e) => SearchRequested?.Invoke(this, searchBox.Text);
            btnAllCourses.Click += (s, e) => ViewAllCoursesRequested?.Invoke(this, EventArgs.Empty);
            btnViewPurchased.Click += (s, e) => ViewPurchasedCoursesRequested?.Invoke(this, EventArgs.Empty);
            btnPurchaseCourse.Click += (s, e) => PurchaseCourseRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? ViewAllCoursesRequested;
        public event EventHandler? ViewPurchasedCoursesRequested;
        public event EventHandler? PurchaseCourseRequested;
        public event EventHandler<string>? SearchRequested;

        public void DisplayCourses(IEnumerable<CourseDto> courses)
        {
            try
            {
                var courseList = courses.ToList();

                UserCoursesGridView.DataSource = null;
                UserCoursesGridView.DataSource = courseList;

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
            if (UserCoursesGridView.SelectedRows.Count == 0)
            {
                ShowInfo("Выберите курс");
                return null;
            }

            return (CourseDto)UserCoursesGridView.SelectedRows[0].DataBoundItem;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ConfirmPurchase(string courseName)
        {
            var result = MessageBox.Show($"Вы хотите купить курс \"{courseName}\"?",
                "Подтверждение покупки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
