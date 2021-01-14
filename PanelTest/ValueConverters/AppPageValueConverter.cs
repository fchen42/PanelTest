using System;
using System.Globalization;
using PanelTest.Models;
using PanelTest.Views.Pages;

namespace PanelTest.ValueConverters
{
    public class AppPageValueConverter : BaseValueConverter<AppPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            
            switch ((AppPage) value)
            {
                case AppPage.Main:
                    return new MainPage();
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}