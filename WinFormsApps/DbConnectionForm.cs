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
    public partial class DbConnectionForm : Form, IDbConnectionView
    {
        private bool _isLoading = true;

        public DbConnectionForm()
        {
            InitializeComponent();
            LoadCurrentConnectionType();
            _isLoading = false;
        }

        private void LoadCurrentConnectionType()
        {
            try
            {
                string settingsFile = "appsettings.txt";
                if (System.IO.File.Exists(settingsFile))
                {
                    string connectionType = System.IO.File.ReadAllText(settingsFile).Trim();
                    if (connectionType == "EntityFramework" || connectionType == "1")
                    {
                        rbEntityFramework.Checked = true;
                    }
                    else if (connectionType == "Dapper" || connectionType == "2")
                    {
                        rbDapper.Checked = true;
                    }
                }
                else
                {
                    // По умолчанию EntityFramework
                    rbEntityFramework.Checked = true;
                }
            }
            catch
            {
                // По умолчанию EntityFramework
                rbEntityFramework.Checked = true;
            }
        }

        // Реализация IDbConnectionView
        public string SelectedConnectionType
        {
            get
            {
                if (rbEntityFramework.Checked)
                    return "EntityFramework";
                if (rbDapper.Checked)
                    return "Dapper";
                return string.Empty;
            }
        }

        public event EventHandler? ConfirmClicked;
        public event EventHandler? CancelClicked;

        public void SetDialogResultOk()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void SetDialogResultCancel()
        {
            this.DialogResult = DialogResult.Cancel;
        }

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

        private void rbEntityFramework_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEntityFramework.Checked && !_isLoading)
            {
                // Сохраняем выбор в файл настроек
                SaveConnectionType("EntityFramework");

                ConfirmClicked?.Invoke(this, EventArgs.Empty);

                // Показываем сообщение о смене подключения и закрываем форму
                MessageBox.Show("Тип подключения изменен на EntityFramework.\nПриложение будет перезапущено.",
                    "Изменение подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем все формы приложения для перезапуска
                Application.Exit();
                Application.Restart();
            }
        }

        private void rbDapper_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDapper.Checked && !_isLoading)
            {
                // Сохраняем выбор в файл настроек
                SaveConnectionType("Dapper");

                ConfirmClicked?.Invoke(this, EventArgs.Empty);

                // Показываем сообщение о смене подключения и закрываем форму
                MessageBox.Show("Тип подключения изменен на Dapper.\nПриложение будет перезапущено.",
                    "Изменение подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем все формы приложения для перезапуска
                Application.Exit();
                Application.Restart();
            }
        }

        private void SaveConnectionType(string connectionType)
        {
            try
            {
                string settingsFile = "appsettings.txt";
                System.IO.File.WriteAllText(settingsFile, connectionType);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении настроек: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
