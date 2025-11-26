using Dapper;
using System.Data;

namespace DataAccessLayer
{
    public class DapperUserCourseRepository : IUserCourseRepository
    {
        private readonly IDbConnection _connection;

        public DapperUserCourseRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Add(int userId, int courseId)
        {
            var sql = "INSERT INTO Users_Courses (user_id, course_id) VALUES (@userId, @courseId)";
            _connection.Execute(sql, new { userId, courseId });
        }

        public List<int> GetCourseIdsByUserId(int userId)
        {
            var sql = "SELECT course_id FROM Users_Courses WHERE user_id = @userId";
            return _connection.Query<int>(sql, new { userId }).ToList();
        }

        public bool Exists(int userId, int courseId)
        {
            var sql = "SELECT COUNT(1) FROM Users_Courses WHERE user_id = @userId AND course_id = @courseId";
            return _connection.ExecuteScalar<int>(sql, new { userId, courseId }) > 0;
        }
    }
}
