using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Harmonics.Models
{
    public class Model : INotifyPropertyChanged
    {
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