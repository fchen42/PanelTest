using System.Windows;
using System.Windows.Controls;

namespace PanelTest.Views.Controls
{
    /// <summary>
    ///     NavigationDrawer.xaml 的交互逻辑
    /// </summary>
    public partial class NavigationDrawer : UserControl
    {
        #region Constructor

        public NavigationDrawer()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        public int CollapsedWidth
        {
            get => (int) GetValue(CollapsedWidthProperty);
            set => SetValue(CollapsedWidthProperty, value);
        }

        public int ExpandedWidth
        {
            get => (int) GetValue(ExpandedWidthProperty);
            set => SetValue(ExpandedWidthProperty, value);
        }

        public string MenuTitleIcon
        {
            get => (string) GetValue(MenuTitleIconProperty);
            set => SetValue(MenuTitleIconProperty, value);
        }

        public string MenuTitle
        {
            get => (string) GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }

        public string MenuSubTitle
        {
            get => (string)GetValue(MenuSubTitleProperty);
            set => SetValue(MenuSubTitleProperty, value);
        }

        #endregion

        #region Dependency Properties

        public static readonly DependencyProperty CollapsedWidthProperty =
            DependencyProperty.Register(nameof(CollapsedWidth), typeof(int), typeof(NavigationDrawer),
                new PropertyMetadata(0));

        public static readonly DependencyProperty ExpandedWidthProperty =
            DependencyProperty.Register(nameof(ExpandedWidth), typeof(int), typeof(NavigationDrawer),
                new PropertyMetadata(0));

        public static readonly DependencyProperty MenuTitleIconProperty =
            DependencyProperty.Register(nameof(MenuTitleIcon), typeof(string), typeof(NavigationDrawer),
                new PropertyMetadata(null));

        public static readonly DependencyProperty MenuTitleProperty =
            DependencyProperty.Register(nameof(MenuTitle), typeof(string), typeof(NavigationDrawer),
                new PropertyMetadata(null));

        public static readonly DependencyProperty MenuSubTitleProperty =
            DependencyProperty.Register(nameof(MenuSubTitle), typeof(string), typeof(NavigationDrawer),
                new PropertyMetadata(null));

        #endregion


        /*

        public NavItemPanel NavItems
        {
            get => (NavItemPanel)GetValue(NavItemsProperty);
            set => SetValue(NavItemsProperty, value);
        }

        public static readonly DependencyProperty NavItemsProperty =
            DependencyProperty.Register("NavItems", typeof(NavItemPanel), typeof(NavigationDrawer), new PropertyMetadata(null));
            */
    }

    /*
    public class NavItemPanel : Selector
    {

    }

    public class NavItem : Selector
    {
        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(NavItem), new PropertyMetadata(""));

    }
    */
}