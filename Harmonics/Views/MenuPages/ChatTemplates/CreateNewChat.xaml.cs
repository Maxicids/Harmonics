﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class CreateNewChat : IResizeable
    {
        private readonly NewChatViewModel newChatViewModel = new NewChatViewModel();
        public CreateNewChat()
        {
            InitializeComponent();
            DataContext = newChatViewModel;
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }

        private void CLose_OnClick(object sender, RoutedEventArgs e)
        {
            var chats = new Chats { Height = ActualHeight, Width = ActualWidth };
            (Application.Current.Properties["MainWindow"] as MainWindow)?.ChangeContent(chats);
        }

        private void AddChat_OnClick(object sender, RoutedEventArgs e)
        {
            newChatViewModel.AddNewChat();
            //Todo: create chat
        }

        private void ChooseImage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".png",
                Filter =
                    "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            };
            var result = dlg.ShowDialog();

            if (result != true) return;
            var filename = dlg.FileName;
            var imageUri = new Uri(filename, UriKind.Relative);
            var imageBitmap = new BitmapImage(imageUri);
            Image.ImageSource = imageBitmap;
            
            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageBitmap));
            using var ms = new MemoryStream();
            encoder.Save(ms);
            newChatViewModel.MainPicture = ms.ToArray();
        }
    }
}