using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
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
            return login == db.Users.Get((int) Application.Current.Properties["UserId"]).login ? "You" : login;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}