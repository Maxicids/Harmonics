using System.Windows;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class UserView : IResizeable
    {
        public UserView()
        {
            InitializeComponent();
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }
        private void CLose_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedChat = new SelectedChatView { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }

        private void Report_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}