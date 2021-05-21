using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Harmonics.ImageProcessing;
using Harmonics.Models.Entities;
using Harmonics.Views;
using Harmonics.Views.MenuPages;

namespace Harmonics.ViewModels
{
    public class NewChatViewModel : ViewModel
    {
        private double actualWidth;
        private double actualHeight;
        private string title;
        private string description;
        private byte[] mainPicture;
        private string info;
        private readonly Harmonics.Command.Command closeCommand;
        private readonly Harmonics.Command.Command createNewChatCommand;

        public NewChatViewModel()
        {
            var imageUri = new Uri("../../Properties/Images/Avatar1.jpg", UriKind.Relative);
            var imageBitmap = new BitmapImage(imageUri);
            MainPicture = ImageConverter.GetBytesFromImage(imageBitmap);
            
            createNewChatCommand = new Harmonics.Command.Command(DoCreateNewChatCommand);
            closeCommand = new Harmonics.Command.Command(DoCloseCommand);
        }
        public double ActualWidth
        {
            get => actualWidth;
            set
            {
                actualWidth = value;
                OnPropertyChanged($"ActualWidth");
            }
        }

        public double ActualHeight
        {
            get => actualHeight;
            set
            {
                actualHeight = value;
                OnPropertyChanged($"ActualHeight");
            }
        }
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged($"Title");
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

        public byte[] MainPicture
        {
            get => mainPicture;
            set
            {
                mainPicture = value;
                OnPropertyChanged($"MainPicture");
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
        public Harmonics.Command.Command CreateNewChatCommand => createNewChatCommand;
        public Harmonics.Command.Command CloseCommand => closeCommand;
        private void DoCreateNewChatCommand()
        {
            var user = Application.Current.Properties["User"] as User;
            if (user == null || user.is_Blocked)
            {
                MessageBox.Show("You has been blocked");
                (Application.Current.Properties["MainWindow"] as MainWindow)?.LogOut();
            }
            var userId = Convert.ToInt32(user?.id); 
            var chat = new Chat
            {
                title = Title,
                description = Description,
                mainPicture = MainPicture,
                creator_id = userId 
            };
            unitOfWork.Chats.Create(chat);
            unitOfWork.Participants.Create( new Participant
            {
                chat = chat.id,
                participant1 = userId
            });
            unitOfWork.Save();
            DoCloseCommand();
        }
        private void DoCloseCommand()
        {
            var chats = new Chats { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(chats);
        }
    }
}