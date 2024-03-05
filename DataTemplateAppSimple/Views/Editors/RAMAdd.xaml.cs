using DataTemplateAppSimple.Models;
using System;
using System.Collections.Generic;
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

namespace DataTemplateAppSimple.Editors
{
    /// <summary>
    /// Логика взаимодействия для RAMAdd.xaml
    /// </summary>
    public partial class RAMAdd : Window
    {
        public RAM NewRAM { get; set; } = new RAM();
        public RAMAdd()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
