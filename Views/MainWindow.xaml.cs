using datacollection.UI;
using datacollection.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace datacollection.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
