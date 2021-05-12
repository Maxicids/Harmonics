using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Harmonics.ViewModels;
using Harmonics.Views.MenuPages.ControlPanelTables;

namespace Harmonics.Views.MenuPages
{
    public partial class ControlPanel : IResizeable 
    {
        private UserControl tablePage;
        private readonly List<UserControl> tables;
        private int selectedTableIndex;
        public ControlPanel()
        {
            InitializeComponent();
            tables = new List<UserControl>
            {
                new UsersTable(),
                new BlockedUsersTable(),
                new ReportsTable() 
            };
            tablePage = tables[0];
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(tablePage);
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
            ContentGrid.Height = height - TopPanel.ActualHeight;
            ContentGrid.Width = width;
        }

        private void ButtonPrev_OnClick(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            if (selectedTableIndex > 0)
            {
                tablePage = tables[--selectedTableIndex];
            }
            else
            {
                selectedTableIndex = 2;
                tablePage = tables[selectedTableIndex];
            }
            ContentGrid.Children.Add(tablePage);
        }

        private void ButtonNext_OnClick(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            if (selectedTableIndex < 2)
            {
                tablePage = tables[++selectedTableIndex];
            }
            else
            {
                selectedTableIndex = 0;
                tablePage = tables[selectedTableIndex];
            }

            ContentGrid.Children.Add(tablePage);
        }
    }
}