using System;
using System.Drawing;
using System.Windows.Forms;
using Shared;

namespace WinFormsApps
{
    public partial class ProfileForm : Form, IProfileView
    {
        public ProfileForm()
        {
            InitializeComponent();

            // Настройка PictureBox
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            // Подписка на события кнопок
            btnChangeAvatar.Click += (s, e) => ChangeAvatarRequested?.Invoke(this, EventArgs.Empty);
        }

        // События
        public event EventHandler? ChangeAvatarRequested;

        // Методы отображения
        public void DisplayAvatar(Image? avatar)
        {
            try
            {
                // Освобождаем предыдущее изображение, чтобы избежать утечки памяти
                var oldImage = pictureBoxAvatar.Image;

                if (avatar != null)
                {
                    pictureBoxAvatar.Image = avatar;
                    pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBoxAvatar.Image = null;
                }

                if (oldImage != null && oldImage != avatar)
                {
                    oldImage.Dispose();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка при отображении аватара: {ex.Message}");
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string? RequestImageFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Выберите изображение для аватара";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                return null;
            }
        }

        public void SetUserInfo(string nickName, string userRole)
        {
            lblNickName.Text = nickName;
            lblUserRole.Text = userRole;
        }
    }
}
