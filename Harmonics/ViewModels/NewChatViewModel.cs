using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Harmonics.Models.Entities;

namespace Harmonics.ViewModels
{
    public class NewChatViewModel : ViewModel
    {
        private string title;
        private string description;
        private byte[] mainPicture;
        private int creator_id;
        private string info;

        public NewChatViewModel()
        {
            var imageUri = new Uri("../../Properties/Images/Avatar1.jpg", UriKind.Relative);
            var imageBitmap = new BitmapImage(imageUri);
            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageBitmap));
            using(var ms = new MemoryStream())
            {
                encoder.Save(ms);
                MainPicture = ms.ToArray();
            }
        }
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public byte[] MainPicture
        {
            get => mainPicture;
            set
            {
                mainPicture = value;
                OnPropertyChanged("MainPicture");
            }
        }

        public int CreatorId
        {
            get => creator_id;
            set
            {
                creator_id = value;
                OnPropertyChanged("CreatorId");
            }
        }

        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }

        public void AddNewChat()
        {
            unitOfWork.Chats.Create(new Chat
            {
                title = Title,
                description = Description,
                mainPicture = MainPicture,
                creator_id = Convert.ToInt32(Application.Current.Properties["UserId"]) 
            });
            unitOfWork.Save();
        }
    }
}