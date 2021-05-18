using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages
{
    public partial class Settings : IResizeable
    {
        private readonly SettingsViewModel settingsViewModel = new();
        public Settings()
        {
            InitializeComponent();
            DataContext = settingsViewModel;
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
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
            settingsViewModel.ProfilePicture = imageBitmap;
        }

        private void TbTextSize_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}