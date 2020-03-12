using System.Windows;
using CSharpProgramming2020.Task2.VIewModels;


namespace CSharpProgramming2020.Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
        }
    }
}
