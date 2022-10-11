using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_app
{
    public partial class Form1 : Form
    {
        int sec = 0;
        int min = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ( tmr.Enabled )
            {
                tmr.Enabled = false;
                btnStart.Text = "Start";
            } else
            {
                tmr.Enabled = true;
                btnStart.Text = "Stop";
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (sec == 60)
            {
                min += 1;
                sec = 0;
            }

            if (min == 60)
            {
                min = 0;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sec = 0;
            min = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String stime = "";

            if (min < 10)
            {
                stime += "0";
            }
            stime += min;
            stime += ":";
            if (sec < 10)
            {
                stime += "0";
            }
            stime += sec;
            lbl.Text = stime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
