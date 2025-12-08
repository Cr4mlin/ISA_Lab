using Model;

namespace Logic.Services
{
    public interface IAuthenticationService
    {
        User? Login(string login, string password);
        User Register(string login, string password, string nickName);
    }
}
