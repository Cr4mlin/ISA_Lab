using Model;

namespace DataAccessLayer
{
    public class EntityUserCourseRepository : IUserCourseRepository
    {
        private readonly ApplicationDbContext _context;

        public EntityUserCourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(int userId, int courseId)
        {
            var userCourse = new UserCourse
            {
                UserId = userId,
                CourseId = courseId
            };
            _context.UserCourses.Add(userCourse);
            _context.SaveChanges();
        }

        public List<int> GetCourseIdsByUserId(int userId)
        {
            return _context.UserCourses
                .Where(uc => uc.UserId == userId)
                .Select(uc => uc.CourseId)
                .ToList();
        }

        public bool Exists(int userId, int courseId)
        {
            return _context.UserCourses
                .Any(uc => uc.UserId == userId && uc.CourseId == courseId);
        }
    }
}
