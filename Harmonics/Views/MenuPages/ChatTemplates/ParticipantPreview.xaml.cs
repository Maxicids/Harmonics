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
    }
}