using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.Converters
{
    public class IdToLoginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";
            using var db = new UnitOfWork();
            var login = db.Users.Get((int) value).login;
            return login == ((User) Application.Current.Properties["User"]).login ? "You" : login;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}