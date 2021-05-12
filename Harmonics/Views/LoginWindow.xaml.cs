using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Harmonics.ViewModels;

namespace Harmonics.Views
{
    public partial class LoginWindow
    {
        private bool isMaximized;
        private double topToSave;
        private double leftToSave;
        private double widthToSave;
        private double heightToSave;
        private readonly LoginViewModel loginViewModel = new LoginViewModel();
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = loginViewModel;
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

        private void MainGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Login_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (loginViewModel.LoginUser())
            {
                infoLabel.Foreground = Brushes.LimeGreen;
                Hide();  
                var mainWindow = new MainWindow {Top = Top, Left = Left};
                mainWindow.Show();
            }
            else
            {
                infoLabel.Foreground = Brushes.Red;
            }
        }

        private void ToRegistration_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Hide();  
            var registrationWindow = new RegistrationWindow {Top = Top, Left = Left};
            registrationWindow.Show();
        }

        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
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

        private void TbPassword_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            loginViewModel.Password = TbPassword.Password;
        }
    }
}