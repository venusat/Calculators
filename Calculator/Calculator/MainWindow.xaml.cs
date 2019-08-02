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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstnumber;
        double secondnumber;
        string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zero(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "0";
        }

        private void One(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "1";
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "2";
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "3";
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "4";
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "5";
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "6";
        }

        private void Seven(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "7";
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "8";
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text += "9";
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            string first = OutputBlock.Text;
            firstnumber = double.Parse(first);
            OutputBlock.Text = "";
            operation = "+";
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            string first = OutputBlock.Text;
            firstnumber = double.Parse(first);
            OutputBlock.Text = "";
            operation = "/";
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            string first = OutputBlock.Text;
            firstnumber = double.Parse(first);
            OutputBlock.Text = "";
            operation = "*";
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            string first = OutputBlock.Text;
            firstnumber = double.Parse(first);
            OutputBlock.Text = "";
            operation = "-";
        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            string second = OutputBlock.Text;
            secondnumber = double.Parse(second);

            switch (operation)
            {
                case "+":
                    OutputBlock.Text = (firstnumber + secondnumber).ToString();
                    break;

                case "-":
                    OutputBlock.Text = (firstnumber - secondnumber).ToString();
                    break;

                case "*":
                    OutputBlock.Text = (firstnumber * secondnumber).ToString();
                    break;

                case "/":
                    OutputBlock.Text = (firstnumber / secondnumber).ToString();
                    break;
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            OutputBlock.Text = "";
            firstnumber = 0;
            secondnumber = 0;
            operation = "";
        }
    }
}
