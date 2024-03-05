using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Printing.Interop;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace DataTemplateAppSimple.Converters
{
    internal class ConveterImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte[] img = null;
            decimal val = decimal.Parse(value.ToString());
            string str = parameter.ToString();
            if (str == "cpu")
            {
                if (val < 5000)
                {
                    img = File.ReadAllBytes("1.jpg");
                }
                else if (val > 5000)
                {
                    img = File.ReadAllBytes("2.jpg");
                }
            }

            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
