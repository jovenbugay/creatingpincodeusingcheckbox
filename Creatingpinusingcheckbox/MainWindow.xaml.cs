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

namespace Creatingpinusingcheckbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numberOfCheckBoxChecked = 0;
        

        public MainWindow()
        {
            InitializeComponent();
            Check.Visibility = Visibility.Hidden;
            Wrong.Visibility = Visibility.Hidden;

        }
       
        private void Feature_Chcked(object sender, RoutedEventArgs e)
        {
            if ((checkBox1.IsChecked == true) && (checkBox2.IsChecked == true) && (checkBox3.IsChecked == true) && (checkBox4.IsChecked == false) && (checkBox5.IsChecked == false) && (checkBox6.IsChecked == false) && (checkBox7.IsChecked == false) && (checkBox8.IsChecked == false) && (checkBox9.IsChecked == false))
            {
                Answer.Content = "Correct Combination";
                numberOfCheckBoxChecked++;
                button1.Content = "Total Clicks: " + numberOfCheckBoxChecked;
                Check.Visibility = Visibility.Visible;
                Wrong.Visibility = Visibility.Hidden;

            }
            else
            {
                Answer.Content = "Wrong Combination";
                numberOfCheckBoxChecked++;
                button1.Content = "Total clicks: " + numberOfCheckBoxChecked;
                Wrong.Visibility = Visibility.Visible;
                Check.Visibility = Visibility.Hidden;


            }
        }
        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {



        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Total Clicks: " + "0";
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            checkBox3.IsChecked = false;
            checkBox4.IsChecked = false;
            checkBox5.IsChecked = false;
            checkBox6.IsChecked = false;
            checkBox7.IsChecked = false;
            checkBox8.IsChecked = false;
            checkBox9.IsChecked = false;
            numberOfCheckBoxChecked = 0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

    }
    }


