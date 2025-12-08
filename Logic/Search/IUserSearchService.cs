using Model;

namespace Logic.Search
{
    /// <summary>
    /// Интерфейс сервиса поиска пользователей
    /// </summary>
    public interface IUserSearchService
    {
        /// <summary>
        /// Выполняет поиск пользователей по заданному тексту и свойствам
        /// </summary>
        /// <param name="users">Список пользователей для поиска</param>
        /// <param name="searchText">Текст для поиска</param>
        /// <param name="searchProperties">Список свойств для поиска</param>
        /// <returns>Список найденных пользователей</returns>
        List<User> Search(List<User> users, string searchText, List<string> searchProperties);
    }
}
