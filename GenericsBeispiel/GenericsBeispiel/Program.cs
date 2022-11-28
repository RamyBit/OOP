using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> container = new Container<int>();
            int zahl = 3;
            container.Add(zahl);

            foreach(var item in container.liste)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
