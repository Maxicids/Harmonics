using System.Collections.ObjectModel;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class ReportViewModel : ViewModel
    {
        private ObservableCollection<Report> chatsCollection;

        public ObservableCollection<Report> Reports
        {
            get => chatsCollection;
            set
            {
                chatsCollection = value;
                OnPropertyChanged($"collection");
            }
        }

        public ReportViewModel()
        {
            chatsCollection = new ObservableCollection<Report>(unitOfWork.Reports.GetAll());
        }
    }
}