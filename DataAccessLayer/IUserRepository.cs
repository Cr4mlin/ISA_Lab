using Model;

namespace DataAccessLayer
{
    public interface IUserRepository : IRepository<User>
    {
        User? FindByLogin(string login);
        string GetRoleName(int roleId);
    }
}
