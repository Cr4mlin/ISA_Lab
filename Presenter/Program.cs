using System;
using System.Windows.Forms;
using Ninject;
using Logic;
using Shared;
using WinFormsApps;

namespace Presenter
{
    internal static class Program
    {
        private static IKernel? _kernel;
        private static int _currentUserId;
        private static string _currentUserRole = string.Empty;
        private static Form? _currentMainForm;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Загружаем тип подключения из настроек
            string connectionType = LoadConnectionType();

            // Создание IoC-контейнера с выбранным типом подключения
            _kernel = new StandardKernel(new SimpleConfigModule(connectionType));

            ShowAuthenticationFlow();
        }

        public static void ReloadKernel()
        {
            // Закрываем текущую главную форму
            if (_currentMainForm != null && !_currentMainForm.IsDisposed)
            {
                _currentMainForm.Close();
            }

            // Освобождаем старый kernel
            _kernel?.Dispose();

            // Загружаем новый тип подключения
            string connectionType = LoadConnectionType();

            // Создаем новый kernel
            _kernel = new StandardKernel(new SimpleConfigModule(connectionType));

            // Перезапускаем главную форму
            ShowMainForm();
        }

        private static string LoadConnectionType()
        {
            try
            {
                string settingsFile = "appsettings.txt";
                if (System.IO.File.Exists(settingsFile))
                {
                    return System.IO.File.ReadAllText(settingsFile).Trim();
                }
            }
            catch
            {
                // Игнорируем ошибки чтения
            }

            // По умолчанию EntityFramework
            return "EntityFramework";
        }

        private static void ShowAuthenticationFlow()
        {
            bool authenticated = false;
            
            while (!authenticated)
            {
                var result = ShowLoginForm();
                
                if (result == DialogResult.OK)
                {
                    // Успешная аутентификация
                    authenticated = true;
                    ShowMainForm();
                }
                else if (result == DialogResult.Cancel)
                {
                    // Переход на регистрацию
                    var regResult = ShowRegistrationForm();
                    
                    if (regResult == DialogResult.Cancel)
                    {
                        // Возврат на логин (продолжаем цикл)
                        continue;
                    }
                    else if (regResult == DialogResult.OK)
                    {
                        // После успешной регистрации возвращаемся на логин
                        continue;
                    }
                    else
                    {
                        // Закрыли форму регистрации - выходим
                        break;
                    }
                }
                else
                {
                    // Закрыли форму логина - выходим из приложения
                    break;
                }
            }
        }

        private static DialogResult ShowLoginForm()
        {
            var loginView = new LoginForm();
            var schoolService = _kernel!.Get<ISchoolService>();
            var loginPresenter = new LoginPresenter(loginView, schoolService);

            var result = loginView.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                var user = schoolService.Login(loginView.Login, loginView.Password);
                if (user != null)
                {
                    _currentUserId = user.Id;
                    _currentUserRole = user.Role == 1 ? "Owner" : "User";
                    return DialogResult.OK;
                }
            }
            
            return result;
        }

        private static DialogResult ShowRegistrationForm()
        {
            var registrationView = new RegistrationForm();
            var schoolService = _kernel!.Get<ISchoolService>();
            var registrationPresenter = new RegistrationPresenter(registrationView, schoolService);

            return registrationView.ShowDialog();
        }

        private static void ShowMainForm()
        {
            var schoolService = _kernel!.Get<ISchoolService>();

            if (_currentUserRole == "Owner")
            {
                var adminView = new OwnerMainForm();
                var adminPresenter = new AdminPresenter(adminView, schoolService);
                adminPresenter.SetUser(_currentUserId);
                adminView.SetCurrentUser(_currentUserId, GetUserNickName(_currentUserId));
                _currentMainForm = adminView;
                Application.Run(adminView);
            }
            else
            {
                var userView = new UserMainForm();
                var userPresenter = new UserPresenter(userView, schoolService);
                userPresenter.SetUser(_currentUserId);
                userView.SetCurrentUser(_currentUserId, GetUserNickName(_currentUserId));
                _currentMainForm = userView;
                Application.Run(userView);
            }
        }

        private static string GetUserNickName(int userId)
        {
            var schoolService = _kernel!.Get<ISchoolService>();
            var user = schoolService.GetUserById(userId);
            return user?.NickName ?? "Пользователь";
        }
    }
}
