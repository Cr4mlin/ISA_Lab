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
            pictureBoxAvatar = new PictureBox();
            btnChangeAvatar = new Controls.Buttons();
            lblNickNameInscription = new Label();
            lblNickName = new Label();
            lblUserRoleInscription = new Label();
            lblUserRole = new Label();
            btnDeleteAvatar = new Controls.Buttons();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Location = new Point(69, 102);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(185, 185);
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            btnChangeAvatar.BackColor = Color.FromArgb(250, 136, 230);
            btnChangeAvatar.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnChangeAvatar.BorderColor = Color.PaleVioletRed;
            btnChangeAvatar.BorderRadius = 20;
            btnChangeAvatar.BorderSize = 0;
            btnChangeAvatar.FlatAppearance.BorderSize = 0;
            btnChangeAvatar.FlatStyle = FlatStyle.Flat;
            btnChangeAvatar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnChangeAvatar.ForeColor = Color.White;
            btnChangeAvatar.Location = new Point(69, 293);
            btnChangeAvatar.Name = "btnChangeAvatar";
            btnChangeAvatar.Size = new Size(185, 50);
            btnChangeAvatar.TabIndex = 1;
            btnChangeAvatar.Text = "Изменить аватар";
            btnChangeAvatar.TextColor = Color.White;
            btnChangeAvatar.UseVisualStyleBackColor = false;
            // 
            // lblNickNameInscription
            // 
            lblNickNameInscription.AutoSize = true;
            lblNickNameInscription.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNickNameInscription.Location = new Point(291, 155);
            lblNickNameInscription.Name = "lblNickNameInscription";
            lblNickNameInscription.Size = new Size(189, 22);
            lblNickNameInscription.TabIndex = 2;
            lblNickNameInscription.Text = "Имя пользователя:";
            // 
            // lblNickName
            // 
            lblNickName.AutoSize = true;
            lblNickName.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNickName.Location = new Point(492, 155);
            lblNickName.Name = "lblNickName";
            lblNickName.Size = new Size(64, 22);
            lblNickName.TabIndex = 3;
            lblNickName.Text = "label2";
            // 
            // lblUserRoleInscription
            // 
            lblUserRoleInscription.AutoSize = true;
            lblUserRoleInscription.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUserRoleInscription.Location = new Point(291, 226);
            lblUserRoleInscription.Name = "lblUserRoleInscription";
            lblUserRoleInscription.Size = new Size(61, 22);
            lblUserRoleInscription.TabIndex = 4;
            lblUserRoleInscription.Text = "Роль:";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUserRole.Location = new Point(492, 228);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(64, 22);
            lblUserRole.TabIndex = 5;
            lblUserRole.Text = "label4";
            // 
            // btnDeleteAvatar
            // 
            btnDeleteAvatar.BackColor = Color.FromArgb(250, 136, 230);
            btnDeleteAvatar.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnDeleteAvatar.BorderColor = Color.PaleVioletRed;
            btnDeleteAvatar.BorderRadius = 20;
            btnDeleteAvatar.BorderSize = 0;
            btnDeleteAvatar.FlatAppearance.BorderSize = 0;
            btnDeleteAvatar.FlatStyle = FlatStyle.Flat;
            btnDeleteAvatar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteAvatar.ForeColor = Color.White;
            btnDeleteAvatar.Location = new Point(69, 349);
            btnDeleteAvatar.Name = "btnDeleteAvatar";
            btnDeleteAvatar.Size = new Size(185, 50);
            btnDeleteAvatar.TabIndex = 6;
            btnDeleteAvatar.Text = "Удалить аватар";
            btnDeleteAvatar.TextColor = Color.White;
            btnDeleteAvatar.UseVisualStyleBackColor = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 454);
            Controls.Add(btnDeleteAvatar);
            Controls.Add(lblUserRole);
            Controls.Add(lblUserRoleInscription);
            Controls.Add(lblNickName);
            Controls.Add(lblNickNameInscription);
            Controls.Add(btnChangeAvatar);
            Controls.Add(pictureBoxAvatar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private Controls.Buttons btnChangeAvatar;
        private Label lblNickNameInscription;
        private Label lblNickName;
        private Label lblUserRoleInscription;
        private Label lblUserRole;
        private Controls.Buttons btnDeleteAvatar;
    }
}