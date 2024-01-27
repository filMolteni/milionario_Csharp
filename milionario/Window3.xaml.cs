using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace milionario
{
    /// <summary>
    /// Logica di interazione per Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent(); UserControlTimer t = new UserControlTimer();
            t.IsZero += T_IsZero;
            CDomande d = new CDomande();
            d.pag3();
            lblDomanda.Content = d.domanda;
            button1.Content = d.risp1;
            button2.Content = d.risp2;
            button3.Content = d.risp3;
            button4.Content = d.risp4;
        }

        private void T_IsZero(object sender, EventArgs e)
        {
            MessageBox.Show("tempo terminato");
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hai sbagliato ");
            Close();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hai sbagliato ");
            Close();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hai sbagliato ");
            Close();
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HAI VINTO");
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button2.IsEnabled = false;
            button3.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("la risposta potrebbe essere la D ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("votazioni dal pubblico: a 10%, b 20%, c 20%, d 50%");
        }
    }
}
