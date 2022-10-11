using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ma_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(ma_p.Text);
                cant = Convert.ToDouble(ma_c.Text);
            } catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            ma_s.Text = Convert.ToString(s);
            
        }

        private void ct_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(ct_p.Text);
                cant = Convert.ToDouble(ct_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            ct_s.Text = Convert.ToString(s);
        }

        private void b_1_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(b_1_p.Text);
                cant = Convert.ToDouble(b_1_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            b_1_s.Text = Convert.ToString(s);
        }

        private void b_2_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(b_2_p.Text);
                cant = Convert.ToDouble(b_2_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            b_2_s.Text = Convert.ToString(s);
        }

        private void b_3_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(b_3_p.Text);
                cant = Convert.ToDouble(b_3_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            b_3_s.Text = Convert.ToString(s);
        }

        private void b_4_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(b_4_p.Text);
                cant = Convert.ToDouble(b_4_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            b_4_s.Text = Convert.ToString(s);
        }

        private void b_5_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(b_5_p.Text);
                cant = Convert.ToDouble(b_5_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            b_5_s.Text = Convert.ToString(s);
        }

        private void b_6_c_KeyUp(object sender, KeyEventArgs e)
        {
            double price;
            double cant;
            try
            {
                price = Convert.ToDouble(b_6_p.Text);
                cant = Convert.ToDouble(b_6_c.Text);
            }
            catch
            {
                return;
            }

            double sub = price * cant;
            String s = String.Format("{0:0.00}", sub);
            b_6_s.Text = Convert.ToString(s);
        }

        public void total()
        {
            double tot = 0.0;
               
            if ( sc_s.Checked )
            {
                tot += Convert.ToDouble(si_s.Text);
            }

            if (sc_m.Checked)
            {
                tot += Convert.ToDouble(si_m.Text);
            }

            if (sc_l.Checked)
            {
                tot += Convert.ToDouble(si_l.Text);
            }

            tot += Convert.ToDouble(ma_s.Text);
            tot += Convert.ToDouble(ct_s.Text);

            double ei_c = Convert.ToDouble(ei.Text);

            if (ei_1.Checked) { tot += ei_c; }
            if (ei_2.Checked) { tot += ei_c; }
            if (ei_3.Checked) { tot += ei_c; }
            if (ei_4.Checked) { tot += ei_c; }
            if (ei_5.Checked) { tot += ei_c; }
            if (ei_6.Checked) { tot += ei_c; }

            tot += Convert.ToDouble(b_1_s.Text);
            tot += Convert.ToDouble(b_2_s.Text);
            tot += Convert.ToDouble(b_3_s.Text);
            tot += Convert.ToDouble(b_4_s.Text);
            tot += Convert.ToDouble(b_5_s.Text);
            tot += Convert.ToDouble(b_6_s.Text);


            String s = String.Format("{0:0.00}", tot);
            tp.Text = Convert.ToString(s);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            total();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            sc_s.Checked = true;
            ma_c.Text = "0";
            ct_c.Text = "0";
            ma_s.Text = "0.0";
            ct_s.Text = "0.0";

            ei_1.Checked = false;
            ei_2.Checked = false;
            ei_3.Checked = false;
            ei_4.Checked = false;
            ei_5.Checked = false;
            ei_6.Checked = false;


            b_1_c.Text = "0";
            b_2_c.Text = "0";
            b_3_c.Text = "0";
            b_4_c.Text = "0";
            b_5_c.Text = "0";
            b_6_c.Text = "0";

            b_1_s.Text = "0.0";
            b_2_s.Text = "0.0";
            b_3_s.Text = "0.0";
            b_4_s.Text = "0.0";
            b_5_s.Text = "0.0";
            b_6_s.Text = "0.0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esti sigur ca vrei sa iesi?", "Iesi", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
