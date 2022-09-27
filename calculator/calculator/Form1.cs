using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void do_action(calc_action ac)
        {
            string n1 = nr_1.Text;
            string n2 = nr_2.Text;
            double dn1;
            double dn2;
            try
            {
                dn1 = Convert.ToDouble(n1);
                dn2 = Convert.ToDouble(n2);
            } catch
            {
                MessageBox.Show("(╯°□°)╯︵ ┻━┻ ONLY NUMBERS BITCH!", ">:C", MessageBoxButtons.OK);
                return;
            }
            
            double dn3 = 0;

            if ( ac == calc_action.PLUS ) {
                dn3 = dn1 + dn2;
            } else if ( ac == calc_action.MINUS ) {
                dn3 = dn1 - dn2;
            } else if ( ac == calc_action.TIMES ) {
                dn3 = dn1 * dn2;
            } else if ( ac == calc_action.DIV ) {
                dn3 = dn1 / dn2;
            }

            result.Text = Convert.ToString(dn3);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            do_action(calc_action.PLUS);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            do_action(calc_action.MINUS);
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            do_action(calc_action.TIMES);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            do_action(calc_action.DIV);
        }

        enum calc_action
        {
            PLUS,
            MINUS,
            TIMES,
            DIV
        }
    }
}
