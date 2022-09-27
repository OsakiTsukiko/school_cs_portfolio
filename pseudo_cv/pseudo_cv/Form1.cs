using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pseudo_cv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string text = "";
            text += "First Name: " + fn.Text + "\n";
            text += "Last Name: " + ln.Text + "\n";
            text += "Studied Languages: \n";
            if (cb_en.Checked) text += "- " + cb_en.Text + "\n";
            if (cb_de.Checked) text += "- " + cb_de.Text + "\n";
            if (cb_jp.Checked) text += "- " + cb_jp.Text + "\n";
            if (cb_sp.Checked) text += "- " + cb_sp.Text + "\n";
            if (cb_fr.Checked) text += "- " + cb_fr.Text + "\n";
            if (cb_ar.Checked) text += "- " + cb_ar.Text + "\n";
            text += "Degree: ";
            if (rb_m.Checked) text += rb_m.Text;
            if (rb_e.Checked) text += rb_e.Text;
            if (rb_cs.Checked) text += rb_cs.Text;

            richTextBox1.Text = text;
        }
    }
}
