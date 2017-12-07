using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiBinding
{
    /// <summary>
    /// This class is a MultiValueConverter.  It works much like a ValueConverter, except that it takes an array of values in the convert
    /// method and it returns an array of values from the ConvertBack routine.
    /// </summary>
    public class FullnameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            StringBuilder fullNameBuilder = new StringBuilder();
            foreach (object name in values)
            {
                fullNameBuilder.AppendFormat("{0} ", name.ToString());
            }
                return fullNameBuilder.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
