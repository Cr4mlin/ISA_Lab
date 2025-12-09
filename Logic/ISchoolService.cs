using Logic.Services;
using Model;

namespace Logic
{
    /// <summary>
    /// Интерфейс для сервиса управления курсами
    /// </summary>
    public interface ISchoolService
    {
        /// <summary>
        /// Создаёт новый курс с заданными параметрами
        /// </summary>
        /// <param name="courseName">Название курса</param>
        /// <param name="description">Описание курса</param>
        /// <param name="duration">Длительность курса в часах</param>
        /// <param name="price">Стоимость курса</param>
        /// <param name="teacherName">Имя преподавателя</param>
        /// <param name="status">Состояние курса (да/нет)</param>
        /// <returns>Созданный курс</returns>
        /// <exception cref="InvalidPriceException">Выбрасывается при отрицательном значении цены</exception>
        /// <exception cref="InvalidDurationException">Выбрасывается при отрицательном значении продолжительности</exception>
        /// <exception cref="InvalidTeacherNameException">Выбрасывается при невалидном имени преподавателя</exception>
        /// <exception cref="InvalidIsActiveException">Выбрасывается при неверном указании состояния</exception>
        Course CreateCourse(string courseName, string description, int duration, decimal price, string teacherName, string status);

        /// <summary>
        /// Обновляет существующий курс с заданными параметрами
        /// </summary>
        /// <param name="courseId">ID курса для обновления</param>
        /// <param name="courseName">Название курса</param>
        /// <param name="description">Описание курса</param>
        /// <param name="duration">Длительность курса в часах</param>
        /// <param name="price">Стоимость курса</param>
        /// <param name="teacherName">Имя преподавателя</param>
        /// <param name="status">Состояние курса (да/нет)</param>
        /// <returns>Обновленный курс</returns>
        /// <exception cref="InvalidPriceException">Выбрасывается при отрицательном значении цены</exception>
        /// <exception cref="InvalidDurationException">Выбрасывается при отрицательном значении продолжительности</exception>
        /// <exception cref="InvalidTeacherNameException">Выбрасывается при невалидном имени преподавателя</exception>
        /// <exception cref="InvalidIsActiveException">Выбрасывается при неверном указании состояния</exception>
        Course UpdateCourse(int courseId, string courseName, string description, int duration, decimal price, string teacherName, string status);

        /// <summary>
        /// Выполняет поиск курсов по заданному тексту и свойствам
        /// </summary>
        /// <param name="searchText">Текст для поиска</param>
        /// <param name="searchProperties">Список свойств для поиска</param>
        /// <returns>Список найденных курсов</returns>
        /// <exception cref="ArgumentException">Выбрасывается если поле поиска пустое или не выбрано ни одного свойства</exception>
        List<Course> SearchCourses(string searchText, List<string> searchProperties);

        /// <summary>
        /// Удаляет курс по указанному идентификатору
        /// </summary>
        /// <param name="courseId">Идентификатор курса для удаления</param>
        /// <returns>true если курс успешно удален, иначе false</returns>
        bool DeleteCourse(int courseId);

        /// <summary>
        /// Возвращает список всех курсов
        /// </summary>
        /// <returns>Список всех курсов</returns>
        List<Course> GetAllCourses();

        /// <summary>
        /// Находит курс по указанному идентификатору
        /// </summary>
        /// <param name="id">Идентификатор курса</param>
        /// <returns>Найденный курс или null, если не найден</returns>
        Course GetCourseById(int id);

        /// <summary>
        /// Возвращает список активных курсов
        /// </summary>
        /// <returns>Список активных курсов</returns>
        List<Course> GetActiveCourses();

        /// <summary>
        /// Возвращает список курсов в указанном ценовом диапазоне
        /// </summary>
        /// <param name="minPrice">Минимальная цена</param>
        /// <param name="maxPrice">Максимальная цена</param>
        /// <returns>Список курсов в заданном ценовом диапазоне</returns>
        /// <exception cref="InvalidPriceRangeException">Выбрасывается при неверном ценовом диапазоне</exception>
        List<Course> GetCoursesInPriceRange(decimal minPrice, decimal maxPrice);

        /// <summary>
        /// Переключает статус активности курса (активный/неактивный)
        /// </summary>
        /// <param name="courseId">Идентификатор курса</param>
        void ToggleCourseStatus(int courseId);

        void ExportCourses(List<object> courses, string filePath, ExportFormat format);

        // Authentication methods
        /// <summary>
        /// Выполняет аутентификацию пользователя
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>Пользователь или null, если аутентификация не удалась</returns>
        User? Login(string login, string password);

        /// <summary>
        /// Регистрирует нового пользователя
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>Зарегистрированный пользователь</returns>
        User Register(string login, string password, string nickName);

        // User management methods
        /// <summary>
        /// Возвращает список всех пользователей
        /// </summary>
        /// <returns>Список всех пользователей</returns>
        List<User> GetAllUsers();

        /// <summary>
        /// Изменяет роль пользователя
        /// </summary>
        /// <param name="userId">ID пользователя</param>
        /// <param name="newRoleId">ID новой роли</param>
        /// <param name="currentUserId">ID текущего пользователя</param>
        void ChangeUserRole(int userId, int newRoleId, int currentUserId);

        /// <summary>
        /// Удаляет пользователя по ID
        /// </summary>
        /// <param name="userId">ID пользователя для удаления</param>
        /// <param name="currentUserId">ID текущего пользователя (администратора)</param>
        /// <returns>true если пользователь успешно удален, иначе false</returns>
        bool DeleteUser(int userId, int currentUserId);

        /// <summary>
        /// Получает пользователя по ID
        /// </summary>
        /// <param name="id">ID пользователя</param>
        /// <returns>Пользователь или null</returns>
        User? GetUserById(int id);

        /// <summary>
        /// Выполняет поиск пользователей по заданному тексту и свойствам
        /// </summary>
        /// <param name="searchText">Текст для поиска</param>
        /// <param name="searchProperties">Список свойств для поиска</param>
        /// <returns>Список найденных пользователей</returns>
        /// <exception cref="ArgumentException">Выбрасывается если поле поиска пустое или не выбрано ни одного свойства</exception>
        List<User> SearchUsers(string searchText, List<string> searchProperties);

        // User course methods
        /// <summary>
        /// Покупка курса пользователем
        /// </summary>
        /// <param name="userId">ID пользователя</param>
        /// <param name="courseId">ID курса</param>
        void PurchaseCourse(int userId, int courseId);

        /// <summary>
        /// Получает список купленных курсов пользователя
        /// </summary>
        /// <param name="userId">ID пользователя</param>
        /// <returns>Список купленных курсов</returns>
        List<Course> GetPurchasedCourses(int userId);

        /// <summary>
        /// Проверяет, купил ли пользователь курс
        /// </summary>
        /// <param name="userId">ID пользователя</param>
        /// <param name="courseId">ID курса</param>
        /// <returns>true если курс куплен, иначе false</returns>
        bool HasPurchasedCourse(int userId, int courseId);

        // Avatar methods
        /// <summary>
        /// Сохраняет аватар пользователя
        /// </summary>
        /// <param name="userid">ID пользователя</param>
        /// <param name="image">Изображение аватара</param>
        void SaveAvatar(int userid, System.Drawing.Image image);

        /// <summary>
        /// Загружает аватар пользователя
        /// </summary>
        /// <param name="userid">ID пользователя</param>
        /// <returns>Изображение аватара</returns>
        System.Drawing.Image LoadAvatar(int userid);

        /// <summary>
        /// Получает путь к аватару пользователя
        /// </summary>
        /// <param name="userid">ID пользователя</param>
        /// <returns>Путь к файлу аватара</returns>
        string GetAvatarPath(int userid);
    }
}

