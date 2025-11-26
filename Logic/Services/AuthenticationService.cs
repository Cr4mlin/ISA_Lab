using DataAccessLayer;
using Logic.Exceptions;
using Model;

namespace Logic.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationService(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public User? Login(string login, string password)
        {
            var user = _userRepository.FindByLogin(login);
            if (user == null)
            {
                throw new AuthenticationException("Неверный логин или пароль");
            }

            if (!_passwordHasher.VerifyPassword(password, user.Password))
            {
                throw new AuthenticationException("Неверный логин или пароль");
            }

            return user;
        }

        public User Register(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentException("Логин не может быть пустым");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Пароль не может быть пустым");
            }

            var existingUser = _userRepository.FindByLogin(login);
            if (existingUser != null)
            {
                throw new UserAlreadyExistsException("Пользователь с таким логином уже существует");
            }

            var hashedPassword = _passwordHasher.HashPassword(password);
            var newUser = new User
            {
                Login = login,
                Password = hashedPassword,
                Role = 2 // По умолчанию роль User
            };

            _userRepository.Add(newUser);
            return newUser;
        }
    }
}
