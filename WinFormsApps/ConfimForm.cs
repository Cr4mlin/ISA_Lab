using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApps
{
    public partial class ConfimForm : Form
    {
        public ConfimForm()
        {
            InitializeComponent();

            // Подписка на события кнопок
            btnConfirm.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnCancel.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }

        /// <summary>
        /// Устанавливает сообщение для отображения
        /// </summary>
        public void SetMessage(string message)
        {
            lblMessage.Text = message;
        }

        /// <summary>
        /// Показывает форму подтверждения и возвращает результат
        /// </summary>
        public static bool ShowConfirm(string message, string title = "Подтверждение")
        {
            using (var form = new ConfimForm())
            {
                form.Text = title;
                form.SetMessage(message);
                form.StartPosition = FormStartPosition.CenterScreen;
                return form.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
