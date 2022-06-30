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

namespace Rekenmachine_level_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string een = "";
        string twee = "";
        char function;
        double result = 0.0;
        string userinput = "";

        public MainWindow()
        {
            InitializeComponent();
        }






        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "1";
            Textbalk.Text += userinput;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "2";
            Textbalk.Text += userinput;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "3";
            Textbalk.Text += userinput;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "4";
            Textbalk.Text += userinput;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "5";
            Textbalk.Text += userinput;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "6";
            Textbalk.Text += userinput;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "7";
            Textbalk.Text += userinput;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "8";
            Textbalk.Text += userinput;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "9";
            Textbalk.Text += userinput;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += "0";
            Textbalk.Text += userinput;
        }

        private void btnPlus_Click_1(object sender, RoutedEventArgs e)
        
            {
                function = '+';
                een = userinput;
                userinput = "";
                Textbalk.Text = een + "+";
            }

        private void btnMin_Click_1(object sender, RoutedEventArgs e)
        
              {
                    function = '-';
                    een = userinput;
                    userinput = "";
                    Textbalk.Text = een + "-";
              }

        private void btnKeer_Click_1(object sender, RoutedEventArgs e)
        
                    {
                        function = '*';
                        een = userinput;
                        userinput = "";
                        Textbalk.Text = een + "*";
                    }

        private void btnGedeelddoor_Click(object sender, RoutedEventArgs e)
        
                        {
                            function = '/';
                            een = userinput;
                            userinput = "";
                            Textbalk.Text = een + "/";
                        }

        private void btnIs_Click_1(object sender, RoutedEventArgs e)
        {
            {
                twee = userinput;
                double firstNum, secondNum;
                firstNum = Convert.ToDouble(een);
                secondNum = Convert.ToDouble(twee);

                if (function == '+')
                {
                    result = firstNum + secondNum;
                    Textbalk.Text = result.ToString();
                    userinput = "" + result.ToString();

                }

                else if (function == '-')
                {
                    result = firstNum - secondNum;
                    Textbalk.Text = result.ToString();
                    userinput = "" + result.ToString();
                }
                else if (function == '/')
                {
                    if (secondNum == 0)
                    {
                        Textbalk.Text = "mag niet";
                    }
                    else
                        result = firstNum / secondNum;
                    Textbalk.Text = result.ToString();
                    userinput = "" + result.ToString();
                }
                else if (function == '*')
                {
                    result = firstNum * secondNum;
                    Textbalk.Text = result.ToString();
                    userinput = "" + result.ToString();
                }
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            een = "0";
            twee = "0";
            userinput = "0";
            Textbalk.Text = userinput.ToString();
        }

        private void btnPlusMin_Click_1(object sender, RoutedEventArgs e)
        {
            double antwoord;
            antwoord = Convert.ToDouble(userinput);
            result = antwoord *= -1;
            Textbalk.Text = result.ToString();
            userinput = result.ToString();
        }

        private void btnComma_Click_1(object sender, RoutedEventArgs e)
        {
            Textbalk.Text = "";
            userinput += ",";
            Textbalk.Text += userinput;

        }


    }
}


