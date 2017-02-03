using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {

        //the calculator uses <a> <op> <b>
        //e.g., 10 + 20
        //because its hard to concatenate floats, numbers are stored as strings
        //until the actual arithmetic is performed

        string a, b = null;
        string op = null;

        public Calculator()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            handleNumericClick("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            handleNumericClick("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            handleNumericClick("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            handleNumericClick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            handleNumericClick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            handleNumericClick("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            handleNumericClick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            handleNumericClick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            handleNumericClick("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            handleNumericClick("0");
        }

        private void dec_Click(object sender, EventArgs e)
        {

            if (this.op == null && this.a == null)
            {
                this.a = ".";
                resultBox.Text = this.a;
                return;
            }

            if (this.op == null && this.a != null)
            {
                if (!this.a.Contains("."))
                {
                    this.a += ".";
                    this.resultBox.Text = this.a;
                }
            }

            if (this.op != null && this.b == null)
            {
                this.b = ".";
                resultBox.Text = this.b;
                return;
            }

            if (this.op != null && this.b != null)
            {
                if (!this.b.Contains("."))
                {
                    this.b += ".";
                    this.resultBox.Text = this.b;
                }
            }
            
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (isReadyForOperation())
            {
                doChainedOperation();
            }
            this.op = "-";
        }

        private void doSubtraction()
        {
            float calculation = float.Parse(this.a) - float.Parse(this.b);
           setCalculation(calculation);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (isReadyForOperation())
            {
                doChainedOperation();
            }

            this.op = "+";
   
        }

        private void doAddition()
        {
            float calculation = float.Parse(this.a) + float.Parse(this.b);
            setCalculation(calculation);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (isReadyForOperation())
            {
                doChainedOperation();
            }
            this.op = "X";
   

        }

        private void doMultiplication()
        {
            float calculation = float.Parse(this.a) * float.Parse(this.b);
            setCalculation(calculation);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (isReadyForOperation())
            {
                doChainedOperation();
            }
            this.op = "/";
        }

        private void doDivision()
        {
            float calculation = float.Parse(this.a) / float.Parse(this.b);
            setCalculation(calculation);
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (isReadyForOperation())
            {
                doChainedOperation();
            }
            this.op = "%";
        }

        private void doMod()
        {
            float calculation = float.Parse(this.a) % float.Parse(this.b);
            setCalculation(calculation);
        }

        private void setCalculation(float calculation)
        {
            resultBox.Text = calculation.ToString();
            this.a = calculation.ToString();
            this.b = null;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (isReadyForOperation())
            {
                doChainedOperation();
            }

        }

        private bool isReadyForOperation()
        {
            if (this.op != null && this.a != null && this.b != null)
            {
                return true;
            }

            return false;
        }

        private void doChainedOperation()
        {
            if (isReadyForOperation())
            {
                switch (this.op)
                {
                    case "X":
                        doMultiplication();
                        break;
                    case "/":
                        doDivision();
                        break;
                    case "-":
                        doSubtraction();
                        break;
                    case "+":
                        doAddition();
                        break;
                    case "%":
                        doMod();
                        break;
                }
            }
               
        }

        private void AC_Click(object sender, EventArgs e)
        {
            this.a = null;
            this.b = null;
            this.op = null;
            this.resultBox.Text = null;
        }

        private void handleNumericClick(string number)
        {

   
                if (this.op == null && this.a == null)
                {
                   
                    this.a = number;
                    resultBox.Text = this.a;
                    return;
                }

                if (this.op == null && this.a != null)
                {
                    this.a += number;
                    resultBox.Text = this.a;
                    return;
                }

                if (this.op != null && this.b == null)
                {
                    this.b = number;
                    resultBox.Text = this.b;
                    return;
                }

                if (this.op != null && this.b != null)
                {
                    this.b += number;
                    resultBox.Text = this.b;
                    return;
                }
   
        }

    }
}
