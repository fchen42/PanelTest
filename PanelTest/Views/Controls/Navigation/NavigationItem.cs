using System.Windows;
using System.Windows.Controls;

namespace PanelTest.Views.Controls.Navigation
{
    public class NavigationItem : ContentControl
    {
        static NavigationItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationItem),
                new FrameworkPropertyMetadata(typeof(NavigationItem)));
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(NavigationItem), new PropertyMetadata(null));


        public static readonly DependencyProperty IconFontAwesomeProperty =
            DependencyProperty.Register("IconFontAwesome", typeof(string), typeof(NavigationItem),
                new PropertyMetadata(null));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public string IconFontAwesome
        {
            get => (string)GetValue(IconFontAwesomeProperty);
            set => SetValue(IconFontAwesomeProperty, value);
        }
    }
}