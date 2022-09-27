namespace pseudo_cv
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
            this.label1 = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_en = new System.Windows.Forms.CheckBox();
            this.cb_de = new System.Windows.Forms.CheckBox();
            this.cb_jp = new System.Windows.Forms.CheckBox();
            this.cb_ar = new System.Windows.Forms.CheckBox();
            this.cb_sp = new System.Windows.Forms.CheckBox();
            this.cb_fr = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_m = new System.Windows.Forms.RadioButton();
            this.rb_e = new System.Windows.Forms.RadioButton();
            this.rb_cs = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enter = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // ln
            // 
            this.ln.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ln.Location = new System.Drawing.Point(76, 36);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(301, 20);
            this.ln.TabIndex = 1;
            // 
            // fn
            // 
            this.fn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fn.Location = new System.Drawing.Point(76, 10);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(301, 20);
            this.fn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_fr);
            this.groupBox1.Controls.Add(this.cb_sp);
            this.groupBox1.Controls.Add(this.cb_ar);
            this.groupBox1.Controls.Add(this.cb_jp);
            this.groupBox1.Controls.Add(this.cb_de);
            this.groupBox1.Controls.Add(this.cb_en);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studied Languages";
            // 
            // cb_en
            // 
            this.cb_en.AutoSize = true;
            this.cb_en.Location = new System.Drawing.Point(188, 19);
            this.cb_en.Name = "cb_en";
            this.cb_en.Size = new System.Drawing.Size(60, 17);
            this.cb_en.TabIndex = 0;
            this.cb_en.Text = "English";
            this.cb_en.UseVisualStyleBackColor = true;
            // 
            // cb_de
            // 
            this.cb_de.AutoSize = true;
            this.cb_de.Location = new System.Drawing.Point(188, 42);
            this.cb_de.Name = "cb_de";
            this.cb_de.Size = new System.Drawing.Size(63, 17);
            this.cb_de.TabIndex = 1;
            this.cb_de.Text = "German";
            this.cb_de.UseVisualStyleBackColor = true;
            // 
            // cb_jp
            // 
            this.cb_jp.AutoSize = true;
            this.cb_jp.Location = new System.Drawing.Point(188, 65);
            this.cb_jp.Name = "cb_jp";
            this.cb_jp.Size = new System.Drawing.Size(72, 17);
            this.cb_jp.TabIndex = 2;
            this.cb_jp.Text = "Japanese";
            this.cb_jp.UseVisualStyleBackColor = true;
            // 
            // cb_ar
            // 
            this.cb_ar.AutoSize = true;
            this.cb_ar.Location = new System.Drawing.Point(274, 65);
            this.cb_ar.Name = "cb_ar";
            this.cb_ar.Size = new System.Drawing.Size(56, 17);
            this.cb_ar.TabIndex = 3;
            this.cb_ar.Text = "Arabic";
            this.cb_ar.UseVisualStyleBackColor = true;
            // 
            // cb_sp
            // 
            this.cb_sp.AutoSize = true;
            this.cb_sp.Location = new System.Drawing.Point(274, 19);
            this.cb_sp.Name = "cb_sp";
            this.cb_sp.Size = new System.Drawing.Size(64, 17);
            this.cb_sp.TabIndex = 4;
            this.cb_sp.Text = "Spanish";
            this.cb_sp.UseVisualStyleBackColor = true;
            // 
            // cb_fr
            // 
            this.cb_fr.AutoSize = true;
            this.cb_fr.Location = new System.Drawing.Point(274, 42);
            this.cb_fr.Name = "cb_fr";
            this.cb_fr.Size = new System.Drawing.Size(59, 17);
            this.cb_fr.TabIndex = 5;
            this.cb_fr.Text = "French";
            this.cb_fr.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_cs);
            this.groupBox2.Controls.Add(this.rb_e);
            this.groupBox2.Controls.Add(this.rb_m);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Degree";
            // 
            // rb_m
            // 
            this.rb_m.AutoSize = true;
            this.rb_m.Location = new System.Drawing.Point(227, 19);
            this.rb_m.Name = "rb_m";
            this.rb_m.Size = new System.Drawing.Size(85, 17);
            this.rb_m.TabIndex = 0;
            this.rb_m.TabStop = true;
            this.rb_m.Text = "Mathematics";
            this.rb_m.UseVisualStyleBackColor = true;
            // 
            // rb_e
            // 
            this.rb_e.AutoSize = true;
            this.rb_e.Location = new System.Drawing.Point(227, 42);
            this.rb_e.Name = "rb_e";
            this.rb_e.Size = new System.Drawing.Size(59, 17);
            this.rb_e.TabIndex = 1;
            this.rb_e.TabStop = true;
            this.rb_e.Text = "English";
            this.rb_e.UseVisualStyleBackColor = true;
            // 
            // rb_cs
            // 
            this.rb_cs.AutoSize = true;
            this.rb_cs.Location = new System.Drawing.Point(227, 65);
            this.rb_cs.Name = "rb_cs";
            this.rb_cs.Size = new System.Drawing.Size(112, 17);
            this.rb_cs.TabIndex = 2;
            this.rb_cs.TabStop = true;
            this.rb_cs.Text = "Computer Science";
            this.rb_cs.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::pseudo_cv.Properties.Resources.makise;
            this.pictureBox1.Location = new System.Drawing.Point(579, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(12, 299);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(365, 23);
            this.enter.TabIndex = 8;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_fr;
        private System.Windows.Forms.CheckBox cb_sp;
        private System.Windows.Forms.CheckBox cb_ar;
        private System.Windows.Forms.CheckBox cb_jp;
        private System.Windows.Forms.CheckBox cb_de;
        private System.Windows.Forms.CheckBox cb_en;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_e;
        private System.Windows.Forms.RadioButton rb_m;
        private System.Windows.Forms.RadioButton rb_cs;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

