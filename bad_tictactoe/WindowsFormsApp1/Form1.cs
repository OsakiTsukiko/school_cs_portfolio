using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool iend = false;
        bool turn = true;
        int s_x = 0;
        int s_y = 0;

        int check_row (int j)
        {
            int s = 0;
            for (int i = 1; i <= 3; i += 1)
            {
                Button a = (Button)panel1.Controls.Find("casuta_" + i + "_" + j, true)[0];
                if (a.Text == "X") s += 1;
                if (a.Text == "O") s -= 1;
            }
            if (s == -3) return -1;
            if (s == 3) return 1;
            return 0;
        }

        int check_col(int i)
        {
            int s = 0;
            for (int j = 1; j <= 3; j += 1)
            {
                Button a = (Button)panel1.Controls.Find("casuta_" + i + "_" + j, true)[0];
                if (a.Text == "X") s += 1;
                if (a.Text == "O") s -= 1;
            }
            if (s == -3) return -1;
            if (s == 3) return 1;
            return 0;
        }

        int check_d()
        {
            Button Z = (Button)panel1.Controls.Find("casuta_" + 2 + "_" + 2, true)[0];
            Button A11 = (Button)panel1.Controls.Find("casuta_" + 1 + "_" + 1, true)[0];
            Button A33 = (Button)panel1.Controls.Find("casuta_" + 3 + "_" + 3, true)[0];
            Button A13 = (Button)panel1.Controls.Find("casuta_" + 1 + "_" + 3, true)[0];
            Button A31 = (Button)panel1.Controls.Find("casuta_" + 3 + "_" + 1, true)[0];
            if (
                Z.Text == A11.Text && A11.Text == A33.Text ||
                Z.Text == A13.Text && A13.Text == A31.Text
                )
            {
                if (Z.Text == "X") return 1;
                if (Z.Text == "O") return -1;
                return 0;
            }

            return 0;
        }

        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        Button[,] casuta = new Button[4, 4];
        void newGame()
        {
            panel1.Controls.Clear();
            for (int i = 1; i <= 3; i += 1)
            {
                for (int j = 1; j <= 3; j += 1)
                {
                    casuta[i, j] = new Button();
                    casuta[i, j].Size = new Size(50, 50);
                    casuta[i, j].Left = i * 50 - 50;
                    casuta[i, j].Top = j * 50 - 50;
                    // casuta[i, j].Text = i + ", " + j;
                    casuta[i, j].Name = "casuta_" + i + "_" + j;
                    casuta[i, j].Click += new EventHandler(casuta_click);
                    panel1.Controls.Add(casuta[i, j]);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void casuta_click(object sender, EventArgs e)
        {
            Button apasat = (Button)sender;
            if (apasat.Text != "") return;
            int x = Convert.ToInt16(apasat.Name.Substring(7, 1));
            int y = Convert.ToInt16(apasat.Name.Substring(9, 1));
            Console.WriteLine(x + " " + y);
            apasat.Font = new Font("Arial", 20F);
            if (turn)
            {
                apasat.Text = "X";
                apasat.BackColor = Color.IndianRed;
                apasat.ForeColor = Color.RoyalBlue;
                // apasat.Enabled = false;
            } else
            {
                apasat.Text = "O";
                apasat.BackColor = Color.RoyalBlue;
                apasat.ForeColor = Color.IndianRed;
                // apasat.Enabled = false;
            }
            turn = !turn;
        }

        void XWIN()
        {
            if (iend) return;
            iend = true;
            s_x += 1;
            MessageBox.Show("X WINS");
            newGame();
            turn = true;
            iend = false;
        }

        void OWIN()
        {
            if (iend) return;
            iend = true;
            s_y += 1;
            MessageBox.Show("O WINS");
            newGame();
            turn = true;
            iend = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for ( int i = 1; i <= 3; i += 1 )
            {
                if (check_row(i) == 1)
                {
                    XWIN();
                }
                if (check_row(i) == -1)
                {
                    OWIN();
                }
                if (check_col(i) == 1)
                {
                    XWIN();
                }
                if (check_col(i) == -1)
                {
                    OWIN();
                }
                if (check_d() == 1)
                {
                    XWIN();
                }
                if (check_d() == -1)
                {
                    OWIN();
                }
            }
            label1.Text = "X: " + s_x + " | " + s_y + " :O";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newGame();
            turn = true;
        }
    }
}
