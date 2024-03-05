using System.Globalization;
using System.Windows.Data;

namespace DataTemplateAppSimple.Converters
{
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
