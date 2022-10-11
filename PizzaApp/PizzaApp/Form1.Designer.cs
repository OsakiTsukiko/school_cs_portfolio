namespace PizzaApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.sc_s = new System.Windows.Forms.RadioButton();
            this.sc_m = new System.Windows.Forms.RadioButton();
            this.sc_l = new System.Windows.Forms.RadioButton();
            this.si_s = new System.Windows.Forms.TextBox();
            this.si_m = new System.Windows.Forms.TextBox();
            this.si_l = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ma_c = new System.Windows.Forms.TextBox();
            this.ma_p = new System.Windows.Forms.TextBox();
            this.ma_s = new System.Windows.Forms.TextBox();
            this.ct_s = new System.Windows.Forms.TextBox();
            this.ct_p = new System.Windows.Forms.TextBox();
            this.ct_c = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ei_1 = new System.Windows.Forms.CheckBox();
            this.ei_2 = new System.Windows.Forms.CheckBox();
            this.ei_3 = new System.Windows.Forms.CheckBox();
            this.ei_4 = new System.Windows.Forms.CheckBox();
            this.ei_5 = new System.Windows.Forms.CheckBox();
            this.ei_6 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ei = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_2_s = new System.Windows.Forms.TextBox();
            this.b_2_p = new System.Windows.Forms.TextBox();
            this.b_2_c = new System.Windows.Forms.TextBox();
            this.b_1_s = new System.Windows.Forms.TextBox();
            this.b_1_p = new System.Windows.Forms.TextBox();
            this.b_1_c = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.b_4_s = new System.Windows.Forms.TextBox();
            this.b_3_p = new System.Windows.Forms.TextBox();
            this.b_4_p = new System.Windows.Forms.TextBox();
            this.b_4_c = new System.Windows.Forms.TextBox();
            this.b_3_s = new System.Windows.Forms.TextBox();
            this.b_3_c = new System.Windows.Forms.TextBox();
            this.b_6_s = new System.Windows.Forms.TextBox();
            this.b_5_p = new System.Windows.Forms.TextBox();
            this.b_6_p = new System.Windows.Forms.TextBox();
            this.b_6_c = new System.Windows.Forms.TextBox();
            this.b_5_s = new System.Windows.Forms.TextBox();
            this.b_5_c = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tl = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_size.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_size
            // 
            this.gb_size.Controls.Add(this.si_l);
            this.gb_size.Controls.Add(this.sc_m);
            this.gb_size.Controls.Add(this.sc_l);
            this.gb_size.Controls.Add(this.si_m);
            this.gb_size.Controls.Add(this.si_s);
            this.gb_size.Controls.Add(this.sc_s);
            this.gb_size.Location = new System.Drawing.Point(12, 12);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(200, 107);
            this.gb_size.TabIndex = 0;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Marime";
            // 
            // sc_s
            // 
            this.sc_s.AutoSize = true;
            this.sc_s.Location = new System.Drawing.Point(6, 19);
            this.sc_s.Name = "sc_s";
            this.sc_s.Size = new System.Drawing.Size(48, 17);
            this.sc_s.TabIndex = 0;
            this.sc_s.TabStop = true;
            this.sc_s.Text = "Mica";
            this.sc_s.UseVisualStyleBackColor = true;
            // 
            // sc_m
            // 
            this.sc_m.AutoSize = true;
            this.sc_m.Location = new System.Drawing.Point(6, 45);
            this.sc_m.Name = "sc_m";
            this.sc_m.Size = new System.Drawing.Size(54, 17);
            this.sc_m.TabIndex = 1;
            this.sc_m.TabStop = true;
            this.sc_m.Text = "Medie";
            this.sc_m.UseVisualStyleBackColor = true;
            // 
            // sc_l
            // 
            this.sc_l.AutoSize = true;
            this.sc_l.Location = new System.Drawing.Point(6, 71);
            this.sc_l.Name = "sc_l";
            this.sc_l.Size = new System.Drawing.Size(49, 17);
            this.sc_l.TabIndex = 2;
            this.sc_l.TabStop = true;
            this.sc_l.Text = "Mare";
            this.sc_l.UseVisualStyleBackColor = true;
            // 
            // si_s
            // 
            this.si_s.BackColor = System.Drawing.SystemColors.Window;
            this.si_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.si_s.Location = new System.Drawing.Point(94, 16);
            this.si_s.Name = "si_s";
            this.si_s.ReadOnly = true;
            this.si_s.Size = new System.Drawing.Size(100, 20);
            this.si_s.TabIndex = 3;
            this.si_s.Text = "5.30";
            this.si_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // si_m
            // 
            this.si_m.BackColor = System.Drawing.SystemColors.Window;
            this.si_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.si_m.Location = new System.Drawing.Point(94, 42);
            this.si_m.Name = "si_m";
            this.si_m.ReadOnly = true;
            this.si_m.Size = new System.Drawing.Size(100, 20);
            this.si_m.TabIndex = 4;
            this.si_m.Text = "10.75";
            this.si_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // si_l
            // 
            this.si_l.BackColor = System.Drawing.SystemColors.Window;
            this.si_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.si_l.Location = new System.Drawing.Point(94, 68);
            this.si_l.Name = "si_l";
            this.si_l.ReadOnly = true;
            this.si_l.Size = new System.Drawing.Size(100, 20);
            this.si_l.TabIndex = 5;
            this.si_l.Text = "13.25";
            this.si_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ct_s);
            this.groupBox1.Controls.Add(this.ct_p);
            this.groupBox1.Controls.Add(this.ct_c);
            this.groupBox1.Controls.Add(this.ma_s);
            this.groupBox1.Controls.Add(this.ma_p);
            this.groupBox1.Controls.Add(this.ma_c);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meniuri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meniu Aripioare";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cartofi traditionali cu sos extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal";
            // 
            // ma_c
            // 
            this.ma_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ma_c.Location = new System.Drawing.Point(95, 39);
            this.ma_c.Name = "ma_c";
            this.ma_c.Size = new System.Drawing.Size(49, 20);
            this.ma_c.TabIndex = 5;
            this.ma_c.Text = "0";
            this.ma_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ma_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ma_c_KeyUp);
            // 
            // ma_p
            // 
            this.ma_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ma_p.Location = new System.Drawing.Point(150, 39);
            this.ma_p.Name = "ma_p";
            this.ma_p.ReadOnly = true;
            this.ma_p.Size = new System.Drawing.Size(81, 20);
            this.ma_p.TabIndex = 6;
            this.ma_p.Text = "14.00";
            this.ma_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ma_s
            // 
            this.ma_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ma_s.Location = new System.Drawing.Point(237, 39);
            this.ma_s.Name = "ma_s";
            this.ma_s.ReadOnly = true;
            this.ma_s.Size = new System.Drawing.Size(111, 20);
            this.ma_s.TabIndex = 7;
            this.ma_s.Text = "0.00";
            this.ma_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ct_s
            // 
            this.ct_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ct_s.Location = new System.Drawing.Point(237, 68);
            this.ct_s.Name = "ct_s";
            this.ct_s.ReadOnly = true;
            this.ct_s.Size = new System.Drawing.Size(111, 20);
            this.ct_s.TabIndex = 10;
            this.ct_s.Text = "0.00";
            this.ct_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ct_p
            // 
            this.ct_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ct_p.Location = new System.Drawing.Point(150, 68);
            this.ct_p.Name = "ct_p";
            this.ct_p.ReadOnly = true;
            this.ct_p.Size = new System.Drawing.Size(81, 20);
            this.ct_p.TabIndex = 9;
            this.ct_p.Text = "8.00";
            this.ct_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ct_c
            // 
            this.ct_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ct_c.Location = new System.Drawing.Point(95, 68);
            this.ct_c.Name = "ct_c";
            this.ct_c.Size = new System.Drawing.Size(49, 20);
            this.ct_c.TabIndex = 8;
            this.ct_c.Text = "0";
            this.ct_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ct_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ct_c_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ei);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ei_6);
            this.groupBox2.Controls.Add(this.ei_5);
            this.groupBox2.Controls.Add(this.ei_4);
            this.groupBox2.Controls.Add(this.ei_3);
            this.groupBox2.Controls.Add(this.ei_2);
            this.groupBox2.Controls.Add(this.ei_1);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 371);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Ingrediente";
            // 
            // ei_1
            // 
            this.ei_1.AutoSize = true;
            this.ei_1.Location = new System.Drawing.Point(6, 19);
            this.ei_1.Name = "ei_1";
            this.ei_1.Size = new System.Drawing.Size(100, 17);
            this.ei_1.TabIndex = 0;
            this.ei_1.Text = "Rosii Proaspete";
            this.ei_1.UseVisualStyleBackColor = true;
            // 
            // ei_2
            // 
            this.ei_2.AutoSize = true;
            this.ei_2.Location = new System.Drawing.Point(6, 42);
            this.ei_2.Name = "ei_2";
            this.ei_2.Size = new System.Drawing.Size(75, 17);
            this.ei_2.TabIndex = 1;
            this.ei_2.Text = "Ardei Gras";
            this.ei_2.UseVisualStyleBackColor = true;
            // 
            // ei_3
            // 
            this.ei_3.AutoSize = true;
            this.ei_3.Location = new System.Drawing.Point(6, 65);
            this.ei_3.Name = "ei_3";
            this.ei_3.Size = new System.Drawing.Size(115, 17);
            this.ei_3.TabIndex = 2;
            this.ei_3.Text = "Ciuperci Proaspete";
            this.ei_3.UseVisualStyleBackColor = true;
            // 
            // ei_4
            // 
            this.ei_4.AutoSize = true;
            this.ei_4.Location = new System.Drawing.Point(6, 88);
            this.ei_4.Name = "ei_4";
            this.ei_4.Size = new System.Drawing.Size(94, 17);
            this.ei_4.TabIndex = 3;
            this.ei_4.Text = "Masline Negre";
            this.ei_4.UseVisualStyleBackColor = true;
            // 
            // ei_5
            // 
            this.ei_5.AutoSize = true;
            this.ei_5.Location = new System.Drawing.Point(6, 111);
            this.ei_5.Name = "ei_5";
            this.ei_5.Size = new System.Drawing.Size(87, 17);
            this.ei_5.TabIndex = 4;
            this.ei_5.Text = "Ceapa Rosie";
            this.ei_5.UseVisualStyleBackColor = true;
            // 
            // ei_6
            // 
            this.ei_6.AutoSize = true;
            this.ei_6.Location = new System.Drawing.Point(6, 134);
            this.ei_6.Name = "ei_6";
            this.ei_6.Size = new System.Drawing.Size(62, 17);
            this.ei_6.TabIndex = 5;
            this.ei_6.Text = "Porumb";
            this.ei_6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pret/Ingredient";
            // 
            // ei
            // 
            this.ei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ei.Location = new System.Drawing.Point(113, 344);
            this.ei.Name = "ei";
            this.ei.ReadOnly = true;
            this.ei.Size = new System.Drawing.Size(81, 20);
            this.ei.TabIndex = 11;
            this.ei.Text = "1.50";
            this.ei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.b_6_s);
            this.groupBox3.Controls.Add(this.b_5_p);
            this.groupBox3.Controls.Add(this.b_6_p);
            this.groupBox3.Controls.Add(this.b_6_c);
            this.groupBox3.Controls.Add(this.b_5_s);
            this.groupBox3.Controls.Add(this.b_5_c);
            this.groupBox3.Controls.Add(this.b_4_s);
            this.groupBox3.Controls.Add(this.b_3_p);
            this.groupBox3.Controls.Add(this.b_4_p);
            this.groupBox3.Controls.Add(this.b_4_c);
            this.groupBox3.Controls.Add(this.b_3_s);
            this.groupBox3.Controls.Add(this.b_3_c);
            this.groupBox3.Controls.Add(this.b_2_s);
            this.groupBox3.Controls.Add(this.b_1_p);
            this.groupBox3.Controls.Add(this.b_2_p);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.b_2_c);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.b_1_s);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.b_1_c);
            this.groupBox3.Location = new System.Drawing.Point(218, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 371);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bauturi";
            // 
            // b_2_s
            // 
            this.b_2_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_2_s.Location = new System.Drawing.Point(237, 71);
            this.b_2_s.Name = "b_2_s";
            this.b_2_s.ReadOnly = true;
            this.b_2_s.Size = new System.Drawing.Size(111, 20);
            this.b_2_s.TabIndex = 19;
            this.b_2_s.Text = "0.00";
            this.b_2_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_2_p
            // 
            this.b_2_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_2_p.Location = new System.Drawing.Point(150, 71);
            this.b_2_p.Name = "b_2_p";
            this.b_2_p.ReadOnly = true;
            this.b_2_p.Size = new System.Drawing.Size(81, 20);
            this.b_2_p.TabIndex = 18;
            this.b_2_p.Text = "1.50";
            this.b_2_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_2_c
            // 
            this.b_2_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_2_c.Location = new System.Drawing.Point(95, 71);
            this.b_2_c.Name = "b_2_c";
            this.b_2_c.Size = new System.Drawing.Size(49, 20);
            this.b_2_c.TabIndex = 17;
            this.b_2_c.Text = "0";
            this.b_2_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_2_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_2_c_KeyUp);
            // 
            // b_1_s
            // 
            this.b_1_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_1_s.Location = new System.Drawing.Point(237, 42);
            this.b_1_s.Name = "b_1_s";
            this.b_1_s.ReadOnly = true;
            this.b_1_s.Size = new System.Drawing.Size(111, 20);
            this.b_1_s.TabIndex = 16;
            this.b_1_s.Text = "0.00";
            this.b_1_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_1_p
            // 
            this.b_1_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_1_p.Location = new System.Drawing.Point(150, 42);
            this.b_1_p.Name = "b_1_p";
            this.b_1_p.ReadOnly = true;
            this.b_1_p.Size = new System.Drawing.Size(81, 20);
            this.b_1_p.TabIndex = 15;
            this.b_1_p.Text = "1.50";
            this.b_1_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_1_c
            // 
            this.b_1_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_1_c.Location = new System.Drawing.Point(95, 42);
            this.b_1_c.Name = "b_1_c";
            this.b_1_c.Size = new System.Drawing.Size(49, 20);
            this.b_1_c.TabIndex = 14;
            this.b_1_c.Text = "0";
            this.b_1_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_1_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_1_c_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pret";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cant";
            // 
            // b_4_s
            // 
            this.b_4_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_4_s.Location = new System.Drawing.Point(237, 126);
            this.b_4_s.Name = "b_4_s";
            this.b_4_s.ReadOnly = true;
            this.b_4_s.Size = new System.Drawing.Size(111, 20);
            this.b_4_s.TabIndex = 25;
            this.b_4_s.Text = "0.00";
            this.b_4_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_3_p
            // 
            this.b_3_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_3_p.Location = new System.Drawing.Point(150, 97);
            this.b_3_p.Name = "b_3_p";
            this.b_3_p.ReadOnly = true;
            this.b_3_p.Size = new System.Drawing.Size(81, 20);
            this.b_3_p.TabIndex = 21;
            this.b_3_p.Text = "3.00";
            this.b_3_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_4_p
            // 
            this.b_4_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_4_p.Location = new System.Drawing.Point(150, 126);
            this.b_4_p.Name = "b_4_p";
            this.b_4_p.ReadOnly = true;
            this.b_4_p.Size = new System.Drawing.Size(81, 20);
            this.b_4_p.TabIndex = 24;
            this.b_4_p.Text = "3.00";
            this.b_4_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_4_c
            // 
            this.b_4_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_4_c.Location = new System.Drawing.Point(95, 126);
            this.b_4_c.Name = "b_4_c";
            this.b_4_c.Size = new System.Drawing.Size(49, 20);
            this.b_4_c.TabIndex = 23;
            this.b_4_c.Text = "0";
            this.b_4_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_4_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_4_c_KeyUp);
            // 
            // b_3_s
            // 
            this.b_3_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_3_s.Location = new System.Drawing.Point(237, 97);
            this.b_3_s.Name = "b_3_s";
            this.b_3_s.ReadOnly = true;
            this.b_3_s.Size = new System.Drawing.Size(111, 20);
            this.b_3_s.TabIndex = 22;
            this.b_3_s.Text = "0.00";
            this.b_3_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_3_c
            // 
            this.b_3_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_3_c.Location = new System.Drawing.Point(95, 97);
            this.b_3_c.Name = "b_3_c";
            this.b_3_c.Size = new System.Drawing.Size(49, 20);
            this.b_3_c.TabIndex = 20;
            this.b_3_c.Text = "0";
            this.b_3_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_3_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_3_c_KeyUp);
            // 
            // b_6_s
            // 
            this.b_6_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_6_s.Location = new System.Drawing.Point(237, 181);
            this.b_6_s.Name = "b_6_s";
            this.b_6_s.ReadOnly = true;
            this.b_6_s.Size = new System.Drawing.Size(111, 20);
            this.b_6_s.TabIndex = 31;
            this.b_6_s.Text = "0.00";
            this.b_6_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_5_p
            // 
            this.b_5_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_5_p.Location = new System.Drawing.Point(150, 152);
            this.b_5_p.Name = "b_5_p";
            this.b_5_p.ReadOnly = true;
            this.b_5_p.Size = new System.Drawing.Size(81, 20);
            this.b_5_p.TabIndex = 27;
            this.b_5_p.Text = "3.00";
            this.b_5_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_6_p
            // 
            this.b_6_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_6_p.Location = new System.Drawing.Point(150, 181);
            this.b_6_p.Name = "b_6_p";
            this.b_6_p.ReadOnly = true;
            this.b_6_p.Size = new System.Drawing.Size(81, 20);
            this.b_6_p.TabIndex = 30;
            this.b_6_p.Text = "2.00";
            this.b_6_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_6_c
            // 
            this.b_6_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_6_c.Location = new System.Drawing.Point(95, 181);
            this.b_6_c.Name = "b_6_c";
            this.b_6_c.Size = new System.Drawing.Size(49, 20);
            this.b_6_c.TabIndex = 29;
            this.b_6_c.Text = "0";
            this.b_6_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_6_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_6_c_KeyUp);
            // 
            // b_5_s
            // 
            this.b_5_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_5_s.Location = new System.Drawing.Point(237, 152);
            this.b_5_s.Name = "b_5_s";
            this.b_5_s.ReadOnly = true;
            this.b_5_s.Size = new System.Drawing.Size(111, 20);
            this.b_5_s.TabIndex = 28;
            this.b_5_s.Text = "0.00";
            this.b_5_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_5_c
            // 
            this.b_5_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_5_c.Location = new System.Drawing.Point(95, 152);
            this.b_5_c.Name = "b_5_c";
            this.b_5_c.Size = new System.Drawing.Size(49, 20);
            this.b_5_c.TabIndex = 26;
            this.b_5_c.Text = "0";
            this.b_5_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_5_c.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_5_c_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Apa Plata";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Apa Minerala";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Coca-Cola";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Fanta";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(9, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 29);
            this.label14.TabIndex = 36;
            this.label14.Text = "Suc Natural De Fructe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Cafea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaApp.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(229, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.Location = new System.Drawing.Point(382, 499);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(73, 13);
            this.tl.TabIndex = 38;
            this.tl.Text = "Total de Plata";
            // 
            // tp
            // 
            this.tp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tp.Location = new System.Drawing.Point(461, 497);
            this.tp.Name = "tp";
            this.tp.ReadOnly = true;
            this.tp.Size = new System.Drawing.Size(111, 20);
            this.tp.TabIndex = 38;
            this.tp.Text = "0.00";
            this.tp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 526);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 39;
            this.cancel.Text = "Anulare";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Iesire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_size);
            this.Name = "Form1";
            this.Text = "Tony Pizza";
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.RadioButton sc_l;
        private System.Windows.Forms.RadioButton sc_m;
        private System.Windows.Forms.RadioButton sc_s;
        private System.Windows.Forms.TextBox si_s;
        private System.Windows.Forms.TextBox si_l;
        private System.Windows.Forms.TextBox si_m;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ma_s;
        private System.Windows.Forms.TextBox ma_p;
        private System.Windows.Forms.TextBox ma_c;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ct_s;
        private System.Windows.Forms.TextBox ct_p;
        private System.Windows.Forms.TextBox ct_c;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ei;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ei_6;
        private System.Windows.Forms.CheckBox ei_5;
        private System.Windows.Forms.CheckBox ei_4;
        private System.Windows.Forms.CheckBox ei_3;
        private System.Windows.Forms.CheckBox ei_2;
        private System.Windows.Forms.CheckBox ei_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox b_6_s;
        private System.Windows.Forms.TextBox b_5_p;
        private System.Windows.Forms.TextBox b_6_p;
        private System.Windows.Forms.TextBox b_6_c;
        private System.Windows.Forms.TextBox b_5_s;
        private System.Windows.Forms.TextBox b_5_c;
        private System.Windows.Forms.TextBox b_4_s;
        private System.Windows.Forms.TextBox b_3_p;
        private System.Windows.Forms.TextBox b_4_p;
        private System.Windows.Forms.TextBox b_4_c;
        private System.Windows.Forms.TextBox b_3_s;
        private System.Windows.Forms.TextBox b_3_c;
        private System.Windows.Forms.TextBox b_2_s;
        private System.Windows.Forms.TextBox b_1_p;
        private System.Windows.Forms.TextBox b_2_p;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox b_2_c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox b_1_s;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox b_1_c;
        private System.Windows.Forms.Label tl;
        private System.Windows.Forms.TextBox tp;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button1;
    }
}

