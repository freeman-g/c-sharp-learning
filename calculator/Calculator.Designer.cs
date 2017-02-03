namespace WindowsFormsApplication1
{
    partial class Calculator
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AC = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.resultBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(3, 3);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(222, 31);
            this.resultBox.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.AC);
            this.flowLayoutPanel2.Controls.Add(this.mod);
            this.flowLayoutPanel2.Controls.Add(this.add);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.divide);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.multiply);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Controls.Add(this.button8);
            this.flowLayoutPanel2.Controls.Add(this.button9);
            this.flowLayoutPanel2.Controls.Add(this.subtract);
            this.flowLayoutPanel2.Controls.Add(this.button0);
            this.flowLayoutPanel2.Controls.Add(this.dec);
            this.flowLayoutPanel2.Controls.Add(this.equals);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(234, 290);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(3, 3);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(51, 52);
            this.AC.TabIndex = 4;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(60, 3);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(51, 52);
            this.mod.TabIndex = 6;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(174, 61);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(51, 52);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(174, 119);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(51, 52);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 52);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(117, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 52);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(174, 177);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(51, 52);
            this.subtract.TabIndex = 15;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 52);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(60, 177);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 52);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(117, 177);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 52);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(117, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 52);
            this.add.TabIndex = 19;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(3, 235);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(108, 52);
            this.button0.TabIndex = 20;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(117, 235);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(51, 52);
            this.dec.TabIndex = 22;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // equals
            // 
            this.equals.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.equals.Location = new System.Drawing.Point(174, 235);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(51, 52);
            this.equals.TabIndex = 23;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 378);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button equals;
    }
}

