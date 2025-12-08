using Model;
using System.Reflection;

namespace Logic.Search
{
    /// <summary>
    /// Реализация сервиса поиска пользователей
    /// </summary>
    public class UserSearchService : IUserSearchService
    {
        private readonly Dictionary<string, string> _fieldNameMap;

        /// <summary>
        /// Инициализирует новый экземпляр сервиса поиска пользователей
        /// </summary>
        public UserSearchService()
        {
            _fieldNameMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Login", "Login" },
                { "NickName", "NickName" },
                { "Идентификатор", "Id" }
            };
        }

        /// <summary>
        /// Выполняет поиск пользователей по заданному тексту и свойствам
        /// </summary>
        /// <param name="users">Список пользователей для поиска</param>
        /// <param name="searchText">Текст для поиска</param>
        /// <param name="searchProperties">Список свойств для поиска</param>
        /// <returns>Список найденных пользователей</returns>
        /// <exception cref="ArgumentException">Выбрасывается если поле поиска пустое или не выбрано ни одного свойства</exception>
        public List<User> Search(List<User> users, string searchText, List<string> searchProperties)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("Поле для поиска не может быть пустым.");
            }

            if (searchProperties == null || !searchProperties.Any())
            {
                throw new ArgumentException("Не выбрано ни одно свойство для поиска");
            }

            searchText = searchText.Trim();
            var userType = typeof(User);

            List<User> filteredUsers = users.Where(user =>
            {
                foreach (string searchProperty in searchProperties)
                {
                    if (!_fieldNameMap.TryGetValue(searchProperty, out string? actualProperty))
                        continue;

                    var property = userType.GetProperty(actualProperty);
                    if (property == null)
                        continue;

                    var value = property.GetValue(user)?.ToString();

                    if (value != null && value.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return true;
                    }
                }
                return false;
            }).ToList();

            return filteredUsers;
        }
    }
}
