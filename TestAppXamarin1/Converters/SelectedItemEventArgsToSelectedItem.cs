using System;
using System.Globalization;
using Xamarin.Forms;

namespace TestAppXamarin1.Converters
{
    public class SelectedItemEventArgsToSelectedItem: IValueConverter
    {
        public SelectedItemEventArgsToSelectedItem()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var eventArgs = value as SelectedItemChangedEventArgs;
            return eventArgs.SelectedItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
