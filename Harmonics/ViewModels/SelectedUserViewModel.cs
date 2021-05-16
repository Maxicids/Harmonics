using System;
using System.Collections.ObjectModel;
using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Views;
using Harmonics.Views.MenuPages.ChatTemplates;

namespace Harmonics.ViewModels
{
    public class SelectedUserViewModel : ViewModel
    {
        private double actualWidth;
        private double actualHeight;
        private bool showReportContent;
        private string reportContent;
        private ObservableCollection<User> selectedUser;
        private readonly Harmonics.Command.Command closeCommand;
        private readonly Harmonics.Command.Command reportCommand;
        private readonly Harmonics.Command.Command showReportContentCommand;
        public bool ShowReportContent
        {
            get => showReportContent;
            set
            {
                showReportContent = value;
                OnPropertyChanged($"ShowReportContent");
            }
        }

        public string ReportContent
        {
            get => reportContent;
            set
            {
                reportContent = value;
                OnPropertyChanged($"ReportContent");
            }
        }
        public double ActualWidth
        {
            get => actualWidth;
            set
            {
                actualWidth = value;
                OnPropertyChanged($"ActualWidth");
            }
        }

        public double ActualHeight
        {
            get => actualHeight;
            set
            {
                actualHeight = value;
                OnPropertyChanged($"ActualHeight");
            }
        }

        public Harmonics.Command.Command CloseCommand => closeCommand;

        public Harmonics.Command.Command ReportCommand => reportCommand;
        public Harmonics.Command.Command ShowReportContentCommand => showReportContentCommand;

        public ObservableCollection<User> User
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                OnPropertyChanged($"collection");
            }
        }
        private void DoCloseCommand()
        {
            var selectedChat = new SelectedChatView { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(selectedChat);
        }

        private void DoShowReportContentCommand()
        {
            showReportContent = !showReportContent;
            OnPropertyChanged($"ShowReportContent");
        }

        private void DoReportCommand()
        {
            var reportContentTable = new ReportContent { content = ReportContent };
            unitOfWork.ReportContents.Create(reportContentTable);
            unitOfWork.Reports.Create( new Report
            {
                reason = reportContentTable.id,
                sender_id = ((User) Application.Current.Properties["User"]).id,
                complainee = Convert.ToInt32(Application.Current.Properties["SelectedUserId"])
            });
            unitOfWork.Save();
        }

        public SelectedUserViewModel()
        {
            selectedUser =
                new ObservableCollection<User>
                {
                    unitOfWork.Users.Get(Convert.ToInt32(Application.Current.Properties["SelectedUserId"]))
                };
            closeCommand = new Harmonics.Command.Command(DoCloseCommand);
            reportCommand = new Harmonics.Command.Command(DoReportCommand);
            showReportContentCommand = new Harmonics.Command.Command(DoShowReportContentCommand);
        }
    }
}