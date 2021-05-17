using System.Windows;
using Harmonics.Models.UnitOfWork;

namespace Harmonics
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using var db = new UnitOfWork();
            Current.Properties["UsersList"] = null;
            Current.Properties["BLockedList"] = null;
            Current.Properties["UserMessages"] = null;
            Current.Properties["User"] = null;
            Current.Properties["SelectedChatId"] = null;
            Current.Properties["SelectedUserId"] = null;
            
            Current.Properties["MainWindow"] = null;
        }
    }
}