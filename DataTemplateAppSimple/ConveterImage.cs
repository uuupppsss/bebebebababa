using DataTemplateAppSimple;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace DataTemplateAppSimple
{
    internal class ConveterImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CPU cpu = new CPU();
            decimal val = decimal.Parse(value.ToString());
            if (val < 5000)
            {
                cpu.Img = File.ReadAllBytes("1.png");
                return cpu.Img;
            }
            else if (val > 5000)
            {
                cpu.Img = File.ReadAllBytes("2.jpg");
                return cpu.Img;
            }
            else
                return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
