using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionBeispiel_Do1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Sven");
            stringStack.Push("Alex");
            stringStack.Push("Robert");

            Console.WriteLine( stringStack.Peek());
            Console.WriteLine(stringStack.Peek());
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Peek());
            Console.WriteLine("____________________");

            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Sven");
            stringQueue.Enqueue("Alex");
            stringQueue.Enqueue("Robert");

            Console.WriteLine(stringQueue.Peek());
            string svenRettung = stringQueue.Dequeue();
            Console.WriteLine("Gerettet {0}", svenRettung);
            Console.WriteLine(stringQueue.Dequeue());
            Console.WriteLine(stringQueue.Peek());

            //================ Western ================
            // Erstelle Steckbrief
            Steckbrief name = new Steckbrief() { Name = "Der Name1", Kopfgeld = 1, Lebendig = true };
            Steckbrief name2 = new Steckbrief() { Name = "Der Name2", Kopfgeld = 1000, Lebendig = true };
            Steckbrief name3 = new Steckbrief() { Name = "Der Name3", Kopfgeld = -1000, Lebendig = false };

            Stack<Steckbrief> SchreibtischStapel = new Stack<Steckbrief>();
            SchreibtischStapel.Push(name);
            SchreibtischStapel.Push(name2);
            SchreibtischStapel.Push(name3);

            foreach (Steckbrief steckbrief in SchreibtischStapel)
            {
                Console.WriteLine($"Name: {steckbrief.Name} Euro: {steckbrief.Kopfgeld} Lebend: {steckbrief.Lebendig}");
            }

            SchreibtischStapel.Pop();
            Console.ReadLine();
        }
    }

    public class Steckbrief
    {
        public string Name { get; set; }
        public int Kopfgeld { get; set; }
        public bool Lebendig { get; set; }
    }
}
