using System.Security.Cryptography;
using System.Text;

namespace Logic.Services
{
    public class Md5PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes).ToLower();
            }
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            var hash = HashPassword(password);
            return hash.Equals(hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
