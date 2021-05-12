using System;
using System.Collections.ObjectModel;
using System.Windows;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class SelectedUserViewModel : ViewModel
    {
        private ObservableCollection<User> selectedUser;
        
        public ObservableCollection<User> User
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                OnPropertyChanged($"collection");
            }
        }

        public SelectedUserViewModel()
        {
            selectedUser =
                new ObservableCollection<User>
                {
                    unitOfWork.Users.Get(Convert.ToInt32(Application.Current.Properties["SelectedUserId"]))
                };
        }
    }
}