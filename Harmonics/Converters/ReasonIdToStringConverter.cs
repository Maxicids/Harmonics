using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.Converters
{
    public class ReasonIdToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";
            using var db = new UnitOfWork();
            return db.ReportContents.Get((int) value).content;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}