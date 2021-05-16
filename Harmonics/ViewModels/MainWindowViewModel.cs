using System.Windows;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private bool isControlPanelVisible;
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged($"Name");
            }
        }
        public bool IsControlPanelVisible
        {
            get => isControlPanelVisible;
            set
            {
                isControlPanelVisible = value;
                OnPropertyChanged($"IsControlPanelVisible");
            }
        }
        
        public MainWindowViewModel()
        {
            IsControlPanelVisible = Application.Current.Properties["User"] is User {role: 1};
            Name = (Application.Current.Properties["User"] as User)?.login;
        }
    }
}