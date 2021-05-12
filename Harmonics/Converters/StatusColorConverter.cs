using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Harmonics.Converters
{
    public class StatusColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value?.ToString())
            {
                case "False":
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#4a4a4a"));
                case "True":
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#6a6a6a"));
                default:
                    return new SolidColorBrush();
            }
        }
     
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }  
    }
}