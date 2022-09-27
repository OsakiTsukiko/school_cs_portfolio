namespace calculator
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
            this.nr_1 = new System.Windows.Forms.TextBox();
            this.nr_2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_times = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // nr_1
            // 
            this.nr_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr_1.Location = new System.Drawing.Point(32, 89);
            this.nr_1.Name = "nr_1";
            this.nr_1.Size = new System.Drawing.Size(195, 20);
            this.nr_1.TabIndex = 1;
            this.nr_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nr_2
            // 
            this.nr_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr_2.Location = new System.Drawing.Point(32, 115);
            this.nr_2.Name = "nr_2";
            this.nr_2.Size = new System.Drawing.Size(195, 20);
            this.nr_2.TabIndex = 2;
            this.nr_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::calculator.Properties.Resources.ani_math;
            this.pictureBox1.Location = new System.Drawing.Point(384, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(32, 141);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(30, 30);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(68, 141);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(30, 30);
            this.btn_minus.TabIndex = 5;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_times
            // 
            this.btn_times.Location = new System.Drawing.Point(161, 141);
            this.btn_times.Name = "btn_times";
            this.btn_times.Size = new System.Drawing.Size(30, 30);
            this.btn_times.TabIndex = 6;
            this.btn_times.Text = "x";
            this.btn_times.UseVisualStyleBackColor = true;
            this.btn_times.Click += new System.EventHandler(this.btn_times_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(197, 141);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(30, 30);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(32, 177);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(195, 20);
            this.result.TabIndex = 8;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_times);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nr_2);
            this.Controls.Add(this.nr_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nr_1;
        private System.Windows.Forms.TextBox nr_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_times;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.TextBox result;
    }
}

