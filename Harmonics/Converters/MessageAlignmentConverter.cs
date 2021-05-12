using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Harmonics.Converters
{
    public class MessageAlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && (int) value == System.Convert.ToInt32(Application.Current.Properties["UserId"]))
            {
                return HorizontalAlignment.Right;
            }
            return HorizontalAlignment.Left;
        }
     
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}