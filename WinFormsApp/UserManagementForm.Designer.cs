namespace WinFormsApp
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewUsers;
        private Button btnChangeToAdmin;
        private Button btnChangeToUser;
        private Button btnClose;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblTotalUsers;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnFilterAdmin;
        private Button btnFilterUser;
        private Button btnShowAll;
        private Panel panelTop;
        private Panel panelBottom;
        private GroupBox groupBoxFilters;
        private GroupBox groupBoxActions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            btnChangeToAdmin = new Button();
            btnChangeToUser = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            lblInfo = new Label();
            lblTotalUsers = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnFilterAdmin = new Button();
            btnFilterUser = new Button();
            btnShowAll = new Button();
            panelTop = new Panel();
            panelBottom = new Panel();
            groupBoxActions = new GroupBox();
            groupBoxFilters = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            groupBoxActions.SuspendLayout();
            groupBoxFilters.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ColumnHeadersHeight = 29;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(11, 226);
            dataGridViewUsers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1121, 427);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // btnChangeToAdmin
            // 
            btnChangeToAdmin.Enabled = false;
            btnChangeToAdmin.Location = new Point(15, 40);
            btnChangeToAdmin.Margin = new Padding(3, 4, 3, 4);
            btnChangeToAdmin.Name = "btnChangeToAdmin";
            btnChangeToAdmin.Size = new Size(206, 53);
            btnChangeToAdmin.TabIndex = 0;
            btnChangeToAdmin.Text = "Сделать администратором";
            btnChangeToAdmin.UseVisualStyleBackColor = true;
            btnChangeToAdmin.Click += btnChangeToAdmin_Click;
            // 
            // btnChangeToUser
            // 
            btnChangeToUser.Enabled = false;
            btnChangeToUser.Location = new Point(232, 40);
            btnChangeToUser.Margin = new Padding(3, 4, 3, 4);
            btnChangeToUser.Name = "btnChangeToUser";
            btnChangeToUser.Size = new Size(206, 53);
            btnChangeToUser.TabIndex = 1;
            btnChangeToUser.Text = "Сделать пользователем";
            btnChangeToUser.UseVisualStyleBackColor = true;
            btnChangeToUser.Click += btnChangeToUser_Click;
            //
            // btnClose
            //
            btnClose.Location = new Point(449, 40);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(206, 53);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(15, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(359, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Управление пользователями";
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Top;
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.ForeColor = Color.Gray;
            lblInfo.Location = new Point(0, 13);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(6, 7, 6, 7);
            lblInfo.Size = new Size(1121, 40);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Выберите пользователя для изменения роли";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Segoe UI", 10F);
            lblTotalUsers.ForeColor = Color.DarkBlue;
            lblTotalUsers.Location = new Point(15, 51);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(195, 23);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "Всего пользователей: 0";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 60);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Введите логин или ID для поиска...";
            txtSearch.Size = new Size(399, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(55, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Поиск:";
            // 
            // btnFilterAdmin
            // 
            btnFilterAdmin.Location = new Point(434, 57);
            btnFilterAdmin.Margin = new Padding(3, 4, 3, 4);
            btnFilterAdmin.Name = "btnFilterAdmin";
            btnFilterAdmin.Size = new Size(191, 40);
            btnFilterAdmin.TabIndex = 2;
            btnFilterAdmin.Text = "Только администраторы";
            btnFilterAdmin.UseVisualStyleBackColor = true;
            btnFilterAdmin.Click += btnFilterAdmin_Click;
            // 
            // btnFilterUser
            // 
            btnFilterUser.Location = new Point(636, 57);
            btnFilterUser.Margin = new Padding(3, 4, 3, 4);
            btnFilterUser.Name = "btnFilterUser";
            btnFilterUser.Size = new Size(171, 40);
            btnFilterUser.TabIndex = 3;
            btnFilterUser.Text = "Только пользователи";
            btnFilterUser.UseVisualStyleBackColor = true;
            btnFilterUser.Click += btnFilterUser_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(819, 57);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(137, 40);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Показать всех";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblTotalUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(11, 13);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(11, 13, 11, 13);
            panelTop.Size = new Size(1121, 80);
            panelTop.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(lblInfo);
            panelBottom.Controls.Add(groupBoxActions);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(11, 653);
            panelBottom.Margin = new Padding(3, 4, 3, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(0, 13, 0, 13);
            panelBottom.Size = new Size(1121, 187);
            panelBottom.TabIndex = 3;
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(btnChangeToAdmin);
            groupBoxActions.Controls.Add(btnChangeToUser);
            groupBoxActions.Controls.Add(btnClose);
            groupBoxActions.Dock = DockStyle.Bottom;
            groupBoxActions.Location = new Point(0, 54);
            groupBoxActions.Margin = new Padding(3, 4, 3, 4);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Padding = new Padding(11, 13, 11, 13);
            groupBoxActions.Size = new Size(1121, 120);
            groupBoxActions.TabIndex = 1;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Действия";
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(lblSearch);
            groupBoxFilters.Controls.Add(txtSearch);
            groupBoxFilters.Controls.Add(btnFilterAdmin);
            groupBoxFilters.Controls.Add(btnFilterUser);
            groupBoxFilters.Controls.Add(btnShowAll);
            groupBoxFilters.Dock = DockStyle.Top;
            groupBoxFilters.Location = new Point(11, 93);
            groupBoxFilters.Margin = new Padding(3, 4, 3, 4);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Padding = new Padding(11, 13, 11, 13);
            groupBoxFilters.Size = new Size(1121, 133);
            groupBoxFilters.TabIndex = 1;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Фильтры и поиск";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 853);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panelBottom);
            Controls.Add(groupBoxFilters);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1159, 890);
            Name = "UserManagementForm";
            Padding = new Padding(11, 13, 11, 13);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Управление пользователями";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            groupBoxActions.ResumeLayout(false);
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            ResumeLayout(false);
        }
    }
}
