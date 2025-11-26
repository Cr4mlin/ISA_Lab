using Logic.Services;
using Logic.Exceptions;
using Model;

namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        public User? AuthenticatedUser { get; private set; }

        public LoginForm(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text.Trim();
                var password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AuthenticatedUser = _authenticationService.Login(login, password);

                if (AuthenticatedUser != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка входа",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text.Trim();
                var password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 4)
                {
                    MessageBox.Show("Пароль должен содержать минимум 4 символа", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newUser = _authenticationService.Register(login, password);

                MessageBox.Show($"Регистрация успешна! Вы зарегистрированы как пользователь (User).\nТеперь можете войти в систему.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPassword.Clear();
                txtLogin.Focus();
            }
            catch (UserAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show($"Ошибка базы данных при регистрации: {ex.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
