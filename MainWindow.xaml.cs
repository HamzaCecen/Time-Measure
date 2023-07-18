using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Drawing;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Hour = 00;
        private int Min = 00;
        private int Seconds = 00;

        public MainWindow()
        {
            InitializeComponent();

            
           
            this.hh = Hour;
            this.mm = Min;
            this.ss = Seconds;
            

            testss.Text = "00";
            testmm.Text = "00";
            testhh.Text = "00";
            
            
        }
        

        
        public int hh { get; private set; }
        public int mm { get; private set; }
        public int ss { get; private set; }

        private void timer_tick(object sender, EventArgs e)
        {
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            //while(Hour == 24)
            ss++;
            testss.Text = ss.ToString();
            if (ss == 60)
            {
                mm++;
                testss.Text = "00";
                testmm.Text = mm.ToString();
                ss = 00;

                if (mm == 60)
                {
                    hh++;
                    testmm.Text = "00";
                    testhh.Text = hh.ToString();
                    mm = 00;
                }


                if (hh == 24)
                    testhh.Text = "00";


            }
            
        }
        

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("When the time is stopped: " + testhh.Text + ":" +  testmm.Text + ":" + testss.Text);


            ss = 00;
            testss.Text = ss.ToString();

            mm = 00;
            testmm.Text = mm.ToString();

            hh = 00;
            testhh.Text = hh.ToString();

        }
    }
    
}




/*
public int get_Hour()
{
    return Hour;

}

public void set_Hour(int hh)
{
    Hour = hh;
}

public int get_Seconds()
{
    return Seconds;
}
public void set_Seconds(int ss)
{
    this.ss = ss;
}
*/
