using System;
using System.Collections.ObjectModel;
using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

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
                OnPropertyChanged($"Chats");
            }
        }
        private Harmonics.Command.Command deleteChatCommand;
        public Harmonics.Command.Command DeleteChatCommand => deleteChatCommand;
        private void DoDeleteChatCommand(object parameter)
        {
            using var db = new UnitOfWork();
            var value = System.Convert.ToInt32(parameter);
            db.Participants.DeleteByChatId(System.Convert.ToInt32(value));
            db.Chats.Delete(value);
            db.Save();
            UpdateChats();
        }

        private void UpdateChats()
        {
            chatsCollection = 
                new ObservableCollection<Chat>(unitOfWork.Chats.GetAllByUserId(
                    Convert.ToInt32( ((User) Application.Current.Properties["User"]).id)));
            OnPropertyChanged($"Chats");
        }
        public ChatViewModel()
        {
            UpdateChats();
            deleteChatCommand = new Harmonics.Command.Command(DoDeleteChatCommand);
        }
    }
}