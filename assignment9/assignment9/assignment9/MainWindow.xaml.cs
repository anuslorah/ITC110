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

namespace assignment9
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

        private void save_Click(object sender, RoutedEventArgs e)
        {

            if (textBoxPath.Text != null)
            {
                try
                {
                    WriteFile note = new WriteFile(textBoxPath.Text);
                    note.AddText(textBox1.Text);
                    note.CloseFile();
                    MessageBox.Show("Your file was saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

         }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBoxPath.Text != null)
                    {
                    ReadFile doc = new ReadFile(textBoxPath.Text);
                    textBox1.Text = doc.GetFile();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBoxPath.Clear();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
            //most c based languages have this as keyword, deals with current window, also mainwindow.close
            //Application.Current.Shutdown(); closes everything
        }
    }//class
}//namespace
