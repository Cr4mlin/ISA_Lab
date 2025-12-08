using System;
using System.Collections.Generic;
using Shared.DTO;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы администратора
    /// </summary>
    public interface IAdminView : IView
    {
        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        event EventHandler FormLoaded;

        /// <summary>
        /// Событие запроса на добавление курса
        /// </summary>
        event EventHandler AddCourseRequested;

        /// <summary>
        /// Событие запроса на редактирование курса
        /// </summary>
        event EventHandler<int> EditCourseRequested;

        /// <summary>
        /// Событие запроса на удаление курса
        /// </summary>
        event EventHandler<int> DeleteCourseRequested;

        /// <summary>
        /// Событие изменения статуса курса
        /// </summary>
        event EventHandler<int> ToggleCourseStatusRequested;

        /// <summary>
        /// Событие поиска курсов
        /// </summary>
        event EventHandler<string> SearchCoursesRequested;

        /// <summary>
        /// Событие запроса на управление пользователями
        /// </summary>
        event EventHandler ManageUsersRequested;

        /// <summary>
        /// Событие удаления пользователя
        /// </summary>
        event EventHandler<int> DeleteUserRequested;

        /// <summary>
        /// Событие изменения роли пользователя
        /// </summary>
        event EventHandler<(int userId, int newRoleId)> ChangeUserRoleRequested;

        /// <summary>
        /// Событие поиска пользователей
        /// </summary>
        event EventHandler<string> SearchUsersRequested;

        /// <summary>
        /// Событие запроса на экспорт данных
        /// </summary>
        event EventHandler ExportRequested;

        /// <summary>
        /// Событие запроса на загрузку аватара
        /// </summary>
        event EventHandler LoadAvatarRequested;

        /// <summary>
        /// Событие запроса на изменение аватара
        /// </summary>
        event EventHandler<string> ChangeAvatarRequested;

        /// <summary>
        /// Событие запроса на удаление аватара
        /// </summary>
        event EventHandler DeleteAvatarRequested;

        /// <summary>
        /// Отображает список курсов
        /// </summary>
        void DisplayCourses(IEnumerable<CourseDto> courses);

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
        void UpdateUserInfo(string userName);

        /// <summary>
        /// Запрашивает формат экспорта у пользователя
        /// </summary>
        /// <returns>true для PDF, false для Excel, null если отменено</returns>
        bool? RequestExportFormat();

        /// <summary>
        /// Запрашивает путь для сохранения файла экспорта
        /// </summary>
        /// <param name="defaultFileName">Имя файла по умолчанию</param>
        /// <param name="isPdf">true для PDF, false для Excel</param>
        /// <returns>Путь к файлу или null если отменено</returns>
        string? RequestExportFilePath(string defaultFileName, bool isPdf);

        /// <summary>
        /// Отображает сообщение об успешном экспорте
        /// </summary>
        /// <param name="filePath">Путь к сохраненному файлу</param>
        void ShowExportSuccess(string filePath);

        /// <summary>
        /// Запрашивает данные нового курса у пользователя
        /// </summary>
        /// <returns>DTO нового курса или null если отменено</returns>
        CourseDto? RequestNewCourseData();

        /// <summary>
        /// Запрашивает обновленные данные курса у пользователя
        /// </summary>
        /// <param name="course">Текущие данные курса</param>
        /// <returns>Обновленный DTO курса или null если отменено</returns>
        CourseDto? RequestCourseUpdate(CourseDto course);

        /// <summary>
        /// Отображает список пользователей
        /// </summary>
        void DisplayUsers(IEnumerable<UserDto> users);

        /// <summary>
        /// Запрашивает подтверждение удаления
        /// </summary>
        bool ConfirmDelete(string itemName);

        /// <summary>
        /// Получает выбранный курс из текущей формы курсов
        /// </summary>
        CourseDto? GetSelectedCourse();

        /// <summary>
        /// Получает выбранного пользователя из текущей формы пользователей
        /// </summary>
        UserDto? GetSelectedUser();

        /// <summary>
        /// Запрашивает новую роль для пользователя
        /// </summary>
        int? RequestNewRole(string userName, int currentRole);

        /// <summary>
        /// Устанавливает аватар пользователя в главной форме
        /// </summary>
        void SetUserAvatar(System.Drawing.Image? avatar);

        /// <summary>
        /// Запрашивает выбор файла изображения у пользователя
        /// </summary>
        /// <returns>Путь к выбранному файлу или null если отменено</returns>
        string? RequestImageFile();

        /// <summary>
        /// Запрашивает подтверждение удаления аватара
        /// </summary>
        bool ConfirmDeleteAvatar();
    }
}
