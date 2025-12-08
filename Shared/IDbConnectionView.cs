using System;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы выбора типа подключения к БД
    /// </summary>
    public interface IDbConnectionView : IView
    {
        /// <summary>
        /// Выбранный тип подключения
        /// </summary>
        string SelectedConnectionType { get; }

        /// <summary>
        /// Событие подтверждения выбора
        /// </summary>
        event EventHandler ConfirmClicked;

        /// <summary>
        /// Событие отмены операции
        /// </summary>
        event EventHandler CancelClicked;

        /// <summary>
        /// Устанавливает результат диалога как успешный
        /// </summary>
        void SetDialogResultOk();

        /// <summary>
        /// Устанавливает результат диалога как отмену
        /// </summary>
        void SetDialogResultCancel();
    }
}
