using System;
using System.Text.RegularExpressions;
using Harmonics.Models.Entities;
using Harmonics.Models.ServerProvider;
using Harmonics.Validation;

namespace Harmonics.ViewModels
{
    public class RegistrationViewModel : ViewModel
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
                OnPropertyChanged("Login");
            } 
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            } 
        }
        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged("Info");
            } 
        }
        public bool RegisterUser()
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
            Info = "Success";
            var user = new User
            {
                login = Login,
                password = PasswordHash.CreateHash(Password),
                role = 2,
                description = "",
                settings = 1,
                profile_Picture = null,
                is_Online = false,
                is_Blocked = false,
                created_At = DateTime.Now
            };
            unitOfWork.Users.Create(user);
            unitOfWork.Save();
            return true;
        }

        private bool IsLoginValid()
        {
            if (unitOfWork.Users.GetByLogin(Login) != null)
            {
                Info = ErrorMessages.AlreadyExists;
                return false;
            }
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