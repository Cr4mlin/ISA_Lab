namespace WinFormsApps
{
    partial class OwnerUsersViewForm
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
            UserCoursesGridView = new DataGridView();
            btnSearch = new Controls.Buttons();
            searchBox = new Controls.CustomTextBox();
            labelSearch = new Label();
            btnDelete = new Controls.Buttons();
            btnChangeRole = new Controls.Buttons();
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).BeginInit();
            SuspendLayout();
            // 
            // UserCoursesGridView
            // 
            UserCoursesGridView.BackgroundColor = Color.White;
            UserCoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserCoursesGridView.Location = new Point(16, 69);
            UserCoursesGridView.Name = "UserCoursesGridView";
            UserCoursesGridView.RowHeadersWidth = 51;
            UserCoursesGridView.Size = new Size(639, 366);
            UserCoursesGridView.TabIndex = 12;
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
            btnSearch.Location = new Point(661, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 37);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Поиск";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(250, 0, 164);
            searchBox.Location = new Point(110, 21);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(0, 0, 0, 1);
            searchBox.Size = new Size(545, 25);
            searchBox.TabIndex = 10;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.Location = new Point(16, 18);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(94, 28);
            labelSearch.TabIndex = 9;
            labelSearch.Text = "Поиск:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(250, 136, 230);
            btnDelete.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 20;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(661, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Удалить";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChangeRole
            // 
            btnChangeRole.BackColor = Color.FromArgb(250, 136, 230);
            btnChangeRole.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnChangeRole.BorderColor = Color.PaleVioletRed;
            btnChangeRole.BorderRadius = 20;
            btnChangeRole.BorderSize = 0;
            btnChangeRole.FlatAppearance.BorderSize = 0;
            btnChangeRole.FlatStyle = FlatStyle.Flat;
            btnChangeRole.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnChangeRole.ForeColor = Color.White;
            btnChangeRole.Location = new Point(661, 69);
            btnChangeRole.Name = "btnChangeRole";
            btnChangeRole.Size = new Size(124, 37);
            btnChangeRole.TabIndex = 14;
            btnChangeRole.Text = "Изменить";
            btnChangeRole.TextColor = Color.White;
            btnChangeRole.UseVisualStyleBackColor = false;
            // 
            // OwnerUsersViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeRole);
            Controls.Add(btnDelete);
            Controls.Add(UserCoursesGridView);
            Controls.Add(btnSearch);
            Controls.Add(searchBox);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OwnerUsersViewForm";
            Text = "OwnerUsersViewForm";
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserCoursesGridView;
        private Controls.Buttons btnSearch;
        private Controls.CustomTextBox searchBox;
        private Label labelSearch;
        private Controls.Buttons btnDelete;
        private Controls.Buttons btnChangeRole;
    }
}