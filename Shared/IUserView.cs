using System;
using System.Collections.Generic;
using System.Drawing;
using Shared.DTO;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы пользователя
    /// </summary>
    public interface IUserView : IView
    {
        /// <summary>
        /// Событие запроса на покупку курса
        /// </summary>
        event EventHandler<int> PurchaseCourseRequested;

        /// <summary>
        /// Событие запроса на просмотр купленных курсов
        /// </summary>
        event EventHandler ViewPurchasedCoursesRequested;

        /// <summary>
        /// Событие поиска курсов
        /// </summary>
        event EventHandler<string> SearchCoursesRequested;

        /// <summary>
        /// Событие просмотра всех курсов
        /// </summary>
        event EventHandler ViewAllCoursesRequested;

        /// <summary>
        /// Событие запроса на изменение аватара
        /// </summary>
        event EventHandler ChangeAvatarRequested;

        /// <summary>
        /// Событие удаления аватара
        /// </summary>
        event EventHandler DeleteAvatarRequested;

        /// <summary>
        /// Событие запроса на загрузку аватара
        /// </summary>
        event EventHandler LoadAvatarRequested;

        /// <summary>
        /// Событие предоставления изображения аватара
        /// </summary>
        event EventHandler<Image> AvatarImageProvided;

        /// <summary>
        /// Отображает список курсов
        /// </summary>
        void DisplayCourses(IEnumerable<CourseDto> courses);

        /// <summary>
        /// Отображает купленные курсы
        /// </summary>
        void DisplayPurchasedCourses(IEnumerable<CourseDto> purchasedCourses);

        /// <summary>
        /// Устанавливает аватар пользователя
        /// </summary>
        void SetUserAvatar(Image? avatar);

        /// <summary>
        /// Отображает сообщение об ошибке
        /// </summary>
        void ShowError(string message);

        /// <summary>
        /// Отображает информационное сообщение
        /// </summary>
        void ShowInfo(string message);

        /// <summary>
        /// Обновляет информацию о текущем пользователе
        /// </summary>
        void UpdateUserInfo(string userName, string nickName);

        /// <summary>
        /// Запрашивает выбор файла изображения
        /// </summary>
        string? RequestImageFile();

        /// <summary>
        /// Получает выбранный курс
        /// </summary>
        CourseDto? GetSelectedCourse();

        /// <summary>
        /// Запрашивает подтверждение покупки курса
        /// </summary>
        bool ConfirmPurchase(string courseName);

        /// <summary>
        /// Запрашивает подтверждение удаления аватара
        /// </summary>
        bool ConfirmDeleteAvatar();
    }
}
