namespace WinFormsApps
{
    partial class OwnerMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerMainForm));
            sideMenu = new Panel();
            panelUser = new Panel();
            lblUsername = new Label();
            avatarPictureBox = new Controls.CircularPictureBox();
            btnDbConnection = new FontAwesome.Sharp.IconButton();
            btnExport = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnCourses = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            Logo = new PictureBox();
            panelTitleBar = new Panel();
            btnWIndowRestore = new FontAwesome.Sharp.IconButton();
            btnRollUp = new FontAwesome.Sharp.IconButton();
            btnFullWindow = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            labelCurrentChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelChildForm = new Panel();
            sideMenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // sideMenu
            // 
            sideMenu.AutoScroll = true;
            sideMenu.BackColor = Color.FromArgb(250, 136, 230);
            sideMenu.Controls.Add(panelUser);
            sideMenu.Controls.Add(btnDbConnection);
            sideMenu.Controls.Add(btnExport);
            sideMenu.Controls.Add(btnUsers);
            sideMenu.Controls.Add(btnCourses);
            sideMenu.Controls.Add(panelLogo);
            sideMenu.Dock = DockStyle.Left;
            sideMenu.ForeColor = SystemColors.ControlText;
            sideMenu.Location = new Point(0, 0);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(230, 511);
            sideMenu.TabIndex = 0;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(lblUsername);
            panelUser.Controls.Add(avatarPictureBox);
            panelUser.Dock = DockStyle.Bottom;
            panelUser.Location = new Point(0, 451);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(230, 60);
            panelUser.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(66, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 22);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "label1";
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.BackColor = Color.Transparent;
            avatarPictureBox.Dock = DockStyle.Left;
            avatarPictureBox.Location = new Point(0, 0);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(60, 60);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 0;
            avatarPictureBox.TabStop = false;
            // 
            // btnDbConnection
            // 
            btnDbConnection.Dock = DockStyle.Top;
            btnDbConnection.FlatAppearance.BorderSize = 0;
            btnDbConnection.FlatStyle = FlatStyle.Flat;
            btnDbConnection.Font = new Font("Verdana", 11.8F);
            btnDbConnection.ForeColor = Color.White;
            btnDbConnection.IconChar = FontAwesome.Sharp.IconChar.ArrowRightArrowLeft;
            btnDbConnection.IconColor = Color.White;
            btnDbConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDbConnection.IconSize = 44;
            btnDbConnection.ImageAlign = ContentAlignment.MiddleLeft;
            btnDbConnection.Location = new Point(0, 278);
            btnDbConnection.Name = "btnDbConnection";
            btnDbConnection.Padding = new Padding(10, 0, 0, 0);
            btnDbConnection.Size = new Size(230, 53);
            btnDbConnection.TabIndex = 4;
            btnDbConnection.Text = "Подключение";
            btnDbConnection.TextAlign = ContentAlignment.MiddleLeft;
            btnDbConnection.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDbConnection.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Top;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Verdana", 11.8F);
            btnExport.ForeColor = Color.White;
            btnExport.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnExport.IconColor = Color.White;
            btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExport.IconSize = 44;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(0, 225);
            btnExport.Name = "btnExport";
            btnExport.Padding = new Padding(10, 0, 0, 0);
            btnExport.RightToLeft = RightToLeft.No;
            btnExport.Size = new Size(230, 53);
            btnExport.TabIndex = 3;
            btnExport.Text = "Экспорт";
            btnExport.TextAlign = ContentAlignment.MiddleLeft;
            btnExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Verdana", 11.8F);
            btnUsers.ForeColor = Color.White;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsers.IconColor = Color.White;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 172);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(10, 0, 0, 0);
            btnUsers.Size = new Size(230, 53);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Пользователи";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            btnCourses.Dock = DockStyle.Top;
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCourses.ForeColor = Color.White;
            btnCourses.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnCourses.IconColor = Color.White;
            btnCourses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCourses.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourses.Location = new Point(0, 119);
            btnCourses.Name = "btnCourses";
            btnCourses.Padding = new Padding(10, 0, 0, 0);
            btnCourses.Size = new Size(230, 53);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "Курсы";
            btnCourses.TextAlign = ContentAlignment.MiddleLeft;
            btnCourses.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCourses.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(250, 0, 164);
            panelLogo.Controls.Add(Logo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(230, 119);
            panelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(54, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(119, 119);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(250, 0, 164);
            panelTitleBar.Controls.Add(btnWIndowRestore);
            panelTitleBar.Controls.Add(btnRollUp);
            panelTitleBar.Controls.Add(btnFullWindow);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(labelCurrentChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(230, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(696, 58);
            panelTitleBar.TabIndex = 1;
            // 
            // btnWIndowRestore
            // 
            btnWIndowRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWIndowRestore.FlatAppearance.BorderSize = 0;
            btnWIndowRestore.FlatStyle = FlatStyle.Flat;
            btnWIndowRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnWIndowRestore.IconColor = Color.White;
            btnWIndowRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWIndowRestore.IconSize = 20;
            btnWIndowRestore.Location = new Point(646, 0);
            btnWIndowRestore.Margin = new Padding(0);
            btnWIndowRestore.Name = "btnWIndowRestore";
            btnWIndowRestore.Size = new Size(25, 24);
            btnWIndowRestore.TabIndex = 5;
            btnWIndowRestore.UseVisualStyleBackColor = true;
            btnWIndowRestore.Visible = false;
            // 
            // btnRollUp
            // 
            btnRollUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRollUp.FlatAppearance.BorderSize = 0;
            btnRollUp.FlatStyle = FlatStyle.Flat;
            btnRollUp.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnRollUp.IconColor = Color.White;
            btnRollUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRollUp.IconSize = 20;
            btnRollUp.Location = new Point(621, 0);
            btnRollUp.Margin = new Padding(0);
            btnRollUp.Name = "btnRollUp";
            btnRollUp.Size = new Size(25, 24);
            btnRollUp.TabIndex = 4;
            btnRollUp.UseVisualStyleBackColor = true;
            // 
            // btnFullWindow
            // 
            btnFullWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFullWindow.FlatAppearance.BorderSize = 0;
            btnFullWindow.FlatStyle = FlatStyle.Flat;
            btnFullWindow.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnFullWindow.IconColor = Color.White;
            btnFullWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFullWindow.IconSize = 17;
            btnFullWindow.Location = new Point(646, 0);
            btnFullWindow.Margin = new Padding(0);
            btnFullWindow.Name = "btnFullWindow";
            btnFullWindow.Size = new Size(25, 24);
            btnFullWindow.TabIndex = 3;
            btnFullWindow.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(671, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 24);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // labelCurrentChildForm
            // 
            labelCurrentChildForm.AutoSize = true;
            labelCurrentChildForm.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCurrentChildForm.ForeColor = Color.White;
            labelCurrentChildForm.Location = new Point(61, 17);
            labelCurrentChildForm.Name = "labelCurrentChildForm";
            labelCurrentChildForm.Size = new Size(107, 25);
            labelCurrentChildForm.TabIndex = 1;
            labelCurrentChildForm.Text = "Главная";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(250, 0, 164);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 48;
            iconCurrentChildForm.Location = new Point(10, 7);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(48, 48);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(230, 58);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(696, 453);
            panelChildForm.TabIndex = 2;
            // 
            // OwnerMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 511);
            Controls.Add(panelChildForm);
            Controls.Add(panelTitleBar);
            Controls.Add(sideMenu);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OwnerMainForm";
            Text = "OnlineSchool";
            Load += Form1_Load;
            sideMenu.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideMenu;
        private FontAwesome.Sharp.IconButton btnCourses;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDbConnection;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnUsers;
        private Panel panelTitleBar;
        private PictureBox Logo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label labelCurrentChildForm;
        private Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnRollUp;
        private FontAwesome.Sharp.IconButton btnFullWindow;
        private FontAwesome.Sharp.IconButton btnWIndowRestore;
        private Panel panelUser;
        private Controls.CircularPictureBox avatarPictureBox;
        private Label lblUsername;
    }
}
