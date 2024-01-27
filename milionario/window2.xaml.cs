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
    /// Logica di interazione per window2.xaml
    /// </summary>
    public partial class window2 : Window
    {
        public window2()
        {
            InitializeComponent();
            UserControlTimer t = new UserControlTimer();
            t.IsZero += T_IsZero;
            CDomande d = new CDomande();
            d.pag2();
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
            Window3 w3 = new Window3();
            w3.Show();
            Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hai sbagliato ");
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = false;
            button4.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("la risposta potrebbe essere la C ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("votazioni dal pubblico: a 10%, b 20%, c 50%, d 20%");
        }
    }
}
