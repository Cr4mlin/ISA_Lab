namespace WinFormsApps
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBoxAvatar = new PictureBox();
            btnChangeAvatar = new Controls.Buttons();
            panel2 = new Panel();
            lblUserRole = new Label();
            lblNickNameInscription = new Label();
            lblNickName = new Label();
            lblUserRoleInscription = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.05636F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.94364F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.63876F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.3612328F));
            tableLayoutPanel1.Size = new Size(763, 454);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxAvatar);
            panel1.Controls.Add(btnChangeAvatar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 448);
            panel1.TabIndex = 19;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Anchor = AnchorStyles.None;
            pictureBoxAvatar.Image = (Image)resources.GetObject("pictureBoxAvatar.Image");
            pictureBoxAvatar.InitialImage = (Image)resources.GetObject("pictureBoxAvatar.InitialImage");
            pictureBoxAvatar.Location = new Point(69, 52);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(185, 185);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 18;
            pictureBoxAvatar.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            btnChangeAvatar.Anchor = AnchorStyles.None;
            btnChangeAvatar.BackColor = Color.FromArgb(250, 136, 230);
            btnChangeAvatar.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnChangeAvatar.BorderColor = Color.PaleVioletRed;
            btnChangeAvatar.BorderRadius = 20;
            btnChangeAvatar.BorderSize = 0;
            btnChangeAvatar.FlatAppearance.BorderSize = 0;
            btnChangeAvatar.FlatStyle = FlatStyle.Flat;
            btnChangeAvatar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnChangeAvatar.ForeColor = Color.White;
            btnChangeAvatar.Location = new Point(69, 276);
            btnChangeAvatar.Name = "btnChangeAvatar";
            btnChangeAvatar.Size = new Size(185, 50);
            btnChangeAvatar.TabIndex = 19;
            btnChangeAvatar.Text = "Изменить аватар";
            btnChangeAvatar.TextColor = Color.White;
            btnChangeAvatar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUserRole);
            panel2.Controls.Add(lblNickNameInscription);
            panel2.Controls.Add(lblNickName);
            panel2.Controls.Add(lblUserRoleInscription);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(301, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 448);
            panel2.TabIndex = 20;
            // 
            // lblUserRole
            // 
            lblUserRole.Anchor = AnchorStyles.None;
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUserRole.ForeColor = Color.Black;
            lblUserRole.Location = new Point(202, 175);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(64, 22);
            lblUserRole.TabIndex = 19;
            lblUserRole.Text = "label4";
            // 
            // lblNickNameInscription
            // 
            lblNickNameInscription.Anchor = AnchorStyles.None;
            lblNickNameInscription.AutoSize = true;
            lblNickNameInscription.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNickNameInscription.ForeColor = Color.Black;
            lblNickNameInscription.Location = new Point(9, 110);
            lblNickNameInscription.Name = "lblNickNameInscription";
            lblNickNameInscription.Size = new Size(189, 22);
            lblNickNameInscription.TabIndex = 16;
            lblNickNameInscription.Text = "Имя пользователя:";
            // 
            // lblNickName
            // 
            lblNickName.Anchor = AnchorStyles.None;
            lblNickName.AutoSize = true;
            lblNickName.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNickName.ForeColor = Color.Black;
            lblNickName.Location = new Point(204, 110);
            lblNickName.Name = "lblNickName";
            lblNickName.Size = new Size(64, 22);
            lblNickName.TabIndex = 17;
            lblNickName.Text = "label2";
            // 
            // lblUserRoleInscription
            // 
            lblUserRoleInscription.Anchor = AnchorStyles.None;
            lblUserRoleInscription.AutoSize = true;
            lblUserRoleInscription.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUserRoleInscription.ForeColor = Color.Black;
            lblUserRoleInscription.Location = new Point(9, 175);
            lblUserRoleInscription.Name = "lblUserRoleInscription";
            lblUserRoleInscription.Size = new Size(61, 22);
            lblUserRoleInscription.TabIndex = 18;
            lblUserRoleInscription.Text = "Роль:";
            // 
            // ProfileForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(763, 454);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBoxAvatar;
        private Controls.Buttons btnChangeAvatar;
        private Panel panel2;
        private Label lblUserRole;
        private Label lblNickNameInscription;
        private Label lblNickName;
        private Label lblUserRoleInscription;
    }
}