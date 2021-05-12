using System.Collections.ObjectModel;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class RoleViewModel : ViewModel
    {
        private ObservableCollection<Role> selectedUser;
        
        public ObservableCollection<Role> Role
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                OnPropertyChanged($"Roles");
            }
        }

        public RoleViewModel()
        {
            selectedUser =
                new ObservableCollection<Role>
                {
                    unitOfWork.Roles.GetUserRole()
                };
        }
    }
}