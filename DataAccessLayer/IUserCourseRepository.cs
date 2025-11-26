using Model;

namespace DataAccessLayer
{
    public interface IUserCourseRepository
    {
        void Add(int userId, int courseId);
        List<int> GetCourseIdsByUserId(int userId);
        bool Exists(int userId, int courseId);
    }
}
