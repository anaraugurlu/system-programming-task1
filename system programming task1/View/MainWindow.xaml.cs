﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using system_programming_task1.ViewModels;

namespace system_programming_task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(this);

            //var process = Process.GetCurrentProcess();
            //Console.WriteLine(process.ProcessName);


            //var processes = Process.GetProcesses();

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
