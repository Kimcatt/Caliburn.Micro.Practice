using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Kimcatt.Mvvm.ValueConverter
{
    public class DateTimerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                return (string)((value as DateTime?)?.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return DateTime.Parse(value as string);
            }
            return null;
        }
    }
}
