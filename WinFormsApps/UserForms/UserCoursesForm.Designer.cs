namespace WinFormsApps
{
    partial class UserCoursesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnSearch = new Controls.Buttons();
            btnAllCourses = new Controls.Buttons();
            btnViewPurchased = new Controls.Buttons();
            btnPurchaseCourse = new Controls.Buttons();
            panel1 = new Panel();
            panel2 = new Panel();
            UserCoursesGridView = new DataGridView();
            searchBox = new Controls.CustomTextBox();
            labelSearch = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(250, 136, 230);
            btnSearch.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 20;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(0, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 37);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Поиск";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAllCourses
            // 
            btnAllCourses.BackColor = Color.FromArgb(250, 136, 230);
            btnAllCourses.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnAllCourses.BorderColor = Color.PaleVioletRed;
            btnAllCourses.BorderRadius = 20;
            btnAllCourses.BorderSize = 0;
            btnAllCourses.FlatAppearance.BorderSize = 0;
            btnAllCourses.FlatStyle = FlatStyle.Flat;
            btnAllCourses.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAllCourses.ForeColor = Color.White;
            btnAllCourses.Location = new Point(0, 158);
            btnAllCourses.Name = "btnAllCourses";
            btnAllCourses.Size = new Size(124, 37);
            btnAllCourses.TabIndex = 5;
            btnAllCourses.Text = "Все курсы";
            btnAllCourses.TextColor = Color.White;
            btnAllCourses.UseVisualStyleBackColor = false;
            // 
            // btnViewPurchased
            // 
            btnViewPurchased.BackColor = Color.FromArgb(250, 136, 230);
            btnViewPurchased.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnViewPurchased.BorderColor = Color.PaleVioletRed;
            btnViewPurchased.BorderRadius = 20;
            btnViewPurchased.BorderSize = 0;
            btnViewPurchased.FlatAppearance.BorderSize = 0;
            btnViewPurchased.FlatStyle = FlatStyle.Flat;
            btnViewPurchased.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnViewPurchased.ForeColor = Color.White;
            btnViewPurchased.Location = new Point(0, 115);
            btnViewPurchased.Name = "btnViewPurchased";
            btnViewPurchased.Size = new Size(124, 37);
            btnViewPurchased.TabIndex = 6;
            btnViewPurchased.Text = "Купленные";
            btnViewPurchased.TextColor = Color.White;
            btnViewPurchased.UseVisualStyleBackColor = false;
            // 
            // btnPurchaseCourse
            // 
            btnPurchaseCourse.BackColor = Color.FromArgb(250, 136, 230);
            btnPurchaseCourse.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnPurchaseCourse.BorderColor = Color.PaleVioletRed;
            btnPurchaseCourse.BorderRadius = 20;
            btnPurchaseCourse.BorderSize = 0;
            btnPurchaseCourse.FlatAppearance.BorderSize = 0;
            btnPurchaseCourse.FlatStyle = FlatStyle.Flat;
            btnPurchaseCourse.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnPurchaseCourse.ForeColor = Color.White;
            btnPurchaseCourse.Location = new Point(0, 72);
            btnPurchaseCourse.Name = "btnPurchaseCourse";
            btnPurchaseCourse.Size = new Size(124, 37);
            btnPurchaseCourse.TabIndex = 7;
            btnPurchaseCourse.Text = "Купить";
            btnPurchaseCourse.TextColor = Color.White;
            btnPurchaseCourse.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnPurchaseCourse);
            panel1.Controls.Add(btnAllCourses);
            panel1.Controls.Add(btnViewPurchased);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(664, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 450);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(UserCoursesGridView);
            panel2.Controls.Add(searchBox);
            panel2.Controls.Add(labelSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 450);
            panel2.TabIndex = 10;
            // 
            // UserCoursesGridView
            // 
            UserCoursesGridView.AllowUserToAddRows = false;
            UserCoursesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            UserCoursesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UserCoursesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserCoursesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserCoursesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UserCoursesGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 136, 230);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserCoursesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserCoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserCoursesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            UserCoursesGridView.Location = new Point(13, 68);
            UserCoursesGridView.MultiSelect = false;
            UserCoursesGridView.Name = "UserCoursesGridView";
            UserCoursesGridView.ReadOnly = true;
            UserCoursesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            UserCoursesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            UserCoursesGridView.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserCoursesGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            UserCoursesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserCoursesGridView.Size = new Size(639, 366);
            UserCoursesGridView.TabIndex = 11;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.BackColor = Color.FromArgb(250, 0, 164);
            searchBox.Location = new Point(107, 20);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(0, 0, 0, 1);
            searchBox.Size = new Size(545, 25);
            searchBox.TabIndex = 10;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.ForeColor = Color.Black;
            labelSearch.Location = new Point(13, 17);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(94, 28);
            labelSearch.TabIndex = 9;
            labelSearch.Text = "Поиск:";
            // 
            // UserCoursesForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserCoursesForm";
            Text = "OwnerCoursesView";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Controls.Buttons btnSearch;
        private Controls.Buttons btnAllCourses;
        private Controls.Buttons btnViewPurchased;
        private Controls.Buttons btnPurchaseCourse;
        private Panel panel1;
        private Panel panel2;
        private DataGridView UserCoursesGridView;
        private Controls.CustomTextBox searchBox;
        private Label labelSearch;
    }
}