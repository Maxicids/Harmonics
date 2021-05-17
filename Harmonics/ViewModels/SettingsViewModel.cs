using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class SettingsViewModel : ViewModel
    {
        private ObservableCollection<User> selectedSelectedUser;
        private Harmonics.Command.Command saveCommand;
        private Setting setting;
        private string login;
        private string description;
        private int chatFontSize;
        private BitmapImage profilePicture;
        public BitmapImage ProfilePicture
        {
            get
            {
                return profilePicture;
            }
            set
            {
                profilePicture = value;
                OnPropertyChanged();
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
            profilePicture = LoadImage(selectedSelectedUser[0].profile_Picture);
        }
        
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}