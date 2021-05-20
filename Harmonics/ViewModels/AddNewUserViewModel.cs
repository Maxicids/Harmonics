using Harmonics.Validation;

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