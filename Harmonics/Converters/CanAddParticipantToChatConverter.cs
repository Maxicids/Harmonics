using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.Converters
{
    public class CanAddParticipantToChatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            using var db = new UnitOfWork();
            var chat = db.Chats.Get(System.Convert.ToInt32(Application.Current.Properties["SelectedChatId"]));
            var userId = System.Convert.ToInt32( ((User) Application.Current.Properties["User"]).id);
            return userId == chat.creator_id ? Visibility.Visible : Visibility.Hidden;
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}