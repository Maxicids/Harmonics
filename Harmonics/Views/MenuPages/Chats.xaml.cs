using System.Windows;
using System.Windows.Input;
using Harmonics.Models.Entities;
using Harmonics.ViewModels;
using Harmonics.Views.MenuPages.ChatTemplates;

namespace Harmonics.Views.MenuPages
{
    public partial class Chats : IResizeable
    {
        public Chats()
        {
            InitializeComponent();
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }
        private void Chat_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Application.Current.Properties["User"] is not User)
            {
                App.UnknownError();
                return;
            }
            App.IsBlocked();
            var result = (sender as ChatView)?.SelectChat();
            if (result == true)
            {
                var selectedChat = new SelectedChatView { Height = ActualHeight, Width = ActualWidth };
                (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
            }
            else
            {
                var chats = new Chats { Height = ActualHeight, Width = ActualWidth };
                (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(chats);
            }
        }

        private void AddNewChat_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Application.Current.Properties["User"] is not User)
            {
                App.UnknownError();
                return;
            }
            App.IsBlocked();
            (sender as ParticipantPreview)?.SelectUser();
            var createNewChat = new CreateNewChat { Height = ActualHeight};
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(createNewChat);
        }
    }
}