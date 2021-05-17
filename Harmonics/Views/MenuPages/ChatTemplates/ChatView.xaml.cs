using System.Windows;
using System.Windows.Controls;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class ChatView
    {
        public ChatView()
        {
            InitializeComponent();
        }
        public void ChangeSize(double width)
        {
            Width = width;
        }

        private void MainGrid_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            TextPanel.Width = MainGrid.ActualWidth - PhotoBorder.ActualWidth;
        }

        public void SelectChat()
        {
            Application.Current.Properties["SelectedChatId"] = Id.Text;
        }
    }
}