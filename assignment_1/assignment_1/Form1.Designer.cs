namespace assignment_1
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
            this.random = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.cb_3 = new System.Windows.Forms.CheckBox();
            this.cb_4 = new System.Windows.Forms.CheckBox();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.random.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.random.Location = new System.Drawing.Point(12, 9);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(261, 50);
            this.random.TabIndex = 0;
            this.random.Text = "Random No";
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cb_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_1.Location = new System.Drawing.Point(12, 72);
            this.cb_1.Name = "cb_1";
            this.cb_1.Padding = new System.Windows.Forms.Padding(2);
            this.cb_1.Size = new System.Drawing.Size(46, 21);
            this.cb_1.TabIndex = 1;
            this.cb_1.Text = "NR";
            this.cb_1.UseVisualStyleBackColor = false;
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cb_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_2.Location = new System.Drawing.Point(12, 101);
            this.cb_2.Name = "cb_2";
            this.cb_2.Padding = new System.Windows.Forms.Padding(2);
            this.cb_2.Size = new System.Drawing.Size(46, 21);
            this.cb_2.TabIndex = 2;
            this.cb_2.Text = "NR";
            this.cb_2.UseVisualStyleBackColor = false;
            // 
            // cb_3
            // 
            this.cb_3.AutoSize = true;
            this.cb_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cb_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_3.Location = new System.Drawing.Point(12, 130);
            this.cb_3.Name = "cb_3";
            this.cb_3.Padding = new System.Windows.Forms.Padding(2);
            this.cb_3.Size = new System.Drawing.Size(46, 21);
            this.cb_3.TabIndex = 3;
            this.cb_3.Text = "NR";
            this.cb_3.UseVisualStyleBackColor = false;
            // 
            // cb_4
            // 
            this.cb_4.AutoSize = true;
            this.cb_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cb_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_4.Location = new System.Drawing.Point(12, 159);
            this.cb_4.Name = "cb_4";
            this.cb_4.Padding = new System.Windows.Forms.Padding(2);
            this.cb_4.Size = new System.Drawing.Size(46, 21);
            this.cb_4.TabIndex = 4;
            this.cb_4.Text = "NR";
            this.cb_4.UseVisualStyleBackColor = false;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enter.Location = new System.Drawing.Point(201, 505);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(171, 44);
            this.enter.TabIndex = 5;
            this.enter.Text = "Checkout";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assignment_1.Properties.Resources.anime_math;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.cb_4);
            this.Controls.Add(this.cb_3);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.random);
            this.Name = "Form1";
            this.Text = "Math Game for Kids";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label random;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.CheckBox cb_3;
        private System.Windows.Forms.CheckBox cb_4;
        private System.Windows.Forms.Button enter;
    }
}

