using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateSample
{
    delegate void MyDel(int value);
    class Program
    {
        void PrintLow(int value)
        {
            Console.WriteLine($"{value} - Low Value");
        }
        void PrintHigh(int value)
        {
            Console.WriteLine($"{value} - High Value");
        }
        static void Main(string[] args)
        {
            int value;
            
                Program program = new Program();
                MyDel del;
            do
            {
                Thread.Sleep(1);
                Random random = new Random();
                int randomValue = random.Next(99);
                value = randomValue;
                del = randomValue < 50
                            ? new MyDel(program.PrintLow)
                            : new MyDel(program.PrintHigh);
                del(randomValue);
            } while (value != 50);
            
            Console.ReadLine();
        }
    }
}
