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
        public string Operation { get; set; }

        public double Calculate(int x,int y,string operation)
        {
            double result = 0;
            switch (operation)
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
            return result;
        }
    }
}
