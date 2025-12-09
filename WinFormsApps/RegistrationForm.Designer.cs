namespace WinFormsApps
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            pictureBoxLogo = new PictureBox();
            textBoxLogin = new LoginTextBox();
            textBoxPassword = new LoginTextBox();
            btnRegistration = new Controls.Buttons();
            lblLogin = new Label();
            textBoxNickName = new LoginTextBox();
            labelRegistrationError = new Label();
            panelTop = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            btnRollUp = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(306, 19);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(128, 128);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top;
            textBoxLogin.BackColor = Color.FromArgb(250, 0, 164);
            textBoxLogin.isPassword = false;
            textBoxLogin.label = "Логин";
            textBoxLogin.Location = new Point(236, 216);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Padding = new Padding(0, 0, 0, 1);
            textBoxLogin.Size = new Size(264, 56);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.BackColor = Color.FromArgb(250, 0, 164);
            textBoxPassword.isPassword = true;
            textBoxPassword.label = "Пароль";
            textBoxPassword.Location = new Point(236, 281);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(0, 0, 0, 1);
            textBoxPassword.Size = new Size(264, 56);
            textBoxPassword.TabIndex = 2;
            // 
            // btnRegistration
            // 
            btnRegistration.Anchor = AnchorStyles.Top;
            btnRegistration.BackColor = Color.FromArgb(250, 136, 230);
            btnRegistration.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnRegistration.BackgroundImageLayout = ImageLayout.None;
            btnRegistration.BorderColor = Color.PaleVioletRed;
            btnRegistration.BorderRadius = 25;
            btnRegistration.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(236, 375);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(264, 52);
            btnRegistration.TabIndex = 3;
            btnRegistration.Text = "Зарегистрироваться";
            btnRegistration.TextColor = Color.White;
            btnRegistration.UseVisualStyleBackColor = false;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblLogin.Location = new Point(343, 430);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(51, 20);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Войти";
            // 
            // textBoxNickName
            // 
            textBoxNickName.Anchor = AnchorStyles.Top;
            textBoxNickName.BackColor = Color.FromArgb(250, 0, 164);
            textBoxNickName.isPassword = false;
            textBoxNickName.label = "Имя пользователя";
            textBoxNickName.Location = new Point(236, 154);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Padding = new Padding(0, 0, 0, 1);
            textBoxNickName.Size = new Size(264, 56);
            textBoxNickName.TabIndex = 6;
            // 
            // labelRegistrationError
            // 
            labelRegistrationError.Anchor = AnchorStyles.Top;
            labelRegistrationError.AutoSize = true;
            labelRegistrationError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegistrationError.Location = new Point(273, 340);
            labelRegistrationError.Name = "labelRegistrationError";
            labelRegistrationError.Size = new Size(189, 20);
            labelRegistrationError.TabIndex = 7;
            labelRegistrationError.Text = "🛈 Недопустимый пароль";
            labelRegistrationError.Visible = false;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnClose);
            panelTop.Controls.Add(btnRollUp);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(736, 30);
            panelTop.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(706, 3);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 24);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRollUp
            // 
            btnRollUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRollUp.FlatAppearance.BorderSize = 0;
            btnRollUp.FlatStyle = FlatStyle.Flat;
            btnRollUp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnRollUp.IconColor = Color.Black;
            btnRollUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRollUp.IconSize = 20;
            btnRollUp.Location = new Point(676, 3);
            btnRollUp.Margin = new Padding(0);
            btnRollUp.Name = "btnRollUp";
            btnRollUp.Size = new Size(25, 24);
            btnRollUp.TabIndex = 3;
            btnRollUp.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 471);
            Controls.Add(panelTop);
            Controls.Add(labelRegistrationError);
            Controls.Add(textBoxNickName);
            Controls.Add(lblLogin);
            Controls.Add(btnRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private LoginTextBox textBoxLogin;
        private LoginTextBox textBoxPassword;
        private Controls.Buttons btnRegistration;
        private Label labelLoginError;
        private Label lblLogin;
        private LoginTextBox textBoxNickName;
        private Label labelRegistrationError;
        private Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnRollUp;
    }
}