namespace WinFormsApps
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBoxLogo = new PictureBox();
            textBoxLogin = new LoginTextBox();
            textBoxPassword = new LoginTextBox();
            btnLogin = new Controls.Buttons();
            labelLoginError = new Label();
            labelRegistration = new Label();
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
            textBoxLogin.Location = new Point(236, 167);
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
            textBoxPassword.Location = new Point(236, 232);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(0, 0, 0, 1);
            textBoxPassword.Size = new Size(264, 56);
            textBoxPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(250, 136, 230);
            btnLogin.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 25;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(236, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 52);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // labelLoginError
            // 
            labelLoginError.Anchor = AnchorStyles.Top;
            labelLoginError.AutoSize = true;
            labelLoginError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLoginError.Location = new Point(236, 300);
            labelLoginError.Name = "labelLoginError";
            labelLoginError.Size = new Size(264, 20);
            labelLoginError.TabIndex = 4;
            labelLoginError.Text = "🛈 Неправильный логин или пароль";
            labelLoginError.Visible = false;
            // 
            // labelRegistration
            // 
            labelRegistration.Anchor = AnchorStyles.Top;
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegistration.Location = new Point(295, 433);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(151, 20);
            labelRegistration.TabIndex = 5;
            labelRegistration.Text = "Зарегистрироваться";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnClose);
            panelTop.Controls.Add(btnRollUp);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(736, 30);
            panelTop.TabIndex = 9;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 471);
            Controls.Add(panelTop);
            Controls.Add(labelRegistration);
            Controls.Add(labelLoginError);
            Controls.Add(btnLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private LoginTextBox textBoxLogin;
        private LoginTextBox textBoxPassword;
        private Controls.Buttons btnLogin;
        private Label labelLoginError;
        private Label labelRegistration;
        private Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnRollUp;
    }
}