using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate int CalculateHandler(int ivar1, int ivar2);
    class Program
    {       
        static void Main(string[] args)
        {
            CalculateHandler calculate, calculateSub;
            calculate = new CalculateHandler(Demo.Addition);
            calculateSub = Demo.Subtraktion;
            int[] array = { 1, 3, 5, 7 };
            Umwandeln(array, calculate);
           

            int ergebnis = calculate(3, 4);
            Console.WriteLine(ergebnis);

            Console.ReadKey();
        }
        static void Umwandeln(int[] werte, CalculateHandler dieMethode)
        {
            for (int i = 0; i < werte.Length; i++)
            {
                werte[i] = dieMethode(werte[i], 2);
            }
            foreach (var item in werte)
            {
                Console.WriteLine(item);
            }
        }
    }
}
