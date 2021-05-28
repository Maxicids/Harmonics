using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.ViewModels
{
    public class MessagesViewModel : ViewModel
    {
        private static bool isElementVisible;
        
        private ObservableCollection<Message> chatMessages;
        private string message;
        private readonly Harmonics.Command.Command sendMessageCommand;
        
        public ObservableCollection<Message> Messages
        {
            get => chatMessages;
            set
            {
                chatMessages = value;
                OnPropertyChanged($"Messages");
            }
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged($"Message");
            }
        }
        public Harmonics.Command.Command SendMessageCommand => sendMessageCommand;

        private void DoSendCommand()
        {
            if (Application.Current.Properties["User"] is not User user)
            {
                App.UnknownError();
                return;
            }
            App.IsBlocked();
            if (string.IsNullOrEmpty(Message)) return;
            unitOfWork.Messages.Create(new Message
            {
                from_id = Convert.ToInt32(user.id),
                chat_id = Convert.ToInt32(Application.Current.Properties["SelectedChatId"]),
                content = Message,
                sending_time = DateTime.Now
            });
            unitOfWork.Save();
            Message = "";
        }
        private void DoUpdate()
        {
            do
            {
                using var db = new UnitOfWork();
                chatMessages =
                    new ObservableCollection<Message>
                    (
                        unitOfWork.Messages.GetAll().
                            Where(x => x.chat_id == Convert.ToInt32(Application.Current.Properties["SelectedChatId"])).
                            OrderBy(x => x.sending_time)
                    );
                OnPropertyChanged($"");
                Thread.Sleep(2000);
            } while (isElementVisible);
        }
        public static void StopUpdating()
        {
            isElementVisible = false;
        }
        public MessagesViewModel()
        {
            chatMessages =
            new ObservableCollection<Message>
            (
                unitOfWork.Messages.GetAll().Where(x => x.chat_id == Convert.ToInt32(Application.Current.Properties["SelectedChatId"])).OrderBy(x => x.sending_time)
            );
            sendMessageCommand = new Harmonics.Command.Command(DoSendCommand);
            isElementVisible = true;
            var ctThread = new Thread(DoUpdate);
            ctThread.Start();
        }
    }
}