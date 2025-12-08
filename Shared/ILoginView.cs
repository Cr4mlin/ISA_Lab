using System;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы авторизации
    /// </summary>
    public interface ILoginView : IView
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        string Login { get; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        string Password { get; }

        /// <summary>
        /// Событие нажатия на кнопку входа
        /// </summary>
        event EventHandler LoginClicked;

        /// <summary>
        /// Событие нажатия на кнопку регистрации
        /// </summary>
        event EventHandler RegisterClicked;

        /// <summary>
        /// Событие отмены операции
        /// </summary>
        event EventHandler CancelClicked;

        /// <summary>
        /// Отображает сообщение об ошибке
        /// </summary>
        void ShowError(string message);

        /// <summary>
        /// Отображает информационное сообщение
        /// </summary>
        void ShowInfo(string message);

        /// <summary>
        /// Очищает поля формы
        /// </summary>
        void ClearFields();

        /// <summary>
        /// Устанавливает результат диалога как успешный
        /// </summary>
        void SetDialogResultOk();

        /// <summary>
        /// Устанавливает результат диалога как отмену
        /// </summary>
        void SetDialogResultCancel();

        /// <summary>
        /// Устанавливает результат диалога как прерывание (выход из приложения)
        /// </summary>
        void SetDialogResultAbort();
    }
}
