using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace classroom_game
{
    public partial class Form1 : Form
    {
        PictureBox teacher = new PictureBox();
        int SPEED;

        public Form1()
        {
            InitializeComponent();
        }

        public void init_teacher()
        {
            teacher.Size = new Size(250, 250);
            teacher.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
