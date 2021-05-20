using System.Windows;
using System.Windows.Controls;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class AddNewUser : IResizeable
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedChat = new SelectedChatView { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }
    }
}