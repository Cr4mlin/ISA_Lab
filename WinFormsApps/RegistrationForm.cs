using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace WinFormsApps
{
    public partial class RegistrationForm : Form, IRegistrationView
    {
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        public RegistrationForm()
        {
            InitializeComponent();

            // Подписка на события элементов управления
            btnRegistration.Click += (s, e) => RegistrationClicked?.Invoke(this, EventArgs.Empty);
            lblLogin.Click += (s, e) => LoginClicked?.Invoke(this, EventArgs.Empty);

            panelTop.MouseDown += Panel_MouseDown;
            panelTop.MouseMove += Panel_MouseMove;
            panelTop.MouseUp += Panel_MouseUp;

            // Кнопки управления окном
            btnClose.Click += (s, e) =>
            {
                CancelClicked?.Invoke(this, EventArgs.Empty);
            };
            btnRollUp.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Скрываем ошибку по умолчанию
            labelRegistrationError.Visible = false;
        }

        // Реализация IRegistrationView
        public string NickName => textBoxNickName.Text;
        public string Login => textBoxLogin.Text;
        public string Password => textBoxPassword.Text;

        public event EventHandler? RegistrationClicked;
        public event EventHandler? LoginClicked;
        public event EventHandler? CancelClicked;

        public void ShowError(string message)
        {
            labelRegistrationError.Text = message;
            labelRegistrationError.Visible = true;
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ClearFields()
        {
            textBoxNickName.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            labelRegistrationError.Visible = false;
        }

        public void SetDialogResultOk()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void SetDialogResultCancel()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void SetDialogResultAbort()
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { _dragging = true; _dragCursorPoint = Cursor.Position; _dragFormPoint = this.Location; }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) this.Location = Point.Add(_dragFormPoint, new Size(Point.Subtract(Cursor.Position, new Size(_dragCursorPoint))));
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e) => _dragging = false;

        // Реализация IView
        void IView.Show()
        {
            this.Show();
        }

        void IView.Hide()
        {
            this.Hide();
        }

        void IView.Close()
        {
            this.Close();
        }
    }
}
