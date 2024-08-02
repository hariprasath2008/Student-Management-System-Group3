using System.Windows;

namespace StudentPortal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MVVM.ViewModels.MainWindowViewModel();
        }
    }
}
