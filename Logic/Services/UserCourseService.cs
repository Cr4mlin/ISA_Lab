using DataAccessLayer;
using Logic.Exceptions;
using Model;

namespace Logic.Services
{
    public class UserCourseService : IUserCourseService
    {
        private readonly IUserCourseRepository _userCourseRepository;
        private readonly IRepository<Course> _courseRepository;

        public UserCourseService(IUserCourseRepository userCourseRepository, IRepository<Course> courseRepository)
        {
            _userCourseRepository = userCourseRepository;
            _courseRepository = courseRepository;
        }

        public void PurchaseCourse(int userId, int courseId)
        {
            var course = _courseRepository.ReadById(courseId);
            if (course == null)
            {
                throw new CourseNotFoundException($"Курс с ID {courseId} не найден");
            }

            if (_userCourseRepository.Exists(userId, courseId))
            {
                throw new CourseAlreadyPurchasedException("Вы уже купили этот курс");
            }

            _userCourseRepository.Add(userId, courseId);
        }

        public List<Course> GetPurchasedCourses(int userId)
        {
            var courseIds = _userCourseRepository.GetCourseIdsByUserId(userId);
            var courses = new List<Course>();

            foreach (var courseId in courseIds)
            {
                var course = _courseRepository.ReadById(courseId);
                if (course != null)
                {
                    courses.Add(course);
                }
            }

            return courses;
        }

        public bool HasPurchasedCourse(int userId, int courseId)
        {
            return _userCourseRepository.Exists(userId, courseId);
        }
    }
}
