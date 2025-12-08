using System;

namespace Shared
{
    public interface IRegistrationView : IView
    {
        string NickName { get; }
        string Login { get; }
        string Password { get; }

        event EventHandler RegistrationClicked;
        event EventHandler LoginClicked;
        event EventHandler CancelClicked;

        void ShowError(string message);
        void ShowInfo(string message);
        void ClearFields();
        void SetDialogResultOk();
        void SetDialogResultCancel();
        void SetDialogResultAbort();
    }
}
