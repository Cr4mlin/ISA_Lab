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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            UserCoursesGridView = new DataGridView();
            btnSearch = new Controls.Buttons();
            searchBox = new Controls.CustomTextBox();
            labelSearch = new Label();
            btnDelete = new Controls.Buttons();
            btnChangeRole = new Controls.Buttons();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            UserCoursesGridView.Location = new Point(12, 69);
            UserCoursesGridView.MultiSelect = false;
            UserCoursesGridView.Name = "UserCoursesGridView";
            UserCoursesGridView.ReadOnly = true;
            UserCoursesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            UserCoursesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            UserCoursesGridView.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserCoursesGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            UserCoursesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            btnSearch.Location = new Point(0, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 37);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Поиск";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.BackColor = Color.FromArgb(250, 0, 164);
            searchBox.Location = new Point(112, 21);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(0, 0, 0, 1);
            searchBox.Size = new Size(538, 25);
            searchBox.TabIndex = 10;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.ForeColor = Color.Black;
            labelSearch.Location = new Point(12, 21);
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
            btnDelete.Location = new Point(0, 112);
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
            btnChangeRole.Location = new Point(0, 69);
            btnChangeRole.Name = "btnChangeRole";
            btnChangeRole.Size = new Size(124, 37);
            btnChangeRole.TabIndex = 14;
            btnChangeRole.Text = "Изменить";
            btnChangeRole.TextColor = Color.White;
            btnChangeRole.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnChangeRole);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(661, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 450);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelSearch);
            panel2.Controls.Add(UserCoursesGridView);
            panel2.Controls.Add(searchBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 450);
            panel2.TabIndex = 16;
            // 
            // OwnerUsersViewForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OwnerUsersViewForm";
            Text = "OwnerUsersViewForm";
            ((System.ComponentModel.ISupportInitialize)UserCoursesGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UserCoursesGridView;
        private Controls.Buttons btnSearch;
        private Controls.CustomTextBox searchBox;
        private Label labelSearch;
        private Controls.Buttons btnDelete;
        private Controls.Buttons btnChangeRole;
        private Panel panel1;
        private Panel panel2;
    }
}