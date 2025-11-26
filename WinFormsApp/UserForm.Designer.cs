namespace WinFormsApp
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewCourses;
        private Button btnSearch;
        private Button btnPriceRange;
        private Button btnShowAll;
        private Button btnPurchaseCourse;
        private Button btnMyPurchases;
        private Button btnSelectConnection;
        private Label lblCurrentView;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

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
            dataGridViewCourses = new DataGridView();
            btnSearch = new Button();
            btnPriceRange = new Button();
            btnShowAll = new Button();
            btnPurchaseCourse = new Button();
            btnMyPurchases = new Button();
            btnSelectConnection = new Button();
            lblCurrentView = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            //
            // lblCurrentView
            //
            lblCurrentView.AutoSize = true;
            lblCurrentView.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCurrentView.Location = new Point(12, 9);
            lblCurrentView.Name = "lblCurrentView";
            lblCurrentView.Size = new Size(220, 19);
            lblCurrentView.TabIndex = 0;
            lblCurrentView.Text = "Отображение: Доступные курсы";
            //
            // dataGridViewCourses
            //
            dataGridViewCourses.AllowUserToAddRows = false;
            dataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCourses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCourses.ColumnHeadersHeight = 29;
            dataGridViewCourses.Location = new Point(3, 3);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.Size = new Size(874, 372);
            dataGridViewCourses.TabIndex = 1;
            dataGridViewCourses.SelectionChanged += dataGridViewCourses_SelectionChanged;
            dataGridViewCourses.CellDoubleClick += dataGridViewCourses_CellDoubleClick;
            //
            // btnSearch
            //
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(287, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Поиск курсов";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // btnPriceRange
            //
            btnPriceRange.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPriceRange.Location = new Point(296, 3);
            btnPriceRange.Name = "btnPriceRange";
            btnPriceRange.Size = new Size(287, 35);
            btnPriceRange.TabIndex = 3;
            btnPriceRange.Text = "Фильтр по цене";
            btnPriceRange.UseVisualStyleBackColor = true;
            btnPriceRange.Click += btnPriceRange_Click;
            //
            // btnShowAll
            //
            btnShowAll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowAll.Location = new Point(589, 3);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(288, 35);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Все активные курсы";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            //
            // btnPurchaseCourse
            //
            btnPurchaseCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPurchaseCourse.Location = new Point(3, 49);
            btnPurchaseCourse.Name = "btnPurchaseCourse";
            btnPurchaseCourse.Size = new Size(287, 35);
            btnPurchaseCourse.TabIndex = 5;
            btnPurchaseCourse.Text = "Купить курс";
            btnPurchaseCourse.UseVisualStyleBackColor = true;
            btnPurchaseCourse.Click += btnPurchaseCourse_Click;
            //
            // btnMyPurchases
            //
            btnMyPurchases.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMyPurchases.Location = new Point(296, 49);
            btnMyPurchases.Name = "btnMyPurchases";
            btnMyPurchases.Size = new Size(287, 35);
            btnMyPurchases.TabIndex = 6;
            btnMyPurchases.Text = "Мои купленные курсы";
            btnMyPurchases.UseVisualStyleBackColor = true;
            btnMyPurchases.Click += btnMyPurchases_Click;
            //
            // btnSelectConnection
            //
            btnSelectConnection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSelectConnection.Location = new Point(589, 49);
            btnSelectConnection.Name = "btnSelectConnection";
            btnSelectConnection.Size = new Size(288, 35);
            btnSelectConnection.TabIndex = 7;
            btnSelectConnection.Text = "Выбрать подключение";
            btnSelectConnection.UseVisualStyleBackColor = true;
            btnSelectConnection.Click += btnSelectConnection_Click;
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridViewCourses, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(-2, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(880, 473);
            tableLayoutPanel1.TabIndex = 8;
            //
            // tableLayoutPanel2
            //
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel2.Controls.Add(btnSearch, 0, 0);
            tableLayoutPanel2.Controls.Add(btnPriceRange, 1, 0);
            tableLayoutPanel2.Controls.Add(btnShowAll, 2, 0);
            tableLayoutPanel2.Controls.Add(btnPurchaseCourse, 0, 1);
            tableLayoutPanel2.Controls.Add(btnMyPurchases, 1, 1);
            tableLayoutPanel2.Controls.Add(btnSelectConnection, 2, 1);
            tableLayoutPanel2.Location = new Point(3, 381);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(880, 89);
            tableLayoutPanel2.TabIndex = 2;
            //
            // UserForm
            //
            ClientSize = new Size(884, 511);
            Controls.Add(lblCurrentView);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(900, 550);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Панель пользователя";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
