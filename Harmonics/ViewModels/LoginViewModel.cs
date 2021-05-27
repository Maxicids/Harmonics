using System.Text.RegularExpressions;
using System.Windows;
using Harmonics.Validation;

namespace Harmonics.ViewModels
{
    public class LoginViewModel : ViewModel
    {
       private const string LoginAndPasswordRegex = "^[a-zA-Z0-9_.-]*$";
        private string login;
        private string password;
        private string info;
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged($"Login");
            } 
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged($"Password");
            } 
        }
        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged($"Info");
            } 
        }
        public bool LoginUser()
        {
            var regex = new Regex(LoginAndPasswordRegex);
            if (!IsLoginValid())
            {
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                Info = ErrorMessages.PasswordIsEmpty;
                return false;
            }
            if (!regex.IsMatch(Login) || !regex.IsMatch((Password)))
            {
                Info = ErrorMessages.LoginAndPasswordStructure;
                return false;
            }
            if (Password.Length > 20)
            {
                Info = ErrorMessages.PasswordTooLong;
                return false;
            }
            var user = unitOfWork.Users.Login(Login, Password);
            if (user == null)
            {
                Info = ErrorMessages.WrongLoginOrPassword;
                return false;
            }

            if (user.is_Blocked)
            {
                Info = ErrorMessages.HasBeenBlocked;
                return false;
            }
            Info = "Success";
            Application.Current.Properties["User"] = user;
            user.is_Online = true;
            unitOfWork.Users.Update(user);
            unitOfWork.Save();
            return true;
        }

        private bool IsLoginValid()
        {
            if (string.IsNullOrEmpty(Login))
            {
                Info = ErrorMessages.LoginIsEmpty;
                return false;
            }
            if (login.Length <= 20) return true;
            Info = ErrorMessages.LoginTooLong;
            return false;
        }
        
    }
}