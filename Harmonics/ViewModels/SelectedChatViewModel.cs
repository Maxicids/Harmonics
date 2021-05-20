using System;
using System.Collections.ObjectModel;
using System.Security;
using System.Windows;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class SelectedChatViewModel : ViewModel
    {
        private ObservableCollection<Chat> selectedChat;
        private string chatName;

        public string ChatName
        {
            get => chatName;
            set
            {
                chatName = value;
                OnPropertyChanged($"ChatName");
            }
        }
        
        public SelectedChatViewModel()
        {
            selectedChat = new ObservableCollection<Chat>
            {
                unitOfWork.Chats.Get(Convert.ToInt32(Application.Current.Properties["SelectedChatId"]))
            };
            ChatName = selectedChat[0].title;
        }
    }
}