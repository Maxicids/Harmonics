using System;
using System.Collections.ObjectModel;
using System.Windows;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class ChatViewModel : ViewModel
    {
        private ObservableCollection<Chat> chatsCollection;

        public ObservableCollection<Chat> Chats
        {
            get => chatsCollection;
            set
            {
                chatsCollection = value;
                OnPropertyChanged("Chats");
            }
        }

        public ChatViewModel()
        {
            chatsCollection = 
                new ObservableCollection<Chat>(unitOfWork.Chats.GetAllByUserId(Convert.ToInt32(Application.Current.Properties["UserId"])));
        }
    }
}