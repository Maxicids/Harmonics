using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Harmonics.ViewModels;
using Harmonics.Views.MenuPages;

namespace Harmonics.Views
{
    public partial class MainWindow
    {
        private bool isMaximized;
        private double topToSave;
        private double leftToSave;
        private double widthToSave;
        private double heightToSave;
        private UserControl menuPage;
        
        public MainWindow()
        {
            InitializeComponent();
            ContentGrid.Children.Clear();
            Application.Current.Properties["MainWindow"] = this;
            menuPage = new Chats { Height = ContentGrid.ActualHeight, Width = ContentGrid.ActualWidth };
            ContentGrid.Children.Add(menuPage);
        }

        public void ChangeContent(UserControl userControl)
        {
            ContentGrid.Children.Clear();
            menuPage = userControl;
            ContentGrid.Children.Add(menuPage); 
        }
        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MainGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }
        private void MainGrid_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            ContentPanel.Height = MainGrid.ActualHeight - TopGrid.Height - ToolGrid.Height;
            MenuGrid.Height = ContentPanel.Height;
            ContentGrid.Height = ContentPanel.Height;
            ContentGrid.Width = MainGrid.ActualWidth - MenuGrid.ActualWidth;
            (menuPage as IResizeable)?.ChangeSize(ContentGrid.Height, ContentGrid.Width);
        }
        protected override void OnStateChanged(EventArgs e)
        {
            base.OnStateChanged(e);
            if (WindowState != WindowState.Maximized) return;
            WindowState = WindowState.Normal;
            SetMaximized();
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
            Height = SystemParameters.MaximizedPrimaryScreenHeight - 15;
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
        private void MenuElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ((StackPanel) sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#262626"));
        }

        private void MenuElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ((StackPanel) sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#0d1521"));
        }
        private void MoveCursorMenu(int index)
        {
            MenuTransition.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, 80 + 60*index,0,0);
        }
        private void Chats_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(0);
            ContentGrid.Children.Clear();
            menuPage = new Chats { Height = ContentGrid.ActualHeight, Width = ContentGrid.ActualWidth };
            ContentGrid.Children.Add(menuPage);
            StopTablesUpdating();

        }

        private void Contacts_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(1);
            ContentGrid.Children.Clear();
            menuPage = new Settings { Height = ContentGrid.ActualHeight, Width = ContentGrid.ActualWidth };
            ContentGrid.Children.Add(menuPage);
            StopTablesUpdating();
        }

        private void ControlPanel_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(2);
            ContentGrid.Children.Clear();
            menuPage = new ControlPanel { Height = ContentGrid.ActualHeight, Width = ContentGrid.ActualWidth };
            ContentGrid.Children.Add(menuPage);
        }

        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            LogOut();
        }

        public void LogOut()
        {
            Close();
            var loginWindow = new LoginWindow {Top = Top, Left = Left};
            loginWindow.Show();
        }

        private static void StopTablesUpdating()
        {
            BlockedUsersViewModel.StopUpdating();
            UserViewModel.StopUpdating();
            ReportViewModel.StopUpdating();
        }
    }
}