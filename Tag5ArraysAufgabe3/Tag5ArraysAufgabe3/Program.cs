using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag5ArraysAufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] array = { 5, 4, 3, 2, 1, 9, 8, 7, 6, 0 };
            // Array aufsteigen sortiern
            Program.BubbleSort(array, "a");
            // Array auf dem Bildschirm anzeigen
            PrintArray(array);
            Console.WriteLine();
            // Array absteigen sortiern
            BubbleSort(array, "d");
            PrintArray(array);
            Console.Read();
           
        }
        static int[] BubbleSort(int[] array, string sortType)
        {    // geben Sie in der Zweite Argumment "a" für asendent um array aufsteigen zu sortiern
            // Geben Sie in der Zwiete Argumment "d" für desending um array absteigen zu sortiern
            if (sortType == "a"){
                for (int i = 0; i < array.Length - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
            }
            if (sortType == "d")
            {
                for (int i = 0; i < array.Length - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
            }
            
                    return array;
        }
        // Die folgende Funktion ist sogennte Prozedur, da die keine Rückwert hat, deshalb
        // wird der Strichwort "void" verwendet
        // Dieser Prozedur wird verwendet, um der Inhalt eines Arrays anzuzeigen.
        static void PrintArray(int[] array)
        {
            Console.Write("Array: ");
            foreach (int item in array)
            {
                Console.Write(item +" ");
            }
        }
    }
}
