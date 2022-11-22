using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuetter fuetter1 = new Fuetter();
            Kind kind1 = new Kind();
            Enkelkind enkelkind1 = new Enkelkind();

            fuetter1.Name = "Fütterer";
            fuetter1.Vorname = "Johanna";
            kind1.Name = "Mustermann";
            enkelkind1.Name = kind1.Name;
            enkelkind1.Vorname = "Dieter";
            fuetter1.Fuettern(kind1, new Nahrung("Banana", 10));
            fuetter1.Fuettern(enkelkind1, new Nahrung("Apfel", 10));
            Console.WriteLine(kind1.Toben());
            Console.WriteLine(kind1.Toben());
            Console.ReadLine();

        }
    }
}
