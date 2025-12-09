using System;
using System.Collections.Generic;
using System.Drawing;
using Shared;
using Shared.DTO;
using Logic;

namespace Presenter
{
    public class UserPresenter
    {
        private readonly IUserView _view;
        private readonly ISchoolService _schoolService;
        private int _currentUserId;

        public UserPresenter(IUserView view, ISchoolService schoolService)
        {
            _view = view;
            _schoolService = schoolService;

            _view.PurchaseCourseRequested += OnPurchaseCourseRequested;
            _view.ViewPurchasedCoursesRequested += OnViewPurchasedCoursesRequested;
            _view.ViewAllCoursesRequested += OnViewAllCoursesRequested;
            _view.SearchCoursesRequested += OnSearchCoursesRequested;
            _view.ChangeAvatarRequested += OnChangeAvatarRequested;
            _view.LoadAvatarRequested += OnLoadAvatarRequested;
        }

        public void SetUser(int userId)
        {
            _currentUserId = userId;
            try
            {
                var user = _schoolService.GetUserById(userId);
                if (user != null)
                    _view.UpdateUserInfo(user.Login, user.NickName);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void OnViewAllCoursesRequested(object? sender, EventArgs e)
        {
            try
            {
                var courses = _schoolService.GetAllCourses();
                var courseDtos = DtoMapper.ToDto(courses);
                _view.DisplayCourses(courseDtos);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка при загрузке курсов: {ex.Message}");
            }
        }

        private void OnSearchCoursesRequested(object? sender, string searchText)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    OnViewAllCoursesRequested(null, EventArgs.Empty);
                    return;
                }

                var searchProperties = new List<string> { "Name", "Description", "TeacherName" };
                var filteredCourses = _schoolService.SearchCourses(searchText, searchProperties);
                var courseDtos = DtoMapper.ToDto(filteredCourses);
                _view.DisplayCourses(courseDtos);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка при поиске курсов: {ex.Message}");
            }
        }

        private void OnPurchaseCourseRequested(object? sender, int courseId)
        {
            try
            {
                var course = _schoolService.GetCourseById(courseId);
                if (course == null)
                {
                    _view.ShowError("Курс не найден");
                    return;
                }

                if (!_view.ConfirmPurchase(course.Name))
                    return;

                _schoolService.PurchaseCourse(_currentUserId, courseId);
                _view.ShowInfo("Курс успешно куплен!");
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка при покупке курса: {ex.Message}");
            }
        }

        private void OnViewPurchasedCoursesRequested(object? sender, EventArgs e)
        {
            try
            {
                var courses = _schoolService.GetPurchasedCourses(_currentUserId);
                var courseDtos = DtoMapper.ToDto(courses);
                _view.DisplayPurchasedCourses(courseDtos);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void OnChangeAvatarRequested(object? sender, EventArgs e)
        {
            try
            {
                var imagePath = _view.RequestImageFile();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Загружаем изображение и создаем копию, чтобы освободить файл
                    Image image;
                    using (var originalImage = Image.FromFile(imagePath))
                    {
                        image = new Bitmap(originalImage);
                    }

                    _schoolService.SaveAvatar(_currentUserId, image);
                    _view.SetUserAvatar(image);
                    _view.ShowInfo("Аватар успешно изменен!");
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка при изменении аватара: {ex.Message}");
            }
        }

        private void OnLoadAvatarRequested(object? sender, EventArgs e)
        {
            try
            {
                var avatar = _schoolService.LoadAvatar(_currentUserId);
                if (avatar != null)
                {
                    _view.SetUserAvatar(avatar);
                }
                else
                {
                    _view.SetUserAvatar(Properties.Resources.DefaultAvatar);
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка при загрузке аватара: {ex.Message}");
            }
        }
    }
}
