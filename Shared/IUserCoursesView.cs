using System;
using System.Collections.Generic;
using Shared.DTO;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы курсов пользователя
    /// </summary>
    public interface IUserCoursesView
    {
        /// <summary>
        /// Событие просмотра всех курсов
        /// </summary>
        event EventHandler ViewAllCoursesRequested;

        /// <summary>
        /// Событие просмотра купленных курсов
        /// </summary>
        event EventHandler ViewPurchasedCoursesRequested;

        /// <summary>
        /// Событие покупки курса
        /// </summary>
        event EventHandler PurchaseCourseRequested;

        /// <summary>
        /// Событие поиска курсов
        /// </summary>
        event EventHandler<string> SearchRequested;

        /// <summary>
        /// Отображает список курсов
        /// </summary>
        void DisplayCourses(IEnumerable<CourseDto> courses);

        /// <summary>
        /// Получает выбранный курс
        /// </summary>
        CourseDto? GetSelectedCourse();

        /// <summary>
        /// Показывает сообщение об ошибке
        /// </summary>
        void ShowError(string message);

        /// <summary>
        /// Показывает информационное сообщение
        /// </summary>
        void ShowInfo(string message);

        /// <summary>
        /// Запрашивает подтверждение покупки
        /// </summary>
        bool ConfirmPurchase(string courseName);
    }
}
