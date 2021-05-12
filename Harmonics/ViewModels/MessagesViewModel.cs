using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class MessagesViewModel : ViewModel
    {
        private ObservableCollection<Message> chatMessages;
        
        public ObservableCollection<Message> Messages
        {
            get => chatMessages;
            set
            {
                chatMessages = value;
                OnPropertyChanged($"Messages");
            }
        }

        public MessagesViewModel()
        {
            chatMessages =
            new ObservableCollection<Message>
            (
                unitOfWork.Messages.GetAll().Where(x => x.chat_id == Convert.ToInt32(Application.Current.Properties["SelectedChatId"]))
            );
        }
    }
}