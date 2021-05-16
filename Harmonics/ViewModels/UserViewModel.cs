using System.Collections.ObjectModel;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class UserViewModel : ViewModel
    {
        private ObservableCollection<User> usersCollection;

        public ObservableCollection<User> Users
        {
            get => usersCollection;
            set
            {
                usersCollection = value;
                OnPropertyChanged($"collection");
            }
        }
        public UserViewModel()
        {
            usersCollection = new ObservableCollection<User>(unitOfWork.Users.GetAll());
        }
    }
}