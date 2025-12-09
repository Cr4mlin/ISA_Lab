using System;
using Shared;
using Logic;

namespace Presenter
{
    /// <summary>
    /// Presenter для формы выбора подключения к БД
    /// </summary>
    public class DbConnectionPresenter
    {
        private readonly IDbConnectionView _view;
        private readonly ISchoolService _schoolService;

        public DbConnectionPresenter(IDbConnectionView view, ISchoolService schoolService)
        {
            _view = view;
            _schoolService = schoolService;

            // Подписка на события View
            _view.ConfirmClicked += OnConfirmClicked;
        }

        private void OnConfirmClicked(object? sender, EventArgs e)
        {
            try
            {
                var connectionType = _view.SelectedConnectionType;

                if (string.IsNullOrEmpty(connectionType))
                {
                    return;
                }

                // Здесь можно изменить тип подключения в сервисе
                // Например, _schoolService.ChangeConnectionType(connectionType);

                _view.SetDialogResultOk();
                _view.Close();
            }
            catch (Exception ex)
            {
                // Обработка ошибок
            }
        }
    }
}
