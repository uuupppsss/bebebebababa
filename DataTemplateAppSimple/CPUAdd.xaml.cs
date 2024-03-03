using DataTemplateAppSimple;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataTemplateAppSimple
{
    /// <summary>
    /// Логика взаимодействия для CPUAdd.xaml
    /// </summary>
    public partial class CPUAdd : Window
    {
        public CPU NewCPU { get; set; } = new CPU();
        public CPUAdd()
        {
            InitializeComponent();
            DataContext = this;
        }
    }

    public class BrandConverter : IValueConverter
    {
        static List<string> brand = new();
        static BrandConverter()
        {
            brand.Add("Intel");
            brand.Add("AMD");
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || (bool)value == false)
                return null;
            int index = int.Parse(parameter.ToString());
            return brand[index];
        }
    }
}
