using System.Windows;

namespace PanelTest.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 最大化时不要覆盖系统任务栏
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
    }
}
