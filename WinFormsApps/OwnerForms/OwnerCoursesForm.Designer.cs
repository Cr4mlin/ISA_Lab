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
            searchBox = new Controls.CustomTextBox();
            labelSearch = new Label();
            btnSearch = new Controls.Buttons();
            btnDelete = new Controls.Buttons();
            btnEdit = new Controls.Buttons();
            btnAdd = new Controls.Buttons();
            OwnerCoursesGridView = new DataGridView();
            btnChangeStatus = new Controls.Buttons();
            ((System.ComponentModel.ISupportInitialize)OwnerCoursesGridView).BeginInit();
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
            btnDelete.Location = new Point(664, 158);
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
            btnEdit.Location = new Point(664, 115);
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
            btnAdd.Location = new Point(664, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Добавить";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // OwnerCoursesGridView
            // 
            OwnerCoursesGridView.BackgroundColor = Color.White;
            OwnerCoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OwnerCoursesGridView.Location = new Point(19, 72);
            OwnerCoursesGridView.Name = "OwnerCoursesGridView";
            OwnerCoursesGridView.RowHeadersWidth = 51;
            OwnerCoursesGridView.Size = new Size(639, 366);
            OwnerCoursesGridView.TabIndex = 8;
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
            btnChangeStatus.Location = new Point(664, 201);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(124, 37);
            btnChangeStatus.TabIndex = 9;
            btnChangeStatus.Text = "Статус";
            btnChangeStatus.TextColor = Color.White;
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // OwnerCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeStatus);
            Controls.Add(OwnerCoursesGridView);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(searchBox);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OwnerCoursesForm";
            Text = "OwnerCoursesView";
            ((System.ComponentModel.ISupportInitialize)OwnerCoursesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomTextBox searchBox;
        private Label labelSearch;
        private Controls.Buttons btnSearch;
        private Controls.Buttons btnDelete;
        private Controls.Buttons btnEdit;
        private Controls.Buttons btnAdd;
        private DataGridView OwnerCoursesGridView;
        private Controls.Buttons btnChangeStatus;
    }
}