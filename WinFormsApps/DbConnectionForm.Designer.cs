namespace WinFormsApps
{
    partial class DbConnectionForm
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
            rbEntityFramework = new Controls.RadioButtons();
            rbDapper = new Controls.RadioButtons();
            SuspendLayout();
            // 
            // rbEntityFramework
            // 
            rbEntityFramework.AutoSize = true;
            rbEntityFramework.CheckedColor = Color.FromArgb(250, 0, 164);
            rbEntityFramework.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbEntityFramework.Location = new Point(263, 178);
            rbEntityFramework.MinimumSize = new Size(0, 21);
            rbEntityFramework.Name = "rbEntityFramework";
            rbEntityFramework.Padding = new Padding(10, 0, 0, 0);
            rbEntityFramework.Size = new Size(303, 40);
            rbEntityFramework.TabIndex = 0;
            rbEntityFramework.TabStop = true;
            rbEntityFramework.Text = "EntityFramework";
            rbEntityFramework.UnCheckedColor = Color.Gray;
            rbEntityFramework.UseVisualStyleBackColor = true;
            rbEntityFramework.CheckedChanged += rbEntityFramework_CheckedChanged;
            // 
            // rbDapper
            // 
            rbDapper.AutoSize = true;
            rbDapper.CheckedColor = Color.FromArgb(250, 0, 164);
            rbDapper.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbDapper.Location = new Point(263, 222);
            rbDapper.MinimumSize = new Size(0, 21);
            rbDapper.Name = "rbDapper";
            rbDapper.Padding = new Padding(10, 0, 0, 0);
            rbDapper.Size = new Size(156, 40);
            rbDapper.TabIndex = 1;
            rbDapper.TabStop = true;
            rbDapper.Text = "Dapper";
            rbDapper.UnCheckedColor = Color.Gray;
            rbDapper.UseVisualStyleBackColor = true;
            rbDapper.CheckedChanged += rbDapper_CheckedChanged;
            // 
            // DbConnectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(rbDapper);
            Controls.Add(rbEntityFramework);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DbConnectionForm";
            Text = "DbConnectionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RadioButtons rbEntityFramework;
        private Controls.RadioButtons rbDapper;
    }
}