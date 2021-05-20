using System.Windows;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class SelectedChatView : IResizeable
    {
        public SelectedChatView()
        {
            InitializeComponent();
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }

        private void Back_OnMouseDown(object sender, RoutedEventArgs e)
        {
            ParticipantViewModel.StopUpdating();
            MessagesViewModel.StopUpdating();
            var selectedChat = new Chats { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }

        private void AddParticipant_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedChat = new AddNewUser { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }
    }
}