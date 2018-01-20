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

namespace assignment8
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
        private void calculatetip_Click(object sender, RoutedEventArgs e)

        {
            Bill b = new assignment8.Bill();
            b.Amount = double.Parse(textBoxmealprice.Text);

            if (tip10.IsChecked == true)
            {
                b.TipPercent = 0.1;
            }
            else if (tip15.IsChecked == true)
            {
                b.TipPercent = 0.15;
            }
            else if (tip20.IsChecked == true)
            {
                b.TipPercent = 0.2;
            }
            else
            {
                b.TipPercent = double.Parse(textBoxtip.Text) / 100;
            }

            labeltotal.Content = "total with tax is: " + b.Total().ToString();
            
        }
        private void calculate_total_Click(object sender, RoutedEventArgs e)
        {
            Bill b = new assignment8.Bill();
            b.Amount = double.Parse(textBoxmealprice.Text);

            if (tip10.IsChecked == true)
            {
                b.TipPercent = 0.1;
            }
            else if (tip15.IsChecked == true)
            {
                b.TipPercent = 0.15;
            }
            else if (tip20.IsChecked == true)
            {
                b.TipPercent = 0.2;
            }
            else
            {
                b.TipPercent = double.Parse(textBoxtip.Text) / 100;
            }
            labeltotalwithtip.Content = b.TotalwithTip().ToString();
        }
    }
}//namespace
