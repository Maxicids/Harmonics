using System.Linq;
using System.Windows;
using Harmonics.Models.UnitOfWork;

namespace Harmonics
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using (var db = new UnitOfWork())
            {
                Current.Properties["UsersList"] = db.Users.GetAll().ToList();//TODO: admin
                Current.Properties["ReportsList"] = db.Reports.GetAll().ToList();
                Current.Properties["BLockedList"] = db.Blocked.GetAll().ToList();
                Current.Properties["UserSettings"] = null;
                Current.Properties["UserMessages"] = null;
                Current.Properties["UserId"] = null;
                Current.Properties["SelectedChatId"] = null;
                Current.Properties["SelectedUserId"] = null;
                
                Current.Properties["MainWindow"] = null;
            }
        }
    }
}