using System;
using System.Drawing;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы профиля пользователя
    /// </summary>
    public interface IProfileView
    {
        /// <summary>
        /// Событие изменения аватара
        /// </summary>
        event EventHandler ChangeAvatarRequested;

        /// <summary>
        /// Событие удаления аватара
        /// </summary>
        event EventHandler DeleteAvatarRequested;

        /// <summary>
        /// Отображает аватар пользователя
        /// </summary>
        void DisplayAvatar(Image? avatar);

        /// <summary>
        /// Показывает сообщение об ошибке
        /// </summary>
        void ShowError(string message);

        /// <summary>
        /// Показывает информационное сообщение
        /// </summary>
        void ShowInfo(string message);

        /// <summary>
        /// Запрашивает выбор файла изображения
        /// </summary>
        string? RequestImageFile();

        /// <summary>
        /// Запрашивает подтверждение удаления аватара
        /// </summary>
        bool ConfirmDeleteAvatar();
    }
}
