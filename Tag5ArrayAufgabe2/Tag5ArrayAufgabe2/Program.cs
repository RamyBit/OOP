using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tag5ArrayAufgabe2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int mittelwert = 0;
            int summe = 0;
            int[] array = new int[6];
            
            for (int i= 0; i<array.Length ; i++)
            {
                Thread.Sleep(1);
                Random r = new Random();
                array[i] = r.Next(1, 6);
            }
            //for (int i=0; i<array.Length -1; i++)
            //{
            //    summe += array[i];
            //}
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                summe += array[i];
                mittelwert = summe / array.Length;
            }

            int min = array[0];
            int max = array[0];
            for (int i =0; i < array.Length -1; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
               
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            
            }
            Console.WriteLine("summe : {0}  mittelwert: {1}", summe, mittelwert);
            Console.WriteLine("Kleinste: {0}", min);
            Console.WriteLine("großte: {0}", max);
            Console.Read();
        }
    }
}
