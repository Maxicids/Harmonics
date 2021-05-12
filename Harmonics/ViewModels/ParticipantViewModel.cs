using System;
using System.Collections.ObjectModel;
using System.Windows;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class ParticipantViewModel : ViewModel
    {
        private ObservableCollection<User> participantsCollection;
        
        public ObservableCollection<User> Participants
        {
            get => participantsCollection;
            set
            {
                participantsCollection = value;
                OnPropertyChanged($"collection");
            }
        }

        public ParticipantViewModel()
        {
            participantsCollection = 
                new ObservableCollection<User>(unitOfWork.Users.GetAllByChatId(Convert.ToInt32(Application.Current.Properties["SelectedChatId"])));
        }
    }
}