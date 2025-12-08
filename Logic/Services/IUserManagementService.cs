using Model;

namespace Logic.Services
{
    public interface IUserManagementService
    {
        List<User> GetAllUsers();
        void ChangeUserRole(int userId, int newRoleId, int currentUserId);
        bool DeleteUser(int userId, int currentUserId);
        User? GetUserById(int id);
    }
}
