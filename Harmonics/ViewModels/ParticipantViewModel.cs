using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Models.UnitOfWork;

namespace Harmonics.ViewModels
{
    public class ParticipantViewModel : ViewModel
    {
        private static bool isElementVisible;
        
        private ObservableCollection<User> participantsCollection;
        private readonly Harmonics.Command.Command removeFromChatCommand;
        
        public ObservableCollection<User> Participants
        {
            get => participantsCollection;
            set
            {
                participantsCollection = value;
                OnPropertyChanged($"Participants");
            }
        }

        public Harmonics.Command.Command RemoveFromChatCommand => removeFromChatCommand;

        private void DoRemoveFromChatCommand(object parameter)
        {
            var result = MessageBox.Show("Do you want to delete this user?", "Confirmation",MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                unitOfWork.Participants.DeleteByChatAndParticipantId
                    (
                    Convert.ToInt32(Application.Current.Properties["SelectedChatId"]), 
                    Convert.ToInt32(parameter)
                    );
                unitOfWork.Save();
            }
            else if (result == MessageBoxResult.No)
            {
                
            }
        }

        private void DoUpdate()
        {
            do
            {
                using var db = new UnitOfWork();
                participantsCollection = 
                    new ObservableCollection<User>(db.Users.GetAllByChatId(Convert.ToInt32(Application.Current.Properties["SelectedChatId"])));
                OnPropertyChanged($"");
                Thread.Sleep(2000);
            } while (isElementVisible);
        }

        public static void StopUpdating()
        {
            isElementVisible = false;
        }
        public ParticipantViewModel()
        {
            participantsCollection = 
                new ObservableCollection<User>(unitOfWork.Users.GetAllByChatId(Convert.ToInt32(Application.Current.Properties["SelectedChatId"])));
            removeFromChatCommand = new Harmonics.Command.Command(DoRemoveFromChatCommand);
            isElementVisible = true;
            var ctThread = new Thread(DoUpdate);
            ctThread.Start();
        }
    }
}