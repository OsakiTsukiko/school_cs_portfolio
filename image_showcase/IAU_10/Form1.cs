using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAU_10
{
    public partial class Form1 : Form
    {

        Image megamind = Properties.Resources.megamind;
        Image apple = Properties.Resources.apple;
        Image banana = Properties.Resources.banana;
        Image strawberry = Properties.Resources.strawberry;

        public Form1()
        {
            InitializeComponent();
            photo.Image = megamind;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(">.<, Do you really want to leave? ;-;", ";-;", MessageBoxButtons.YesNo);
            if ( res == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            photo.Image = apple;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            photo.Image = banana;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            photo.Image = strawberry;
        }
    }
}
