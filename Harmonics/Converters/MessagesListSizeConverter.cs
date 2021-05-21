using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Harmonics.Converters
{
    public class MessagesListSizeConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((double?)value >= 50)
            {
                return (double?) value - 50 - 60;
            }
            return 0;
        }
             
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }  
    }
}