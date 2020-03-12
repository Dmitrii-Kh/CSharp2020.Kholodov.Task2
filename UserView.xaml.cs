using System.Windows.Controls;
using CSharpProgramming2020.Task2.VIewModels;

namespace CSharpProgramming2020.Task2
{
    /// <summary>
    /// Логика взаимодействия для UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        private UserViewModel _viewModel;
        public UserView()
        {
            InitializeComponent();
            DataContext = _viewModel = new UserViewModel();
        }
    }
}