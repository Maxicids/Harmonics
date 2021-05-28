using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.Converters
{
    public class UserIdToFontSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            using var db = new UnitOfWork();
            return Application.Current.Properties["User"] is not User user ? 15 : db.Settings.Get(user.settings).chat_font_size;
        }
     
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }  
    }
}