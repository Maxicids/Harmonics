using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Harmonics.Converters
{
    public class DeleteFromChatButtonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && (int) value == System.Convert.ToInt32(Application.Current.Properties["UserId"]) ? Visibility.Hidden : Visibility.Visible;
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}