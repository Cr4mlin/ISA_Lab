namespace Shared
{
    /// <summary>
    /// Интерфейс модели пользователя для MVP
    /// </summary>
    public interface IUserModel
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        string Login { get; set; }

        /// <summary>
        /// Роль пользователя
        /// </summary>
        int Role { get; set; }

        /// <summary>
        /// Никнейм пользователя
        /// </summary>
        string NickName { get; set; }
    }
}
