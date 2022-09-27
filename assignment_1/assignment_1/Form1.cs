using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        private int r_nr;
        private int half_rnr_1;
        private int half_rnr_2;

        public Form1()
        {
            InitializeComponent();

            r_nr = generator.Next(10, 21);
            half_rnr_1 = generator.Next(1, Math.Min(11, r_nr));
            half_rnr_2 = r_nr - half_rnr_1;

            random.Text = Convert.ToString(r_nr);

            int r1 = generator.Next(1, 5);
            int r2 = generator.Next(1, 5);
            while ( r1 == r2 )
            {
                r2 = generator.Next(1, 5);
            }

            if ( r1 == 1 ) {
                cb_1.Text = Convert.ToString(half_rnr_1);
            } else if ( r2 == 1 ) {
                cb_1.Text = Convert.ToString(half_rnr_2);
            } else {
                cb_1.Text = Convert.ToString(generator.Next(1, 10));
            }

            if (r1 == 2) {
                cb_2.Text = Convert.ToString(half_rnr_1);
            } else if (r2 == 2) {
                cb_2.Text = Convert.ToString(half_rnr_2);
            } else {
                cb_2.Text = Convert.ToString(generator.Next(1, 10));
            }

            if (r1 == 3) {
                cb_3.Text = Convert.ToString(half_rnr_1);
            } else if (r2 == 3) {
                cb_3.Text = Convert.ToString(half_rnr_2);
            } else {
                cb_3.Text = Convert.ToString(generator.Next(1, 10));
            }

            if (r1 == 4) {
                cb_4.Text = Convert.ToString(half_rnr_1);
            } else if (r2 == 4) {
                cb_4.Text = Convert.ToString(half_rnr_2);
            } else {
                cb_4.Text = Convert.ToString(generator.Next(1, 10));
            }

        }

        private void enter_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (cb_1.Checked) sum += Convert.ToInt32(cb_1.Text);
            if (cb_2.Checked) sum += Convert.ToInt32(cb_2.Text);
            if (cb_3.Checked) sum += Convert.ToInt32(cb_3.Text);
            if (cb_4.Checked) sum += Convert.ToInt32(cb_4.Text);
            if ( sum == r_nr )
            {
                DialogResult d = MessageBox.Show("YOU WON!", "CG!", MessageBoxButtons.OK);
                if ( d == DialogResult.OK )
                {
                    this.Close();
                }
            } else {
                DialogResult d = MessageBox.Show("WRONG! Maybe try again?", ":(", MessageBoxButtons.OK);
                if (d == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
