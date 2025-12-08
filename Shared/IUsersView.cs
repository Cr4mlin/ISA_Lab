using System;
using System.Collections.Generic;
using Shared.DTO;

namespace Shared
{
    /// <summary>
    /// Интерфейс View для формы управления пользователями
    /// </summary>
    public interface IUsersView
    {
        /// <summary>
        /// Событие удаления пользователя
        /// </summary>
        event EventHandler DeleteRequested;

        /// <summary>
        /// Событие изменения роли пользователя
        /// </summary>
        event EventHandler ChangeRoleRequested;

        /// <summary>
        /// Событие поиска пользователей
        /// </summary>
        event EventHandler<string> SearchRequested;

        /// <summary>
        /// Отображает список пользователей
        /// </summary>
        void DisplayUsers(IEnumerable<UserDto> users);

        /// <summary>
        /// Получает выбранного пользователя
        /// </summary>
        UserDto? GetSelectedUser();

        /// <summary>
        /// Показывает сообщение об ошибке
        /// </summary>
        void ShowError(string message);

        /// <summary>
        /// Показывает информационное сообщение
        /// </summary>
        void ShowInfo(string message);

        /// <summary>
        /// Запрашивает подтверждение удаления
        /// </summary>
        bool ConfirmDelete(string userName);

        /// <summary>
        /// Запрашивает новую роль для пользователя
        /// </summary>
        int? RequestNewRole(string userName, int currentRole);
    }
}
