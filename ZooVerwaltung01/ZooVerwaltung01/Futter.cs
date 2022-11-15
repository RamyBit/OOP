using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Futter
    {
        public string Art { get; set; }
        public double Menge { get; set; }

        public void eingabe()
        {

            Console.WriteLine("Geben Sie die Fütter Art ein: ");
            Art = Console.ReadLine();
            Console.WriteLine("Geben Sie die Menge von Fütter: ");
            Menge = Convert.ToDouble(Console.ReadLine());
        }
    }
}
