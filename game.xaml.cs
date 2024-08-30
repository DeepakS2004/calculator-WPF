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
    /// Interaction logic for game.xaml
    /// </summary>
    public partial class game : Window
    {
        int maxcount = 3;
        int count = 0;  
        public game()
        {
            InitializeComponent();
        }

        private void Btnstart_Click(object sender, RoutedEventArgs e)
        {
            spfirst.IsEnabled = true;
            spsecond.IsEnabled = true;
            spthird.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button value = (Button)sender;
            value.Content = value.Tag;
            int totalvalue = Convert.ToInt32(value.Content);
            if (totalvalue >100) 
            {
                value.Background = Brushes.PaleGoldenrod;            
            }
            else
            {
                value.Background= Brushes.IndianRed;
            }
            int prevvalue = Convert.ToInt32(lblamt.Content);
            prevvalue = prevvalue + totalvalue;
            lblamt.Content = prevvalue;
            count++;
            if (count == maxcount)
            {
                spfirst.IsEnabled=false;
                spsecond.IsEnabled=false;
                spthird .IsEnabled=false;
                string message = "GAME OVER , YOUR TOTAL PRICE : " + lblamt.Content;
                MessageBox.Show (message);
            }


        }
    }
}
