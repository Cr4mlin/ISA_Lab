using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.DTO;

namespace WinFormsApps
{
    public partial class AddEditForm : Form
    {
        public CourseDto? CourseData { get; private set; }

        public AddEditForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public AddEditForm(CourseDto course) : this()
        {
            LoadCourseData(course);
        }

        private void InitializeForm()
        {
            // Инициализация ComboBox статуса
            cbStatus.Items.Clear();
            cbStatus.Items.Add("да");
            cbStatus.Items.Add("нет");
            cbStatus.SelectedIndex = 0;

            // Подключение событий кнопок
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void LoadCourseData(CourseDto course)
        {
            if (course == null) return;

            txtBoxCourseName.Text = course.Name;
            txtBoxCourseDescription.Text = course.Description;
            numericUpDownCourseDuration.Value = course.Duration;
            numericUpDownCourseValue.Value = course.Price;
            textBoxTeacherName.Text = course.TeacherName;
            cbStatus.SelectedIndex = course.IsActive ? 0 : 1;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                // Валидация
                if (string.IsNullOrWhiteSpace(txtBoxCourseName.Text))
                {
                    MessageBox.Show("Введите название курса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBoxCourseDescription.Text))
                {
                    MessageBox.Show("Введите описание курса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxTeacherName.Text))
                {
                    MessageBox.Show("Введите имя преподавателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создание DTO
                CourseData = new CourseDto
                {
                    Name = txtBoxCourseName.Text.Trim(),
                    Description = txtBoxCourseDescription.Text.Trim(),
                    Duration = (int)numericUpDownCourseDuration.Value,
                    Price = numericUpDownCourseValue.Value,
                    TeacherName = textBoxTeacherName.Text.Trim(),
                    IsActive = cbStatus.SelectedIndex == 0
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
