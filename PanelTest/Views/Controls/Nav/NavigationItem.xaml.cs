using System.Windows;
using System.Windows.Controls;

namespace PanelTest.Views.Controls.Nav
{
    /// <summary>
    /// NavigationItem.xaml 的交互逻辑
    /// </summary>
    public partial class NavigationItem : UserControl
    {
        public NavigationItem()
        {
            InitializeComponent();
        }

        #region Public Properties

        /// <summary>
        /// 菜单项图标对应的 font-awesome 代码。
        /// </summary>
        public string FontAwesomeIcon
        {
            get => (string)GetValue(FontAwesomeIconProperty);
            set => SetValue(FontAwesomeIconProperty, value);
        }

        /// <summary>
        /// 菜单项文字。
        /// </summary>
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        #endregion

        #region Dependency Properties

        public static readonly DependencyProperty FontAwesomeIconProperty =
            DependencyProperty.Register("FontAwesomeIcon", typeof(string), typeof(NavigationItem), new PropertyMetadata(null));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(NavigationItem), new PropertyMetadata(null));

        #endregion
    }
}
