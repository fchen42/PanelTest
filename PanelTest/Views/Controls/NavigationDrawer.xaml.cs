using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace PanelTest.Views.Controls
{
    /// <summary>
    /// NavigationDrawer.xaml 的交互逻辑
    /// </summary>
    public partial class NavigationDrawer : UserControl
    {
        public NavigationDrawer()
        {
            InitializeComponent();
        }

        public int CollapsedWidth
        {
            get => (int)GetValue(CollapsedWidthProperty);
            set => SetValue(CollapsedWidthProperty, value);
        }

        public static readonly DependencyProperty CollapsedWidthProperty =
            DependencyProperty.Register("CollapsedWidth", typeof(int), typeof(NavigationDrawer), new PropertyMetadata(0));



        public int ExpandedWidth
        {
            get => (int)GetValue(ExpandedWidthProperty);
            set => SetValue(ExpandedWidthProperty, value);
        }

        public static readonly DependencyProperty ExpandedWidthProperty =
            DependencyProperty.Register("ExpandedWidth", typeof(int), typeof(NavigationDrawer), new PropertyMetadata(0));


        public NavItemPanel NavItems
        {
            get => (NavItemPanel)GetValue(NavItemsProperty);
            set => SetValue(NavItemsProperty, value);
        }

        public static readonly DependencyProperty NavItemsProperty =
            DependencyProperty.Register("NavItems", typeof(NavItemPanel), typeof(NavigationDrawer), new PropertyMetadata(null));

    }

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
}
