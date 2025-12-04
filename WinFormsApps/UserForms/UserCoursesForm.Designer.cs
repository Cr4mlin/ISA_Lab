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
            searchBox = new Controls.CustomTextBox();
            labelSearch = new Label();
            btnSearch = new Controls.Buttons();
            btnAllCourses = new Controls.Buttons();
            btnViewPurchased = new Controls.Buttons();
            btnPurchaseCourse = new Controls.Buttons();
            UserCoursesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(250, 0, 164);
            searchBox.Location = new Point(113, 24);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(0, 0, 0, 1);
            searchBox.Size = new Size(545, 25);
            searchBox.TabIndex = 3;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.Location = new Point(19, 21);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(94, 28);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Поиск:";
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
            btnSearch.Location = new Point(664, 16);
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
            btnAllCourses.Location = new Point(664, 158);
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
            btnViewPurchased.Location = new Point(664, 115);
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
            btnPurchaseCourse.Location = new Point(664, 72);
            btnPurchaseCourse.Name = "btnPurchaseCourse";
            btnPurchaseCourse.Size = new Size(124, 37);
            btnPurchaseCourse.TabIndex = 7;
            btnPurchaseCourse.Text = "Купить";
            btnPurchaseCourse.TextColor = Color.White;
            btnPurchaseCourse.UseVisualStyleBackColor = false;
            // 
            // UserCoursesGridView
            // 
            UserCoursesGridView.BackgroundColor = Color.White;
            UserCoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserCoursesGridView.Location = new Point(19, 72);
            UserCoursesGridView.Name = "UserCoursesGridView";
            UserCoursesGridView.RowHeadersWidth = 51;
            UserCoursesGridView.Size = new Size(639, 366);
            UserCoursesGridView.TabIndex = 8;
            // 
            // UserCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(UserCoursesGridView);
            Controls.Add(btnPurchaseCourse);
            Controls.Add(btnViewPurchased);
            Controls.Add(btnAllCourses);
            Controls.Add(btnSearch);
            Controls.Add(searchBox);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserCoursesForm";
            Text = "OwnerCoursesView";
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomTextBox searchBox;
        private Label labelSearch;
        private Controls.Buttons btnSearch;
        private Controls.Buttons btnAllCourses;
        private Controls.Buttons btnViewPurchased;
        private Controls.Buttons btnPurchaseCourse;
        private DataGridView UserCoursesGridView;
    }
}