using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobeispiel
{

   
    class Program
    {
        static void Main(string[] args)
        {
            Auto meinVM = new Auto();
            meinVM.StartStop();
            Console.WriteLine(meinVM.GetZustand());

            Auto auto2 = new Auto();
            auto2.StartStop();
            Console.WriteLine(auto2.GetZustand());

            // Aufruf statischer Methoden
            Auto.Ausgeben();
            Console.Read();
        }
    }
}
