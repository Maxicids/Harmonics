using System.Windows;
using System.Windows.Input;
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

        private void Back_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var selectedChat = new Chats { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }
    }
}