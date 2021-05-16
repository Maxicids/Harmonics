using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.Converters
{
    public class DeleteFromChatButtonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            using var db = new UnitOfWork();
            var chat = db.Chats.Get(System.Convert.ToInt32(Application.Current.Properties["SelectedChatId"]));
            var userId = System.Convert.ToInt32(Application.Current.Properties["UserId"]);
            if (userId == chat.creator_id)
            {
                return value != null && (int) value == userId ? Visibility.Hidden : Visibility.Visible;
            }
            return Visibility.Hidden;
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}