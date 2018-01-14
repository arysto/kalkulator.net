namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textbox = new System.Windows.Forms.TextBox();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textbox.Location = new System.Drawing.Point(8, 23);
            this.textbox.Margin = new System.Windows.Forms.Padding(2);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(271, 35);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "0";
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number7.Location = new System.Drawing.Point(8, 62);
            this.number7.Margin = new System.Windows.Forms.Padding(2);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(65, 65);
            this.number7.TabIndex = 1;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number8.Location = new System.Drawing.Point(77, 62);
            this.number8.Margin = new System.Windows.Forms.Padding(2);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(65, 65);
            this.number8.TabIndex = 2;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number9.Location = new System.Drawing.Point(146, 62);
            this.number9.Margin = new System.Windows.Forms.Padding(2);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(65, 65);
            this.number9.TabIndex = 3;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number4.Location = new System.Drawing.Point(8, 131);
            this.number4.Margin = new System.Windows.Forms.Padding(2);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(65, 65);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number5.Location = new System.Drawing.Point(77, 131);
            this.number5.Margin = new System.Windows.Forms.Padding(2);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(65, 65);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number6.Location = new System.Drawing.Point(146, 131);
            this.number6.Margin = new System.Windows.Forms.Padding(2);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(65, 65);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number3.Location = new System.Drawing.Point(146, 200);
            this.number3.Margin = new System.Windows.Forms.Padding(2);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(65, 65);
            this.number3.TabIndex = 9;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number2.Location = new System.Drawing.Point(77, 200);
            this.number2.Margin = new System.Windows.Forms.Padding(2);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(65, 65);
            this.number2.TabIndex = 8;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number1.Location = new System.Drawing.Point(8, 200);
            this.number1.Margin = new System.Windows.Forms.Padding(2);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(65, 65);
            this.number1.TabIndex = 7;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.sum.Location = new System.Drawing.Point(146, 269);
            this.sum.Margin = new System.Windows.Forms.Padding(2);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(65, 65);
            this.sum.TabIndex = 12;
            this.sum.Text = "=";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.number0.Location = new System.Drawing.Point(8, 269);
            this.number0.Margin = new System.Windows.Forms.Padding(2);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(65, 65);
            this.number0.TabIndex = 11;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ForeColor = System.Drawing.Color.OrangeRed;
            this.clear.Location = new System.Drawing.Point(77, 269);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(65, 65);
            this.clear.TabIndex = 10;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.divide.Location = new System.Drawing.Point(215, 62);
            this.divide.Margin = new System.Windows.Forms.Padding(2);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(65, 65);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.multiply.Location = new System.Drawing.Point(215, 131);
            this.multiply.Margin = new System.Windows.Forms.Padding(2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(65, 65);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // substract
            // 
            this.substract.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.substract.Location = new System.Drawing.Point(215, 200);
            this.substract.Margin = new System.Windows.Forms.Padding(2);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(65, 65);
            this.substract.TabIndex = 14;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.add.Location = new System.Drawing.Point(215, 269);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(65, 65);
            this.add.TabIndex = 13;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(290, 344);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button add;
    }
}

