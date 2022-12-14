using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        
        Calc calc = new Calc();
        private string num1="";
        private string num2 = "";
        public Form1()
        {
            Calc calc = new Calc();
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            calc.SetValue("1");
            UpdateResult();

        }

        private void UpdateResult()
        {
            if (calc.OperationEntered == false)
            {
                Result.Text = $"{calc.x}";
            }
            else if (calc.OperationEntered == true)
            
            {
                if (calc.Result == 0)
                {
                    if (!calc.YEntered)
                    {
                        Result.Text = $"{calc.x} {calc.Operation} ";
                        BResult.Text = $"{Convert.ToString(calc.x,2)} {calc.Operation} ";
                    }
                    else
                    {
                        Result.Text = $"{calc.x} {calc.Operation} {calc.y} ";
                        BResult.Text = $"{Convert.ToString(calc.x, 2)} {calc.Operation} {Convert.ToString(calc.y)} ";
                    }
                    
                }
                else
                {
                    Result.Text = $"{calc.x} {calc.Operation} {calc.y} = {calc.Result}";
                }
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc.SetValue("2");
            UpdateResult();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calc.SetValue("3");
            UpdateResult();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calc.SetValue("4");
            UpdateResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calc.SetValue("5");
            UpdateResult();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calc.SetValue("6");
            UpdateResult();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calc.SetValue("7");
            UpdateResult();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calc.SetValue("8");
            UpdateResult();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calc.SetValue("9");
            UpdateResult();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            calc.SetValue("0");
            UpdateResult();
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calc.SetOperation("+");
            UpdateResult();
           
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calc.SetOperation("-");
            UpdateResult();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            calc.SetOperation("*");
            UpdateResult();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            calc.SetOperation("/");
            UpdateResult();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            calc.Calculate();
            UpdateResult();
            calc.Num1 = "";
            calc.Num2 = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            calc.Reset();
            UpdateResult();
        }
    }
}
