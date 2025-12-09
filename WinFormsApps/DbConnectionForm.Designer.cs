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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rbEntityFramework
            // 
            rbEntityFramework.Anchor = AnchorStyles.None;
            rbEntityFramework.AutoSize = true;
            rbEntityFramework.BackColor = Color.White;
            rbEntityFramework.CheckedColor = Color.FromArgb(250, 0, 164);
            rbEntityFramework.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbEntityFramework.ForeColor = Color.Black;
            rbEntityFramework.Location = new Point(265, 172);
            rbEntityFramework.MinimumSize = new Size(0, 21);
            rbEntityFramework.Name = "rbEntityFramework";
            rbEntityFramework.Padding = new Padding(10, 0, 0, 0);
            rbEntityFramework.Size = new Size(303, 40);
            rbEntityFramework.TabIndex = 0;
            rbEntityFramework.TabStop = true;
            rbEntityFramework.Text = "EntityFramework";
            rbEntityFramework.UnCheckedColor = Color.Gray;
            rbEntityFramework.UseVisualStyleBackColor = false;
            rbEntityFramework.CheckedChanged += rbEntityFramework_CheckedChanged;
            // 
            // rbDapper
            // 
            rbDapper.Anchor = AnchorStyles.None;
            rbDapper.AutoSize = true;
            rbDapper.BackColor = Color.White;
            rbDapper.CheckedColor = Color.FromArgb(250, 0, 164);
            rbDapper.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbDapper.ForeColor = Color.Black;
            rbDapper.Location = new Point(265, 242);
            rbDapper.MinimumSize = new Size(0, 21);
            rbDapper.Name = "rbDapper";
            rbDapper.Padding = new Padding(10, 0, 0, 0);
            rbDapper.Size = new Size(156, 40);
            rbDapper.TabIndex = 1;
            rbDapper.TabStop = true;
            rbDapper.Text = "Dapper";
            rbDapper.UnCheckedColor = Color.Gray;
            rbDapper.UseVisualStyleBackColor = false;
            rbDapper.CheckedChanged += rbDapper_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbEntityFramework);
            panel1.Controls.Add(rbDapper);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // DbConnectionForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DbConnectionForm";
            Text = "DbConnectionForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.RadioButtons rbEntityFramework;
        private Controls.RadioButtons rbDapper;
        private Panel panel1;
    }
}