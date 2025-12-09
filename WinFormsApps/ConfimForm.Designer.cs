namespace WinFormsApps
{
    partial class ConfimForm
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
            btnConfirm = new Controls.Buttons();
            btnCancel = new Controls.Buttons();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(250, 136, 230);
            btnConfirm.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnConfirm.BorderColor = Color.PaleVioletRed;
            btnConfirm.BorderRadius = 20;
            btnConfirm.BorderSize = 0;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(11, 238);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(161, 41);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Да";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(250, 136, 230);
            btnCancel.BackgroundColor = Color.FromArgb(250, 136, 230);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(192, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 41);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Нет";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMessage.Location = new Point(12, 71);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(64, 22);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "label1";
            // 
            // ConfimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 318);
            Controls.Add(lblMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfimForm";
            Text = "ConfimeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.Buttons btnConfirm;
        private Controls.Buttons btnCancel;
        private Label lblMessage;
    }
}