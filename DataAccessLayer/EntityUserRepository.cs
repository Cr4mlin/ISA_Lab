using Model;

namespace DataAccessLayer
{
    public class EntityUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public EntityUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<User> ReadAll()
        {
            return _context.Users.ToList();
        }

        public User ReadById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(User entity)
        {
            var existingUser = _context.Users.Find(entity.Id);
            if (existingUser != null)
            {
                existingUser.Login = entity.Login;
                existingUser.Password = entity.Password;
                existingUser.Role = entity.Role;
                _context.SaveChanges();
            }
        }

        public User? FindByLogin(string login)
        {
            return _context.Users.FirstOrDefault(u => u.Login == login);
        }

        public string GetRoleName(int roleId)
        {
            var role = _context.UsersRoles.FirstOrDefault(r => r.Id == roleId);
            return role?.Role ?? "Unknown";
        }
    }
}
