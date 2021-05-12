using System.Collections.ObjectModel;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class UserViewModel : ViewModel
    {
        private ObservableCollection<User> chatsCollection;

        public ObservableCollection<User> Users
        {
            get => chatsCollection;
            set
            {
                chatsCollection = value;
                OnPropertyChanged($"collection");
            }
        }
        public UserViewModel()
        {
            chatsCollection = new ObservableCollection<User>(unitOfWork.Users.GetAll());
        }
    }
}