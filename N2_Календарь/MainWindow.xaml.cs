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

namespace N2_Календарь
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pass = "4444";
            if (TB1.Text == pass)
            {
                LB1.Visibility = Visibility.Visible;
                LB2.Visibility = Visibility.Visible;
                LB5.Visibility = Visibility.Visible;
                B9.Visibility = Visibility.Visible;
                B3.Visibility = Visibility.Visible;
                TB2.Visibility = Visibility.Visible;
                LB3.Visibility = Visibility.Visible;
                B4.Visibility = Visibility.Visible;
                TB8.Visibility = Visibility.Visible;
                LB4.Visibility = Visibility.Visible;
                B5.Visibility = Visibility.Visible;
                D1.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Hidden;
                TB1.Visibility = Visibility.Hidden;
                LB0.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LB5.IsEnabled = true;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            TB8.AppendText(TB2.Text + Environment.NewLine);
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ListBoxItem)LB5.SelectedItem).Content.ToString();
            TB8.AppendText(text + Environment.NewLine);
        }
    }
}
