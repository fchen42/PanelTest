using PropertyChanged;
using System.Windows;
using System.Windows.Input;

namespace PanelTest.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        #region Public Properties

        /// <summary>
        /// 当前管理窗体的状态。
        /// </summary>
        public WindowState ViewWindowState { get; set; }

        /// <summary>
        /// 窗口标题。
        /// </summary>
        public string WindowTitle { get; set; } = "PanelTest";

        /// <summary>
        /// 标题栏高度。
        /// </summary>
        public int TitleBarHeight { get; set; } = 36;

        /// <summary>
        /// 窗口外边框大小。
        /// </summary>
        public int OuterMarginSize { get; set; } = 10;

        /// <summary>
        /// 可拖拽缩放区域大小。
        /// </summary>
        public int ResizeAreaSize { get; set; } = 6;

        /// <summary>
        /// 可拖拽缩放边框整体大小。
        /// </summary>
        public int ResizeBorderSize => OuterMarginSize + ResizeAreaSize;

        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
            ViewWindowState = WindowState.Normal;
        }

        #endregion

        #region Commands

        /// <summary>
        /// 窗口最大化命令。
        /// </summary>
        public ICommand WindowMaximizeCommand => new RelayCommand(() => ViewWindowState = WindowState.Maximized);

        /// <summary>
        /// 窗口最小化命令。
        /// </summary>
        public ICommand WindowMinimizeCommand => new RelayCommand(() => ViewWindowState = WindowState.Minimized);

        #endregion
    }
}