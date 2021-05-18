using System;
using System.Collections.ObjectModel;
using Harmonics.ImageProcessing;
using System.Windows;
using System.Windows.Media.Imaging;
using Harmonics.Models.Entities;
using Harmonics.Validation;

namespace Harmonics.ViewModels
{
    public class SettingsViewModel : ViewModel
    {
        private ObservableCollection<User> selectedSelectedUser;
        private readonly Harmonics.Command.Command saveCommand;
        private Setting setting;
        private string info;
        private string login;
        private string description;
        private int chatFontSize;
        private BitmapImage profilePicture;
        public BitmapImage ProfilePicture
        {
            get => profilePicture;
            set
            {
                profilePicture = value;
                OnPropertyChanged($"ProfilePicture");
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged($"Description");
            }
        }
        
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged($"Login");
            }
        }
        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged($"Info");
            }
        }
        public int ChatFontSize
        {
            get => chatFontSize;
            set
            {
                chatFontSize = value;
                OnPropertyChanged($"ChatFontSize");
            }
        }
        public ObservableCollection<User> SelectedUser
        {
            get => selectedSelectedUser;
            set
            {
                selectedSelectedUser = value;
                OnPropertyChanged($"collection");
            }
        }

        private void DoSaveCommand()
        {
            if (Description.Length > 200)
            {
                Info = ErrorMessages.DescriptionMaxLength;
                return;
            }

            if (ChatFontSize is < 12 or > 16)
            {
                Info = ErrorMessages.TextSizeRange;
                return;
            }

            Info = "";
            selectedSelectedUser[0].description = Description;
            selectedSelectedUser[0].profile_Picture = ImageConverter.GetBytesFromImage(ProfilePicture);
            setting.chat_font_size = ChatFontSize;
            unitOfWork.Users.Update(selectedSelectedUser[0]);
            unitOfWork.Settings.Update(setting);
            unitOfWork.Save();
        }
        public Harmonics.Command.Command SaveCommand => saveCommand;
        public SettingsViewModel()
        {
            selectedSelectedUser =
                new ObservableCollection<User>
                {
                    unitOfWork.Users.Get(Convert.ToInt32( ((User) Application.Current.Properties["User"]).id))
                };
            saveCommand = new Harmonics.Command.Command(DoSaveCommand);
            description = selectedSelectedUser[0].description;
            setting = unitOfWork.Settings.Get(selectedSelectedUser[0].settings);
            chatFontSize = setting.chat_font_size;
            login = selectedSelectedUser[0].login;
            profilePicture = ImageConverter.GetImageFromBytes(selectedSelectedUser[0].profile_Picture);
        }
    }
}