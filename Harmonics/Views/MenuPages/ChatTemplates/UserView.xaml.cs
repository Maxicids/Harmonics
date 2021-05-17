using Harmonics.ViewModels;

namespace Harmonics.Views.MenuPages.ChatTemplates
{
    public partial class UserView : IResizeable
    {
        private readonly SelectedUserViewModel selectedUserViewModel = new();
        public UserView()
        {
            InitializeComponent();
            DataContext = selectedUserViewModel;
            selectedUserViewModel.ActualHeight =  Height;
            selectedUserViewModel.ActualWidth = Width;
        }
        public void ChangeSize(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}