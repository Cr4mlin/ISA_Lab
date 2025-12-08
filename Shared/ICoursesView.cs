using System;
using System.Collections.Generic;
using Shared.DTO;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы управления курсами
    /// </summary>
    public interface ICoursesView
    {
        /// <summary>
        /// Событие добавления курса
        /// </summary>
        event EventHandler AddRequested;

        /// <summary>
        /// Событие редактирования курса
        /// </summary>
        event EventHandler EditRequested;

        /// <summary>
        /// Событие удаления курса
        /// </summary>
        event EventHandler DeleteRequested;

        /// <summary>
        /// Событие изменения статуса курса
        /// </summary>
        event EventHandler ChangeStatusRequested;

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
        /// Запрашивает данные нового курса
        /// </summary>
        CourseDto? RequestNewCourseData();

        /// <summary>
        /// Запрашивает обновление данных курса
        /// </summary>
        CourseDto? RequestCourseUpdate(CourseDto course);

        /// <summary>
        /// Запрашивает подтверждение удаления
        /// </summary>
        bool ConfirmDelete(string courseName);
    }
}
