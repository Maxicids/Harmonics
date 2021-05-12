using System.Windows;
using System.Windows.Input;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class Participants
    {
        public Participants()
        {
            InitializeComponent();
        }
        private void SelectedUser_OnOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            (sender as ParticipantPreview)?.SelectUser();
            var selectedChat = new UserView { Height = ActualHeight};
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }
    }
}