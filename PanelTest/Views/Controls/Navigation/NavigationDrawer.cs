using System.Windows;
using System.Windows.Controls.Primitives;

namespace PanelTest.Views.Controls.Navigation
{
    public class NavigationDrawer : Selector
    {
        #region Dependency Properties

        public static readonly DependencyProperty MenuTitleIconProperty =
            DependencyProperty.Register("MenuTitleIcon", typeof(string), typeof(NavigationDrawer), new PropertyMetadata(null));

        public static readonly DependencyProperty MenuSubTitleProperty =
            DependencyProperty.Register("MenuSubTitle", typeof(string), typeof(NavigationDrawer), new PropertyMetadata(null));

        public static readonly DependencyProperty MenuTitleProperty =
            DependencyProperty.Register("MenuTitle", typeof(string), typeof(NavigationDrawer), new PropertyMetadata(null));

        public static readonly DependencyProperty CollapsedWidthProperty =
            DependencyProperty.Register("CollapsedWidth", typeof(int), typeof(NavigationDrawer), new PropertyMetadata(0));

        public static readonly DependencyProperty ExpandedWidthProperty =
            DependencyProperty.Register("ExpandedWidth", typeof(int), typeof(NavigationDrawer), new PropertyMetadata(0));

        #endregion

        #region Public Properties

        public string MenuTitleIcon
        {
            get => (string)GetValue(MenuTitleIconProperty);
            set => SetValue(MenuTitleIconProperty, value);
        }


        public string MenuSubTitle
        {
            get => (string)GetValue(MenuSubTitleProperty);
            set => SetValue(MenuSubTitleProperty, value);
        }


        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }


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

        #endregion
    }
}