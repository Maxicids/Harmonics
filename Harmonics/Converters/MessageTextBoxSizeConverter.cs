using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Harmonics.Converters
{
    public class MessageTextBoxSizeConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
                {
                    return (double?) value * 0.85;
                }
             
                public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
                {
                    return DependencyProperty.UnsetValue;
                }  
    }
}