﻿using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataTemplateAppSimple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<object> Items { get; set; } = new();
        public MainWindow()
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

    public class CPU
    {
        public string Brand { get; set; }
        public float Clock_frequency { get; set; }
        public decimal Price { get; set; }
        public byte[] Img { get; set; }
    }

    public class GPU
    {
        public string Title { get; set; }
        public int Capacity { get; set; }
        public float Frequency { get; set; }
        public decimal Price { get; set; }
        public byte[] Img { get; set; }
    }
    public class RAM
    {
        public string Title { get; set; }
        public int Capacity { get; set; }
        public float Frequency { get; set; }
        public decimal Price { get; set; }
        public byte[] Img { get; set; }
    }
}
