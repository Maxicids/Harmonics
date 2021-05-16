using System.ComponentModel;
using System.Runtime.CompilerServices;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        protected readonly UnitOfWork unitOfWork = new();
        #region Public Event
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        #endregion

        #region Protected Method

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}