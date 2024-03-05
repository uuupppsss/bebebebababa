using DataTemplateAppSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataTemplateAppSimple.Editors
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
}
