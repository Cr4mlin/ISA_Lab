namespace Shared
{
    /// <summary>
    /// Базовый интерфейс для всех View в MVP архитектуре
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Отображает View
        /// </summary>
        void Show();

        /// <summary>
        /// Скрывает View
        /// </summary>
        void Hide();

        /// <summary>
        /// Закрывает View
        /// </summary>
        void Close();
    }
}
