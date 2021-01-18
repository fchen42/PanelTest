using PanelTest.Models;
using PropertyChanged;
using System.Windows;
using System.Windows.Input;

namespace PanelTest.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        #region Private Members

        private int _outerMarginSize = 10;

        #endregion

        #region Public Properties

        /// <summary>
        /// 当前管理窗体的状态。
        /// </summary>
        public WindowState ViewWindowState { get; set; } = WindowState.Normal;

        /// <summary>
        /// 窗口标题。
        /// </summary>
        public string WindowTitle { get; set; } = "PanelTest";

        /// <summary>
        /// 程序版本描述字符串。
        /// </summary>
        public string AppVersion { get; set; } = "Ver 1.0";

        /// <summary>
        /// 窗口外边框大小。
        /// </summary>
        public int OuterMarginSize
        {
            get => ViewWindowState == WindowState.Maximized ? 5 : _outerMarginSize;
            set => _outerMarginSize = value;
        }

        /// <summary>
        /// 可拖拽缩放区域大小。
        /// </summary>
        public int ResizeAreaSize { get; set; } = 6;

        /// <summary>
        /// 可拖拽缩放边框整体大小。
        /// </summary>
        public int ResizeBorderSize => OuterMarginSize + ResizeAreaSize;

        /// <summary>
        /// 当前显示页面。
        /// </summary>
        public AppPage CurrentPage { get; set; } = AppPage.Main;

        #endregion

        #region Commands

        /// <summary>
        /// 窗口最大化命令。
        /// </summary>
        // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
        public ICommand MaximizeWindowCommand => new RelayCommand(() => ViewWindowState ^= WindowState.Maximized);

        /// <summary>
        /// 窗口最小化命令。
        /// </summary>
        public ICommand MinimizeWindowCommand => new RelayCommand(() => ViewWindowState = WindowState.Minimized);

        /// <summary>
        /// 关闭窗口命令。
        /// </summary>
        public ICommand CloseWindowCommand => new RelayCommand(() => Application.Current.Shutdown());

        #endregion
    }
}