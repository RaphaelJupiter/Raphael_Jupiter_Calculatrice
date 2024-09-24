using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace Raphael_Jupiter_Calculatrice
{

    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double first_num;
        double second_num;
        double result;
        char operation;

       


        public void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            first_num=double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '+';
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_diviser_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }



        private void BTN_Clear_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
           
        }

        private void BTN_cos_Click(object sender, RoutedEventArgs e)
        {
            first_num = Double.Parse(TB_Display.Text);
            result = Math.Sin(first_num);
            TB_Display.Text = result.ToString();
        }
        private void BTN_sin_Click(object sender, RoutedEventArgs e) 
        {
            first_num = Double.Parse(TB_Display.Text);
            result = Math.Sin(first_num);
            TB_Display.Text = result.ToString();
        }
        private void BTN_tan_Click(object sender, RoutedEventArgs e)
        {
            first_num = Double.Parse(TB_Display.Text);
            result = Math.Tan(first_num);
            TB_Display.Text = result.ToString();
        }
        private void BTN_vir_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            
            operation = ',';
        }

        private void BTN_egal_Click(object sender, RoutedEventArgs e)
        {
            second_num =double.Parse(TB_Display.Text);
            switch (operation)
            {
                case '+':
                    result = first_num + second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case '-':
                    result = first_num - second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case '/':
                    result = first_num / second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case '*':
                    result = first_num * second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case 'C':
                    result = first_num * second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case 'S':
                    result = first_num * second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case 'T':
                    result = first_num * second_num;
                    TB_Display.Text = result.ToString();
                    break;
                case ',':
                    result = first_num * second_num;
                    TB_Display.Text = result.ToString();
                    break;
            }
        }
    }
   
}
