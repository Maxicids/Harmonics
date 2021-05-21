using System.Collections.ObjectModel;
using System.Threading;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.ViewModels
{
    public class UserViewModel : ViewModel
    {
        private static bool isElementVisible;
        
        private ObservableCollection<User> usersCollection;

        public ObservableCollection<User> Users
        {
            get => usersCollection;
            set
            {
                usersCollection = value;
                OnPropertyChanged($"Users");
            }
        }
        private void DoUpdate()
        {
            do
            {
                using var db = new UnitOfWork();
                usersCollection = new ObservableCollection<User>(db.Users.GetAll());
                OnPropertyChanged($"Users");
                Thread.Sleep(4000);
            } while (isElementVisible);
        }
        public static void StopUpdating()
        {
            isElementVisible = false;
        }
        public UserViewModel()
        {
            usersCollection = new ObservableCollection<User>(unitOfWork.Users.GetAll());
            var ctThread = new Thread(DoUpdate);
            isElementVisible = true;
            ctThread.Start();
        }
    }
}