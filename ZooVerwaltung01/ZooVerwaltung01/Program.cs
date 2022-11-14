using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganUtan organUtan = new OrganUtan();
            Tier t = new Tier();
            t.Name = "Bär";
            Console.WriteLine(t.Name);
            Console.ReadLine();
        }
    }
}
