using DataAccessLayer;
using Logic.Exceptions;
using Model;

namespace Logic.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository _userRepository;

        public UserManagementService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.ReadAll();
        }

        public void ChangeUserRole(int userId, int newRoleId, int currentUserId)
        {
            if (userId == currentUserId)
            {
                throw new UnauthorizedRoleChangeException("Нельзя изменить роль самому себе");
            }

            if (newRoleId != 1 && newRoleId != 2)
            {
                throw new ArgumentException("Неверный ID роли. Допустимые значения: 1 (Admin) или 2 (User)");
            }

            var user = _userRepository.ReadById(userId);
            if (user == null)
            {
                throw new CourseNotFoundException($"Пользователь с ID {userId} не найден");
            }

            user.Role = newRoleId;
            _userRepository.Update(user);
        }

        public User? GetUserById(int id)
        {
            return _userRepository.ReadById(id);
        }
    }
}
