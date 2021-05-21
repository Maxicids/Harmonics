using System.Windows;
using System.Windows.Data;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class Chat 
    {
        public Chat()
        {
            InitializeComponent();
            MessagesList.SelectedIndex = MessagesList.Items.Count - 1;
            MessagesList.ScrollIntoView(MessagesList.SelectedItem) ;
        }
    }
}