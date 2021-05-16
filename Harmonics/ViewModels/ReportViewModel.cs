using System.Collections.ObjectModel;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class ReportViewModel : ViewModel
    {
        private ObservableCollection<Report> reportsCollection;

        public ObservableCollection<Report> Reports
        {
            get => reportsCollection;
            set
            {
                reportsCollection = value;
                OnPropertyChanged($"collection");
            }
        }

        public ReportViewModel()
        {
            reportsCollection = new ObservableCollection<Report>(unitOfWork.Reports.GetAll());
        }
    }
}