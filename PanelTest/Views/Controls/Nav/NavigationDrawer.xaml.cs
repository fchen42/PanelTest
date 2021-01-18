using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PanelTest.Views.Controls.Nav
{
    /// <summary>
    ///     NavigationDrawer.xaml 的交互逻辑
    /// </summary>
    [ContentProperty(nameof(Items))]
    public partial class NavigationDrawer : UserControl
    {
        #region Constructor

        public NavigationDrawer()
        {
            InitializeComponent();

            Items = NavItemsHost.Children;
        }

        #endregion

        #region Public Properties

        public int CollapsedWidth
        {
            get => (int)GetValue(CollapsedWidthProperty);
            set => SetValue(CollapsedWidthProperty, value);
        }

        public int ExpandedWidth
        {
            get => (int)GetValue(ExpandedWidthProperty);
            set => SetValue(ExpandedWidthProperty, value);
        }

        public string MenuTitleIcon
        {
            get => (string)GetValue(MenuTitleIconProperty);
            set => SetValue(MenuTitleIconProperty, value);
        }

        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }

        public string MenuSubTitle
        {
            get => (string)GetValue(MenuSubTitleProperty);
            set => SetValue(MenuSubTitleProperty, value);
        }

        public UIElementCollection Items
        {
            get => (UIElementCollection)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
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

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(UIElementCollection), typeof(NavigationDrawer), new PropertyMetadata());

        #endregion
    }
}