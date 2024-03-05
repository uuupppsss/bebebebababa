using DataTemplateAppSimple.Editors;
using DataTemplateAppSimple.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataTemplateAppSimple.Views
{
    /// <summary>
    /// Логика взаимодействия для ChooseItemWin.xaml
    /// </summary>
    public partial class ChooseItemWin : Window
    {
        public ObservableCollection<object> Items { get; set; } = new();
        public ChooseItemWin()
        {
            InitializeComponent();
            Items.Add(new CPU
            {
                Brand = "AMD",
                Clock_frequency = 2.4F,
                Price = 4000
            });
            DataContext = this;
        }

        private void CPUAdd(object sender, RoutedEventArgs e)
        {
            CPUAdd cpuwindow = new CPUAdd();
            cpuwindow.ShowDialog();
            Items.Add(cpuwindow.NewCPU);
        }

        private void GPUAdd_Click(object sender, RoutedEventArgs e)
        {
            GPUAdd gpuWindow = new GPUAdd();
            gpuWindow.ShowDialog();
            Items.Add(gpuWindow.NewGPU);
        }

        private void RAMAdd_Click(object sender, RoutedEventArgs e)
        {
            RAMAdd ramWindow = new RAMAdd();
            ramWindow.ShowDialog();
            Items.Add(ramWindow.NewRAM);
        }
    }
}
