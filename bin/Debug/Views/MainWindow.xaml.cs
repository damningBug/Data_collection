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

        //private void ExportCommand(object sender, ExecutedRoutedEventArgs e)
        //{
        //    // 创建并显示新的窗口
        //    Settings setting = new Settings();
        //    setting.ShowDialog(); // 非模态；若要模态则用 ShowDialog()
        //}
    }
}
