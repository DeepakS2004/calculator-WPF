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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        string Username = "Admin";
        string Password = "Admin";
        int maxtry = 3;
        int fail = 0;

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text == Username && pwbox.Password == Password)
            {
                MessageBox.Show("LOGIN SUCCESFULL", "JSSQUARE");
            }
            else
            {
                if (fail != 3)
                {
                    MessageBoxResult mresult1 = MessageBox.Show("LOGIN FAILED, DO YOU WANT TO RETRY ?",
                          "JSQUARE",
                          MessageBoxButton.YesNo,
                          MessageBoxImage.Question);
                    if (mresult1 == MessageBoxResult.Yes)
                    {
                        txtusername.Clear();
                        pwbox.Clear();
                        fail++;
                    }
                    else
                    {
                        this.Close();
                    }
                    if (fail == 2)
                    {
                        MessageBoxResult mresult = MessageBox.Show("LOGIN FAILED, THIS ONE LAST TRY DO YOU WANT TO TRY AGAIN ?",
                            "JSQUARE",
                            MessageBoxButton.OKCancel,
                            MessageBoxImage.Question);
                        if(mresult == MessageBoxResult.OK)
                        {
                            txtusername.Clear();
                            pwbox.Clear();
                            fail++;
                        }
                        else
                        {
                            this.Close();
                        }
                    }

                    
                }
              else
              {
                    MessageBox.Show("LOGIN FAILED, YOUR ACCOUNT IS LOCKED ?","JSQUARE");
                        this.Close();

              }

            }
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            Reg oref = new Reg();
            oref.Show();
        }
    }
}