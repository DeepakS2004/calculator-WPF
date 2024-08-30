using System;
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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string oper = "";
        string firstnumber ="";
        string secondnumber = "";
        
        Arith arith = new Arith();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btnclick = (Button)sender;
            oper = btnclick.Content.ToString();
            txtresult.Text = oper.ToString();

        }
        private void btneql_Click(object sender, RoutedEventArgs e)
        {
            
            if (oper == "+")
            {
                 txtresult.Text = arith.Calculation(firstnumber,secondnumber,"+");
               
            }
            else if (oper == "-")
            {
                txtresult.Text = arith.Calculation(firstnumber, secondnumber, "-");
            }
            else if (oper == "*")
            {
                txtresult.Text = arith.Calculation(firstnumber, secondnumber, "*");
            }
            else if (oper == "/")
            {
                txtresult.Text = arith.Calculation(firstnumber, secondnumber, "/");
            }
            

        }

        private void num_Click(object sender, RoutedEventArgs e)
        {
            Button btnnum = (Button)sender;

            if (oper == "")
            {
                firstnumber = firstnumber + btnnum.Content;
                txtresult.Text = firstnumber.ToString() ; 
               
            }

           
            else
            {               
                secondnumber = secondnumber + btnnum.Content;
                txtresult.Text =   secondnumber.ToString();
            }
          

        }
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = "";
            secondnumber = "";
            txtresult.Text = "";
            oper = "";
        }

       
    }
}