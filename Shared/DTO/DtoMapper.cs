using Model;
using System.Collections.Generic;
using System.Linq;

namespace Shared.DTO
{
    /// <summary>
    /// Маппер для преобразования между доменными моделями и DTO
    /// </summary>
    public static class DtoMapper
    {
        /// <summary>
        /// Преобразует User в UserDto
        /// </summary>
        public static UserDto ToDto(User user)
        {
            if (user == null) return null;

            return new UserDto
            {
                Id = user.Id,
                Login = user.Login,
                NickName = user.NickName,
                Role = user.Role
            };
        }

        /// <summary>
        /// Преобразует список User в список UserDto
        /// </summary>
        public static List<UserDto> ToDto(List<User> users)
        {
            return users?.Select(ToDto).ToList() ?? new List<UserDto>();
        }

        /// <summary>
        /// Преобразует Course в CourseDto
        /// </summary>
        public static CourseDto ToDto(Course course)
        {
            if (course == null) return null;

            return new CourseDto
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description,
                Duration = course.Duration,
                Price = course.Price,
                TeacherName = course.TeacherName,
                IsActive = course.IsActive
            };
        }

        /// <summary>
        /// Преобразует список Course в список CourseDto
        /// </summary>
        public static List<CourseDto> ToDto(List<Course> courses)
        {
            return courses?.Select(ToDto).ToList() ?? new List<CourseDto>();
        }

        /// <summary>
        /// Преобразует UserDto в User
        /// </summary>
        public static User ToEntity(UserDto dto)
        {
            if (dto == null) return null;

            return new User
            {
                Id = dto.Id,
                Login = dto.Login,
                NickName = dto.NickName,
                Role = dto.Role
            };
        }

        /// <summary>
        /// Преобразует CourseDto в Course
        /// </summary>
        public static Course ToEntity(CourseDto dto)
        {
            if (dto == null) return null;

            return new Course
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Duration = dto.Duration,
                Price = dto.Price,
                TeacherName = dto.TeacherName,
                IsActive = dto.IsActive
            };
        }
    }
}
