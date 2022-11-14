using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tag5ArrayAufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i= 0; i<= 9; i++)
            {
                Thread.Sleep(1);
                Random r = new Random();
                array[i] = r.Next(1, 10);
            }
            //for (int i=0; i<= 9; i++)
            //{
            //    array[i] = i;
            //}
            //for (int i=0; i<= 9; i++)
            //{
            //    array[i] = i + 1;
            //}
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i=array.Length-1; i>=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }
    }
}
