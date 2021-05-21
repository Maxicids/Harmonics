using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Harmonics.ViewModels;

namespace Harmonics.Views
{
    public partial class RegistrationWindow 
    {
        private bool isMaximized;
        private double topToSave;
        private double leftToSave;
        private double widthToSave;
        private double heightToSave;
        private readonly RegistrationViewModel registrationViewModel = new RegistrationViewModel();
        public RegistrationWindow()
        {
            InitializeComponent();
            DataContext = registrationViewModel;
        }
        private void MainGrid_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainBorder.Width = MainGrid.ActualWidth * 0.75;
            MainBorder.Height = MainGrid.ActualHeight * 0.38;
            CentralGrid.Height = MainGrid.ActualHeight - TopGrid.ActualHeight;
            LoginBorder.Margin = new Thickness(CentralGrid.ActualWidth / 2 + CentralGrid.ActualWidth / 4 , 0, 0, 0) ;
        }
        protected override void OnStateChanged(EventArgs e)
        {
            base.OnStateChanged(e);
            if (WindowState != WindowState.Maximized) return;
            WindowState = WindowState.Normal;
            SetMaximized();
        }
        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void MainGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void SetMaximized()
        {
            widthToSave = Width;
            heightToSave = Height;
            leftToSave = Left;
            topToSave = Top;
            Width = SystemParameters.PrimaryScreenWidth;
            Height = SystemParameters.MaximizedPrimaryScreenHeight;
            Top = 0;
            Left = 0;
            ResizeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
            isMaximized = true;
        }
        private void ToLogin_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Hide();  
            var loginWindow = new LoginWindow {Top = Top, Left = Left};
            loginWindow.Show();
        }
        private void MaximizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!isMaximized)
            {
                SetMaximized();
            }
            else
            {
                Width = widthToSave;
                Height = heightToSave;
                Left = leftToSave;
                Top = topToSave;
                ResizeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
                isMaximized = false;
            }
        }

        private void Register_OnClick(object sender, MouseButtonEventArgs e)
        {
            if (registrationViewModel.RegisterUser())
            {
                infoLabel.Foreground = Brushes.LimeGreen;
                ToLogin_OnMouseDown(this, e);
            }
            else
            {
                infoLabel.Foreground = Brushes.Red;
            }
        }

        private void TbPassword_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            registrationViewModel.Password = TbPassword.Password;
        }

        private void TbLogin_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsLetter(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void TbPassword_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}