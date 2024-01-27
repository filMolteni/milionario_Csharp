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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace milionario
{

    public partial class UserControlTimer : UserControl
    {

        private DispatcherTimer timer = new DispatcherTimer();
        private int tempo = 15;
        public UserControlTimer()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick; ;
            timer.Start();
        }
        public delegate void IsZeroEventHandler(object sender, EventArgs e);
        public event IsZeroEventHandler IsZero;

        public void Timer_Tick(object sender, EventArgs e)
        {
            tempo--;
            txtTempo.Text = tempo.ToString();
            if (tempo == 0)
            {
                timer.Stop();
                if (IsZero != null) IsZero(this, e);

            }

             
        }
       
}
}
