﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages
{
    public partial class Settings : IResizeable
    {
        public Settings()
        {
            InitializeComponent();
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            //TODO: Save
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
        }
    }
}