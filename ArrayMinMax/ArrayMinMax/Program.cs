using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMax
{
    delegate bool VergleichsDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 5, 6, 4 };
            int max, min;
            VergleichsDelegate calculateMin, calculateMax;
            calculateMin = Vergleich.IstKleiner;
            calculateMax = Vergleich.IstGroesser;
            min = Limit(array, calculateMin);
            max = Limit(array, calculateMax);
            Console.WriteLine($"min ={min} max={max} ");
            Console.ReadLine();
        }

        static int Limit(int[] array, VergleichsDelegate methoden)
        {
            int minMax = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (methoden(array[i], minMax))
                    minMax = array[i];
            }
            return minMax;
        }
        
    }
}
