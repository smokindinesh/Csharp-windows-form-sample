namespace mathquiz
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
            this.Timelabel = new System.Windows.Forms.Label();
            this.LeftPluslabel = new System.Windows.Forms.Label();
            this.Pluslabel = new System.Windows.Forms.Label();
            this.RightPluslabel = new System.Windows.Forms.Label();
            this.Equal_label1 = new System.Windows.Forms.Label();
            this.LeftMinuslabel = new System.Windows.Forms.Label();
            this.Minuslabel = new System.Windows.Forms.Label();
            this.RightMinuslabel = new System.Windows.Forms.Label();
            this.Equal_lable2 = new System.Windows.Forms.Label();
            this.LeftMultilabel = new System.Windows.Forms.Label();
            this.Multilabel = new System.Windows.Forms.Label();
            this.RightMultilabel = new System.Windows.Forms.Label();
            this.Equal_lable3 = new System.Windows.Forms.Label();
            this.LeftDividelabel = new System.Windows.Forms.Label();
            this.Dividelabel = new System.Windows.Forms.Label();
            this.RightDividelable = new System.Windows.Forms.Label();
            this.Equal_lable4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timelable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(96, 38);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(95, 20);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "Time Left ";
            // 
            // LeftPluslabel
            // 
            this.LeftPluslabel.AutoSize = true;
            this.LeftPluslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftPluslabel.Location = new System.Drawing.Point(26, 102);
            this.LeftPluslabel.Name = "LeftPluslabel";
            this.LeftPluslabel.Size = new System.Drawing.Size(18, 20);
            this.LeftPluslabel.TabIndex = 2;
            this.LeftPluslabel.Text = "?";
            // 
            // Pluslabel
            // 
            this.Pluslabel.AutoSize = true;
            this.Pluslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pluslabel.Location = new System.Drawing.Point(97, 102);
            this.Pluslabel.Name = "Pluslabel";
            this.Pluslabel.Size = new System.Drawing.Size(18, 20);
            this.Pluslabel.TabIndex = 3;
            this.Pluslabel.Text = "+";
            // 
            // RightPluslabel
            // 
            this.RightPluslabel.AutoSize = true;
            this.RightPluslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightPluslabel.Location = new System.Drawing.Point(141, 102);
            this.RightPluslabel.Name = "RightPluslabel";
            this.RightPluslabel.Size = new System.Drawing.Size(18, 20);
            this.RightPluslabel.TabIndex = 4;
            this.RightPluslabel.Text = "?";
            // 
            // Equal_label1
            // 
            this.Equal_label1.AutoSize = true;
            this.Equal_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_label1.Location = new System.Drawing.Point(215, 102);
            this.Equal_label1.Name = "Equal_label1";
            this.Equal_label1.Size = new System.Drawing.Size(18, 20);
            this.Equal_label1.TabIndex = 5;
            this.Equal_label1.Text = "=";
            // 
            // LeftMinuslabel
            // 
            this.LeftMinuslabel.AutoSize = true;
            this.LeftMinuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMinuslabel.Location = new System.Drawing.Point(26, 161);
            this.LeftMinuslabel.Name = "LeftMinuslabel";
            this.LeftMinuslabel.Size = new System.Drawing.Size(18, 20);
            this.LeftMinuslabel.TabIndex = 6;
            this.LeftMinuslabel.Text = "?";
            // 
            // Minuslabel
            // 
            this.Minuslabel.AutoSize = true;
            this.Minuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minuslabel.Location = new System.Drawing.Point(97, 161);
            this.Minuslabel.Name = "Minuslabel";
            this.Minuslabel.Size = new System.Drawing.Size(14, 20);
            this.Minuslabel.TabIndex = 7;
            this.Minuslabel.Text = "-";
            // 
            // RightMinuslabel
            // 
            this.RightMinuslabel.AutoSize = true;
            this.RightMinuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightMinuslabel.Location = new System.Drawing.Point(141, 161);
            this.RightMinuslabel.Name = "RightMinuslabel";
            this.RightMinuslabel.Size = new System.Drawing.Size(18, 20);
            this.RightMinuslabel.TabIndex = 8;
            this.RightMinuslabel.Text = "?";
            // 
            // Equal_lable2
            // 
            this.Equal_lable2.AutoSize = true;
            this.Equal_lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_lable2.Location = new System.Drawing.Point(215, 159);
            this.Equal_lable2.Name = "Equal_lable2";
            this.Equal_lable2.Size = new System.Drawing.Size(18, 20);
            this.Equal_lable2.TabIndex = 9;
            this.Equal_lable2.Text = "=";
            // 
            // LeftMultilabel
            // 
            this.LeftMultilabel.AutoSize = true;
            this.LeftMultilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMultilabel.Location = new System.Drawing.Point(26, 216);
            this.LeftMultilabel.Name = "LeftMultilabel";
            this.LeftMultilabel.Size = new System.Drawing.Size(18, 20);
            this.LeftMultilabel.TabIndex = 10;
            this.LeftMultilabel.Text = "?";
            // 
            // Multilabel
            // 
            this.Multilabel.AutoSize = true;
            this.Multilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multilabel.Location = new System.Drawing.Point(96, 216);
            this.Multilabel.Name = "Multilabel";
            this.Multilabel.Size = new System.Drawing.Size(15, 20);
            this.Multilabel.TabIndex = 11;
            this.Multilabel.Text = "*";
            // 
            // RightMultilabel
            // 
            this.RightMultilabel.AutoSize = true;
            this.RightMultilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightMultilabel.Location = new System.Drawing.Point(141, 216);
            this.RightMultilabel.Name = "RightMultilabel";
            this.RightMultilabel.Size = new System.Drawing.Size(18, 20);
            this.RightMultilabel.TabIndex = 12;
            this.RightMultilabel.Text = "?";
            // 
            // Equal_lable3
            // 
            this.Equal_lable3.AutoSize = true;
            this.Equal_lable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_lable3.Location = new System.Drawing.Point(215, 216);
            this.Equal_lable3.Name = "Equal_lable3";
            this.Equal_lable3.Size = new System.Drawing.Size(18, 20);
            this.Equal_lable3.TabIndex = 13;
            this.Equal_lable3.Text = "=";
            // 
            // LeftDividelabel
            // 
            this.LeftDividelabel.AutoSize = true;
            this.LeftDividelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftDividelabel.Location = new System.Drawing.Point(26, 278);
            this.LeftDividelabel.Name = "LeftDividelabel";
            this.LeftDividelabel.Size = new System.Drawing.Size(18, 20);
            this.LeftDividelabel.TabIndex = 14;
            this.LeftDividelabel.Text = "?";
            // 
            // Dividelabel
            // 
            this.Dividelabel.AutoSize = true;
            this.Dividelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividelabel.Location = new System.Drawing.Point(96, 278);
            this.Dividelabel.Name = "Dividelabel";
            this.Dividelabel.Size = new System.Drawing.Size(13, 20);
            this.Dividelabel.TabIndex = 15;
            this.Dividelabel.Text = "/";
            // 
            // RightDividelable
            // 
            this.RightDividelable.AutoSize = true;
            this.RightDividelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightDividelable.Location = new System.Drawing.Point(141, 278);
            this.RightDividelable.Name = "RightDividelable";
            this.RightDividelable.Size = new System.Drawing.Size(18, 20);
            this.RightDividelable.TabIndex = 16;
            this.RightDividelable.Text = "?";
            // 
            // Equal_lable4
            // 
            this.Equal_lable4.AutoSize = true;
            this.Equal_lable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_lable4.Location = new System.Drawing.Point(215, 278);
            this.Equal_lable4.Name = "Equal_lable4";
            this.Equal_lable4.Size = new System.Drawing.Size(18, 20);
            this.Equal_lable4.TabIndex = 17;
            this.Equal_lable4.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(255, 100);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(91, 20);
            this.sum.TabIndex = 18;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(255, 159);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(91, 20);
            this.difference.TabIndex = 19;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(255, 209);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(91, 20);
            this.product.TabIndex = 20;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(255, 276);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(91, 20);
            this.quotient.TabIndex = 21;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // StartGameButton
            // 
            this.StartGameButton.AutoSize = true;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(255, 344);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(102, 34);
            this.StartGameButton.TabIndex = 22;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timelable
            // 
            this.Timelable.Location = new System.Drawing.Point(214, 43);
            this.Timelable.Name = "Timelable";
            this.Timelable.Size = new System.Drawing.Size(132, 23);
            this.Timelable.TabIndex = 23;
            this.Timelable.Text = "30 sec left";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 415);
            this.Controls.Add(this.Timelable);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Equal_lable4);
            this.Controls.Add(this.RightDividelable);
            this.Controls.Add(this.Dividelabel);
            this.Controls.Add(this.LeftDividelabel);
            this.Controls.Add(this.Equal_lable3);
            this.Controls.Add(this.RightMultilabel);
            this.Controls.Add(this.Multilabel);
            this.Controls.Add(this.LeftMultilabel);
            this.Controls.Add(this.Equal_lable2);
            this.Controls.Add(this.RightMinuslabel);
            this.Controls.Add(this.Minuslabel);
            this.Controls.Add(this.LeftMinuslabel);
            this.Controls.Add(this.Equal_label1);
            this.Controls.Add(this.RightPluslabel);
            this.Controls.Add(this.Pluslabel);
            this.Controls.Add(this.LeftPluslabel);
            this.Controls.Add(this.Timelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label LeftPluslabel;
        private System.Windows.Forms.Label Pluslabel;
        private System.Windows.Forms.Label RightPluslabel;
        private System.Windows.Forms.Label Equal_label1;
        private System.Windows.Forms.Label LeftMinuslabel;
        private System.Windows.Forms.Label Minuslabel;
        private System.Windows.Forms.Label RightMinuslabel;
        private System.Windows.Forms.Label Equal_lable2;
        private System.Windows.Forms.Label LeftMultilabel;
        private System.Windows.Forms.Label Multilabel;
        private System.Windows.Forms.Label RightMultilabel;
        private System.Windows.Forms.Label Equal_lable3;
        private System.Windows.Forms.Label LeftDividelabel;
        private System.Windows.Forms.Label Dividelabel;
        private System.Windows.Forms.Label RightDividelable;
        private System.Windows.Forms.Label Equal_lable4;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timelable;
    }
}

