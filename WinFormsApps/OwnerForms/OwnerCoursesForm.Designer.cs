namespace WinFormsApps
{
    partial class OwnerCoursesForm
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
            btnDelete = new Controls.Buttons();
            btnEdit = new Controls.Buttons();
            btnAdd = new Controls.Buttons();
            btnChangeStatus = new Controls.Buttons();
            panel1 = new Panel();
            labelSearch = new Label();
            searchBox = new Controls.CustomTextBox();
            OwnerCoursesGridView = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OwnerCoursesGridView).BeginInit();
            panel2.SuspendLayout();
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
            btnSearch.Location = new Point(0, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 37);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Поиск";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(0, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(250, 136, 230);
            btnEdit.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnEdit.BorderColor = Color.PaleVioletRed;
            btnEdit.BorderRadius = 20;
            btnEdit.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(0, 115);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 37);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Изменить";
            btnEdit.TextColor = Color.White;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(250, 136, 230);
            btnAdd.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Добавить";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.FromArgb(250, 136, 230);
            btnChangeStatus.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnChangeStatus.BorderColor = Color.PaleVioletRed;
            btnChangeStatus.BorderRadius = 20;
            btnChangeStatus.BorderSize = 0;
            btnChangeStatus.FlatAppearance.BorderSize = 0;
            btnChangeStatus.FlatStyle = FlatStyle.Flat;
            btnChangeStatus.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnChangeStatus.ForeColor = Color.White;
            btnChangeStatus.Location = new Point(0, 201);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(124, 37);
            btnChangeStatus.TabIndex = 9;
            btnChangeStatus.Text = "Статус";
            btnChangeStatus.TextColor = Color.White;
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnChangeStatus);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(664, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 450);
            panel1.TabIndex = 10;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.ForeColor = Color.Black;
            labelSearch.Location = new Point(19, 24);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(94, 28);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Поиск:";
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.AutoSize = true;
            searchBox.BackColor = Color.FromArgb(250, 0, 164);
            searchBox.Location = new Point(119, 24);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(0, 0, 0, 1);
            searchBox.Size = new Size(538, 25);
            searchBox.TabIndex = 3;
            // 
            // OwnerCoursesGridView
            // 
            OwnerCoursesGridView.AllowUserToAddRows = false;
            OwnerCoursesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            OwnerCoursesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            OwnerCoursesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OwnerCoursesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OwnerCoursesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            OwnerCoursesGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OwnerCoursesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OwnerCoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OwnerCoursesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            OwnerCoursesGridView.Location = new Point(16, 69);
            OwnerCoursesGridView.MultiSelect = false;
            OwnerCoursesGridView.Name = "OwnerCoursesGridView";
            OwnerCoursesGridView.ReadOnly = true;
            OwnerCoursesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            OwnerCoursesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            OwnerCoursesGridView.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OwnerCoursesGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            OwnerCoursesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OwnerCoursesGridView.Size = new Size(639, 366);
            OwnerCoursesGridView.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(OwnerCoursesGridView);
            panel2.Controls.Add(searchBox);
            panel2.Controls.Add(labelSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 450);
            panel2.TabIndex = 11;
            // 
            // OwnerCoursesForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OwnerCoursesForm";
            Text = "OwnerCoursesView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OwnerCoursesGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Controls.Buttons btnSearch;
        private Controls.Buttons btnDelete;
        private Controls.Buttons btnEdit;
        private Controls.Buttons btnAdd;
        private Controls.Buttons btnChangeStatus;
        private Panel panel1;
        private Label labelSearch;
        private Controls.CustomTextBox searchBox;
        private DataGridView OwnerCoursesGridView;
        private Panel panel2;
    }
}