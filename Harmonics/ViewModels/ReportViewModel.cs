using System;
using System.Collections.ObjectModel;
using System.Threading;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.ViewModels
{
    public class ReportViewModel : ViewModel
    {
        private static bool isElementVisible;
        
        private ObservableCollection<Report> reportsCollection;
        private readonly Harmonics.Command.Command approveCommand;

        public Harmonics.Command.Command ApproveCommand => approveCommand;
        public ObservableCollection<Report> Reports
        {
            get => reportsCollection;
            set
            {
                reportsCollection = value;
                OnPropertyChanged($"collection");
            }
        }

        private void DoApproveCommand(object parameter)
        {
            var report = reportsCollection.Count.Equals(1) ? unitOfWork.Reports.Get(Convert.ToInt32(parameter)) : unitOfWork.Reports.Get(Convert.ToInt32(parameter) + 1);
            
            if (report == null)
            {
                return;
            }
            unitOfWork.Blocked.Create(new Blocked
            {
                user_id = report.complainee,
                blocked_at = DateTime.Now,
                reason = report.reason
            });
            var user = unitOfWork.Users.Get(report.complainee);
            user.is_Blocked = true;
            unitOfWork.Users.Update(user);
            unitOfWork.Reports.Delete(report.id);
            unitOfWork.Save();
        }

        private void DoUpdate()
        {
            do
            {
                using var db = new UnitOfWork();
                reportsCollection = new ObservableCollection<Report>(db.Reports.GetAll());
                OnPropertyChanged($"Reports");
                Thread.Sleep(4000);
            } while (isElementVisible);
        }
        public static void StopUpdating()
        {
            isElementVisible = false;
        }
        public ReportViewModel()
        {
            reportsCollection = new ObservableCollection<Report>(unitOfWork.Reports.GetAll());
            approveCommand = new Harmonics.Command.Command(DoApproveCommand);
            var ctThread = new Thread(DoUpdate);
            isElementVisible = true;
            ctThread.Start();
        }
    }
}