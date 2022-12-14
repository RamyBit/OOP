using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calc
    {
        public int x { get; set; }
        public int y { get; set; }
        public string Num1 { get; set; }
        public string Num2 { get; set; }
        public bool OperationEntered { get; set; } = false;
        public bool XEntered { get; set; } = false;
        public bool YEntered { get; set; } = false;
        public string Operation { get; set; }
        public double Result { get; set; } = 0;

        
        public void SetValue (string a)
        {
           
            if (OperationEntered == false)
            {
                Num1 += a;
                x = Convert.ToInt32(Num1);
            }
            else if (OperationEntered)
            {
                Num2 += a;
                y = Convert.ToInt32(Num2);
                YEntered = true;
            }
        }
        public void SetOperation(string operation)
        {
            Operation = operation;
            OperationEntered = true;
        }
        public void Reset()
        {
            Result = 0;
            x = 0;
            y = 0;
            Num1 = "";
            Num2 = "";
            Operation = "";
            YEntered = false;
            OperationEntered = false;
        }
        public void Calculate()
        {
            double result = 0;
            switch (Operation)
            {
                case  "+":
                    result = x + y;
                    break;

                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    if (y != 0)
                    {
                        result = x / y;
                        break;
                    }
                    else
                    {
                        result = 0;
                        break;
                    }
                    


                default:
                    result = 0;
                    break;
            }
            //Operation = "";
            Result = result;
        }
    }
}
