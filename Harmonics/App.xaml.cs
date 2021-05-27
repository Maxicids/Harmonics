using System.Threading;
using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;
using Harmonics.ViewModels;
using Harmonics.Views;

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

        protected override void OnExit(ExitEventArgs e)
        {
            
            if (Current.Properties["User"] != null)
            {
                ParticipantViewModel.StopUpdating();
                MessagesViewModel.StopUpdating();
                UserViewModel.StopUpdating();
                ReportViewModel.StopUpdating();
                BlockedUsersViewModel.StopUpdating();
                using var db = new UnitOfWork();
                var user = db.Users.GetByLogin(((User) Current.Properties["User"]).login);
                user.is_Online = false;
                db.Users.Update(user);
                db.Save();
                Thread.Sleep(500);
            }
            base.OnExit(e);
        }

        public static void IsBlocked()
        {
            using var db = new UnitOfWork();
            var user = db.Users.GetByLogin(((User) Current.Properties["User"]).login);
            if (!user.is_Blocked) return;
            MessageBox.Show("You has been blocked");
            (Current.Properties["MainWindow"] as MainWindow)?.LogOut();
        }

        public static void UnknownError()
        {
            MessageBox.Show("Unknown error, please try again later");
            (Current.Properties["MainWindow"] as MainWindow)?.LogOut();
        }
    }
}