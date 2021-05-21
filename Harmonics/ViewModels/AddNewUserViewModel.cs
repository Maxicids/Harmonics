using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Validation;
using Harmonics.Views;

namespace Harmonics.ViewModels
{
    public class AddNewUserViewModel : ViewModel
    {
        private string login;
        private string info;
        private Harmonics.Command.Command addCommand;
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged($"Login");
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

        public Harmonics.Command.Command AddCommand => addCommand;

        private void DoAddCommand()
        {
            if (Application.Current.Properties["User"] is not User currentUser || currentUser.is_Blocked)
            {
                MessageBox.Show("You has been blocked");
                (Application.Current.Properties["MainWindow"] as MainWindow)?.LogOut();
            }
            var user = unitOfWork.Users.GetByLogin(Login);
            if (user == null)
            {
                Info = ErrorMessages.NoSuchUser;
                return;
            }

            var result = unitOfWork.Chats.AddUserToSelectedChat(user);
            switch (result)
            {
                case 1:
                    Info = ErrorMessages.AlreadyInChat;
                    return;
                case 0:
                    Info = "Successfully added";
                    unitOfWork.Save();
                    break;
            }
        }
        public AddNewUserViewModel()
        {
            addCommand = new Harmonics.Command.Command(DoAddCommand);
        }
    }
}