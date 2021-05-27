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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Display.Text = "1";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Display.Text = "2";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Display.Text = "3";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Display.Text = "4";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Display.Text = "5";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Display.Text = "6";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Display.Text = "7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Display.Text = "8";
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Reset";
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Start";
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Save";
        }
    }
}
