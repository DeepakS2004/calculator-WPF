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

namespace calculator
{
    /// <summary>
    /// Interaction logic for Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            txtusername.Text = txtusername.Text.Trim();
             
            string welcome= string.Format("Hi {0} Welcome \n Your company  {1}",txtusername.Text,pwbox.Text);
            MessageBox.Show(welcome);

            string wel = $"Hi {txtusername.Text} \n  Your Company {pwbox.Text}";
            MessageBox.Show(wel);


            StringBuilder ostring = new StringBuilder();
            ostring.Append("welcome");
            ostring.Append("to");
            for (int i = 0; i < 100;i++)
            {
                ostring.Append("JSQUARE "+ i.ToString());
            }
            MessageBox.Show(ostring.ToString());
            if(string.IsNullOrWhiteSpace( txtusername.Text))
            {
                lblerror.Visibility = Visibility.Visible;
                lblpwerror.Visibility = Visibility.Visible;
                lblerror.Content = "please enter user name ";
                lblpwerror.Content = "please enter password";
            }
            else
            {
                lblerror.Visibility = Visibility.Collapsed;
                lblpwerror.Visibility = Visibility.Collapsed;
            }

        }
    }
}
