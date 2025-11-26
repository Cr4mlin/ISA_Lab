using Logic;
using Logic.Services;
using Ninject;
using DataAccessLayer;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Шаг 1: Выбор типа подключения к БД
            string selectedConnection;
            using (var dbForm = new DbConnectionForm())
            {
                if (dbForm.ShowDialog() != DialogResult.OK)
                {
                    return; // Пользователь отменил выбор подключения
                }
                selectedConnection = dbForm.SelectedConnectionType;
            }

            // Создание IoC-контейнера с выбранным типом подключения
            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule(selectedConnection));

            // Шаг 2: Аутентификация пользователя
            var authService = ninjectKernel.Get<IAuthenticationService>();
            Model.User? authenticatedUser = null;

            using (var loginForm = new LoginForm(authService))
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return; // Пользователь отменил вход
                }
                authenticatedUser = loginForm.AuthenticatedUser;
            }

            if (authenticatedUser == null)
            {
                MessageBox.Show("Ошибка аутентификации", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Шаг 3: Открытие соответствующей формы в зависимости от роли
            if (authenticatedUser.Role == 1) // Admin
            {
                var schoolService = ninjectKernel.Get<ISchoolService>();
                var userManagementService = ninjectKernel.Get<IUserManagementService>();
                var userRepository = ninjectKernel.Get<IUserRepository>();
                Application.Run(new AdminForm(schoolService, userManagementService, userRepository, authenticatedUser));
            }
            else if (authenticatedUser.Role == 2) // User
            {
                var schoolService = ninjectKernel.Get<ISchoolService>();
                var userCourseService = ninjectKernel.Get<IUserCourseService>();
                Application.Run(new UserForm(schoolService, userCourseService, authenticatedUser));
            }
            else
            {
                MessageBox.Show("Неизвестная роль пользователя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}