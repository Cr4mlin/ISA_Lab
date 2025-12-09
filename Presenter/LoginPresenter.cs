using System;
using Shared;
using Logic;

namespace Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly ISchoolService _schoolService;

        public LoginPresenter(ILoginView view, ISchoolService schoolService)
        {
            _view = view;
            _schoolService = schoolService;
            _view.LoginClicked += OnLoginClicked;
            _view.RegisterClicked += OnRegisterClicked;
            _view.CancelClicked += OnCancelClicked;
        }

        private void OnLoginClicked(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.Login) || string.IsNullOrWhiteSpace(_view.Password))
                {
                    _view.ShowError("Заполните все поля");
                    return;
                }

                var user = _schoolService.Login(_view.Login, _view.Password);
                if (user != null)
                {
                    _view.SetDialogResultOk();
                    _view.Close();
                }
                else
                {
                    _view.ShowError("Неправильный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void OnRegisterClicked(object? sender, EventArgs e)
        {
            _view.SetDialogResultCancel();
            _view.Close();
        }

        private void OnCancelClicked(object? sender, EventArgs e)
        {
            // Закрытие формы через кнопку - выход из приложения
            _view.SetDialogResultAbort();
            _view.Close();
        }
    }
}
