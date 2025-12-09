using System;
using Shared;
using Logic;

namespace Presenter
{
    public class RegistrationPresenter
    {
        private readonly IRegistrationView _view;
        private readonly ISchoolService _schoolService;

        public RegistrationPresenter(IRegistrationView view, ISchoolService schoolService)
        {
            _view = view;
            _schoolService = schoolService;
            _view.RegistrationClicked += OnRegistrationClicked;
            _view.LoginClicked += OnLoginClicked;
            _view.CancelClicked += OnCancelClicked;
        }

        private void OnRegistrationClicked(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.NickName) || 
                    string.IsNullOrWhiteSpace(_view.Login) || 
                    string.IsNullOrWhiteSpace(_view.Password))
                {
                    _view.ShowError("Заполните все поля");
                    return;
                }

                var user = _schoolService.Register(_view.Login, _view.Password, _view.NickName);
                if (user != null)
                {
                    _view.ShowInfo("Регистрация успешна! Теперь вы можете войти.");
                    _view.SetDialogResultOk();
                    _view.Close();
                }
                else
                {
                    _view.ShowError("Ошибка регистрации");
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void OnLoginClicked(object? sender, EventArgs e)
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
