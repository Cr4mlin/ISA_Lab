using Dapper;
using Model;
using System.Data;

namespace DataAccessLayer
{
    public class DapperUserRepository : IUserRepository
    {
        private readonly IDbConnection _connection;

        public DapperUserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Add(User entity)
        {
            var sql = "INSERT INTO Users (login, password, role) VALUES (@Login, @Password, @Role)";
            _connection.Execute(sql, entity);
        }

        public void Delete(int id)
        {
            _connection.Execute("DELETE FROM Users WHERE id = @id", new { id });
        }

        public List<User> ReadAll()
        {
            return _connection.Query<User>("SELECT * FROM Users").ToList();
        }

        public User ReadById(int id)
        {
            return _connection.QuerySingleOrDefault<User>("SELECT * FROM Users WHERE id = @id", new { id });
        }

        public void Update(User entity)
        {
            var sql = @"UPDATE Users
                       SET login=@Login, password=@Password, role=@Role
                       WHERE id=@Id";
            _connection.Execute(sql, entity);
        }

        public User? FindByLogin(string login)
        {
            return _connection.QuerySingleOrDefault<User>("SELECT * FROM Users WHERE login = @login", new { login });
        }

        public string GetRoleName(int roleId)
        {
            return _connection.QuerySingleOrDefault<string>(
                "SELECT role FROM users_roles WHERE role_id = @roleId",
                new { roleId }) ?? "Unknown";
        }
    }
}
