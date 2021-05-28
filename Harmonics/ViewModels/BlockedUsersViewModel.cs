using System;
using System.Collections.ObjectModel;
using System.Threading;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.ViewModels
{
    public class BlockedUsersViewModel : ViewModel
    {
        private static bool isElementVisible;
        
        private ObservableCollection<Blocked> blockedUsers;
        private readonly Harmonics.Command.Command forgiveCommand;

        public Harmonics.Command.Command ForgiveCommand => forgiveCommand;
        public ObservableCollection<Blocked> BlockedUsers
        {
            get => blockedUsers;
            set
            {
                blockedUsers = value;
                OnPropertyChanged($"BlockedUsers");
            }
        }

        private void DoForgiveCommand(object parameter)
        {
            var blocked = blockedUsers.Count.Equals(1) ? unitOfWork.Blocked.Get(Convert.ToInt32(parameter)) : unitOfWork.Blocked.Get(Convert.ToInt32(parameter) + 1);
            if (blocked == null)
            {
                return;
            }
            var user = unitOfWork.Users.Get(blocked.user_id);
            user.is_Blocked = false;
            unitOfWork.Users.Update(user);
            unitOfWork.Blocked.Delete(blocked.id);
            unitOfWork.Save();
        }

        private void DoUpdate()
        {
            do
            {
                using var db = new UnitOfWork();
                blockedUsers = new ObservableCollection<Blocked>(db.Blocked.GetAll());
                OnPropertyChanged($"BlockedUsers");
                Thread.Sleep(4000);
            } while (isElementVisible);
        }
        public static void StopUpdating()
        {
            isElementVisible = false;
        }
        public BlockedUsersViewModel()
        {
            blockedUsers = new ObservableCollection<Blocked>(unitOfWork.Blocked.GetAll());
            forgiveCommand = new Harmonics.Command.Command(DoForgiveCommand);
            var ctThread = new Thread(DoUpdate);
            isElementVisible = true;
            ctThread.Start();
        }
    }
}