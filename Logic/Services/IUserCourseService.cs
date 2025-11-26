using Model;

namespace Logic.Services
{
    public interface IUserCourseService
    {
        void PurchaseCourse(int userId, int courseId);
        List<Course> GetPurchasedCourses(int userId);
        bool HasPurchasedCourse(int userId, int courseId);
    }
}
