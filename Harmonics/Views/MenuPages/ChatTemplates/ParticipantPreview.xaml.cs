using System.Diagnostics.Eventing.Reader;
using System.Windows;
using System.Windows.Input;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class ParticipantPreview
    {
        public ParticipantPreview()
        {
            InitializeComponent();
        }
        public void SelectUser()
        {
            Application.Current.Properties["SelectedUserId"] = Id.Text;
        }

        private void RemoveFromChat_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this user?", "Confirmation",MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            { 
                //TODO: Delete command
                //
                e.Handled = true;
            }
            else if (result == MessageBoxResult.No)
            { 
                e.Handled = true;
            }
        }
    }
}