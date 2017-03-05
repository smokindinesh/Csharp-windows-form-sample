namespace WindowsFormsApplication1
{
    partial class frmcalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.eql = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.off = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(99, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(99, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(57, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 27);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(99, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 27);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(57, 262);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 27);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(142, 110);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(26, 27);
            this.add.TabIndex = 10;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(145, 212);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(26, 27);
            this.multi.TabIndex = 11;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(12, 262);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(26, 27);
            this.dot.TabIndex = 12;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(142, 162);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(26, 27);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // eql
            // 
            this.eql.Location = new System.Drawing.Point(99, 262);
            this.eql.Name = "eql";
            this.eql.Size = new System.Drawing.Size(26, 27);
            this.eql.TabIndex = 14;
            this.eql.Text = "=";
            this.eql.UseVisualStyleBackColor = true;
            this.eql.Click += new System.EventHandler(this.eql_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(145, 262);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(26, 27);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.MaximumSize = new System.Drawing.Size(156, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(99, 65);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(29, 26);
            this.off.TabIndex = 17;
            this.off.Text = "off";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(142, 65);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(26, 26);
            this.clear.TabIndex = 18;
            this.clear.Text = "Ac";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 301);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.off);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.eql);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmcalculator";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button eql;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox textBox1;
        private int opMain = 0;
        private bool isfirst = false;
        private bool issecond = false;
        private double num1 = 0;
        private double num2 = 0;
        private double result;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button clear;
    }
}

