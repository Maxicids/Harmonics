using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Harmonics.Models.UnitOfWork;
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

        public bool SelectChat()
        {
            var id = Convert.ToInt32(Id.Text);
            using (var db = new UnitOfWork())
            {
                if (db.Chats.Get(id) == null)
                {
                    return false;
                }
            }
            Application.Current.Properties["SelectedChatId"] = Id.Text;
            return true;
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("dfsf");
        }
    }
}