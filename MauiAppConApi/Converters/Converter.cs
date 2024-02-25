using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppConApi.Converters
{
    public class StatusToBorderColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string status)
            {
                return status switch
                {
                    "Alive" => Colors.Green,
                    "Dead" => Colors.Red,
                    "Unknown" => Colors.Gray,
                    _ => Colors.Gray
                };
            }

            return Colors.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
