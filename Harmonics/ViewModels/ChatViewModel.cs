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
            using var db = new UnitOfWork();//TODO: test
            var chatId = System.Convert.ToInt32(parameter);
            var chat = db.Chats.Get(chatId);
            var userId = ((User) Application.Current.Properties["User"]).id;
            if (chat.creator_id == userId)
            {
                db.Participants.DeleteByChatId(chatId);
                db.Chats.Delete(chatId);
            }
            db.Participants.DeleteByChatAndParticipantId(chatId, userId);
            db.Save();
            UpdateChats();
        }

        private void UpdateChats()
        {
            using var db = new UnitOfWork();
            chatsCollection = 
                new ObservableCollection<Chat>(db.Chats.GetAllByUserId(
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