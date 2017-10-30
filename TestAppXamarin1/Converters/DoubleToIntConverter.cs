using System;
using System.Globalization;
using Xamarin.Forms;

namespace TestAppXamarin1.Converters
{
    public class DoubleToIntConverter: IValueConverter
    {
        public DoubleToIntConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is decimal)
            {
                return Decimal.ToInt32(Math.Round((decimal)value));
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
