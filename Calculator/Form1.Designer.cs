namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.input_txtbox = new System.Windows.Forms.TextBox();
            this.ac_btn = new System.Windows.Forms.Button();
            this.c_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.subt_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.eq_btn = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.input_txtbox);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 129);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.textBox1.Location = new System.Drawing.Point(16, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.prevnum_textbox);
            // 
            // input_txtbox
            // 
            this.input_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.input_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_txtbox.Enabled = false;
            this.input_txtbox.Font = new System.Drawing.Font("Product Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.input_txtbox.Location = new System.Drawing.Point(17, 55);
            this.input_txtbox.Name = "input_txtbox";
            this.input_txtbox.Size = new System.Drawing.Size(293, 59);
            this.input_txtbox.TabIndex = 0;
            this.input_txtbox.Text = "0";
            this.input_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_txtbox.TextChanged += new System.EventHandler(this.input_textbox);
            // 
            // ac_btn
            // 
            this.ac_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.ac_btn.FlatAppearance.BorderSize = 0;
            this.ac_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ac_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ac_btn.Location = new System.Drawing.Point(8, 138);
            this.ac_btn.Name = "ac_btn";
            this.ac_btn.Size = new System.Drawing.Size(60, 60);
            this.ac_btn.TabIndex = 1;
            this.ac_btn.Text = "AC";
            this.ac_btn.UseVisualStyleBackColor = false;
            this.ac_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_btn
            // 
            this.c_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.c_btn.FlatAppearance.BorderSize = 0;
            this.c_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.c_btn.Location = new System.Drawing.Point(88, 138);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(60, 60);
            this.c_btn.TabIndex = 2;
            this.c_btn.Text = "DEL";
            this.c_btn.UseVisualStyleBackColor = false;
            this.c_btn.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.mod_btn.FlatAppearance.BorderSize = 0;
            this.mod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mod_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.mod_btn.Location = new System.Drawing.Point(168, 138);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(60, 60);
            this.mod_btn.TabIndex = 3;
            this.mod_btn.Text = "%";
            this.mod_btn.UseVisualStyleBackColor = false;
            this.mod_btn.Click += new System.EventHandler(this.mod_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.div_btn.FlatAppearance.BorderSize = 0;
            this.div_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.div_btn.Location = new System.Drawing.Point(245, 138);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(60, 60);
            this.div_btn.TabIndex = 4;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = false;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // mult_btn
            // 
            this.mult_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.mult_btn.FlatAppearance.BorderSize = 0;
            this.mult_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mult_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.mult_btn.Location = new System.Drawing.Point(245, 214);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(60, 60);
            this.mult_btn.TabIndex = 5;
            this.mult_btn.Text = "x";
            this.mult_btn.UseVisualStyleBackColor = false;
            this.mult_btn.Click += new System.EventHandler(this.mult_btn_Click);
            // 
            // subt_btn
            // 
            this.subt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.subt_btn.FlatAppearance.BorderSize = 0;
            this.subt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subt_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subt_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.subt_btn.Location = new System.Drawing.Point(245, 290);
            this.subt_btn.Name = "subt_btn";
            this.subt_btn.Size = new System.Drawing.Size(60, 60);
            this.subt_btn.TabIndex = 6;
            this.subt_btn.Text = "-";
            this.subt_btn.UseVisualStyleBackColor = false;
            this.subt_btn.Click += new System.EventHandler(this.subt_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.add_btn.Location = new System.Drawing.Point(245, 366);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(60, 60);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // eq_btn
            // 
            this.eq_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.eq_btn.FlatAppearance.BorderSize = 0;
            this.eq_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eq_btn.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.eq_btn.Location = new System.Drawing.Point(168, 442);
            this.eq_btn.Name = "eq_btn";
            this.eq_btn.Size = new System.Drawing.Size(137, 60);
            this.eq_btn.TabIndex = 8;
            this.eq_btn.Text = "=";
            this.eq_btn.UseVisualStyleBackColor = false;
            this.eq_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.Color.White;
            this.num9.Location = new System.Drawing.Point(168, 214);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(60, 60);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.Color.White;
            this.num6.Location = new System.Drawing.Point(168, 290);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(60, 60);
            this.num6.TabIndex = 10;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.Color.White;
            this.num3.Location = new System.Drawing.Point(168, 366);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(60, 60);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(88, 366);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(60, 60);
            this.num2.TabIndex = 14;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.Color.White;
            this.num5.Location = new System.Drawing.Point(88, 290);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(60, 60);
            this.num5.TabIndex = 13;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.Color.White;
            this.num8.Location = new System.Drawing.Point(88, 214);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(60, 60);
            this.num8.TabIndex = 12;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.White;
            this.num1.Location = new System.Drawing.Point(8, 366);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(60, 60);
            this.num1.TabIndex = 17;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.Color.White;
            this.num4.Location = new System.Drawing.Point(8, 290);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(60, 60);
            this.num4.TabIndex = 16;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.Color.White;
            this.num7.Location = new System.Drawing.Point(8, 214);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(60, 60);
            this.num7.TabIndex = 15;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // period
            // 
            this.period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.period.FlatAppearance.BorderSize = 0;
            this.period.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.period.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.ForeColor = System.Drawing.Color.White;
            this.period.Location = new System.Drawing.Point(88, 442);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(60, 60);
            this.period.TabIndex = 18;
            this.period.Text = ".";
            this.period.UseVisualStyleBackColor = false;
            this.period.Click += new System.EventHandler(this.period_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.Color.White;
            this.num0.Location = new System.Drawing.Point(8, 442);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(60, 60);
            this.num0.TabIndex = 19;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(316, 514);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.period);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.eq_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.subt_btn);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.mod_btn);
            this.Controls.Add(this.c_btn);
            this.Controls.Add(this.ac_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcoolator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ac_btn;
        private System.Windows.Forms.Button c_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button mult_btn;
        private System.Windows.Forms.Button subt_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button eq_btn;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.TextBox input_txtbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

