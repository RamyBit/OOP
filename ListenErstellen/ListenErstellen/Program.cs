using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenErstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Knoten neu = new Knoten(4711);
            //Knoten erstes = neu;

            //neu = new Knoten(4812);
            //erstes.SetNext(neu);

            //Knoten akt = erstes;

            //Console.WriteLine(akt.GetInformation());

            //akt = akt.GetNext();
            //Console.WriteLine(akt.GetInformation());

            VerketteteListe vl = new VerketteteListe();
            vl.Add(4711);

            LinkedList<int> ll = new LinkedList<int>();
           
            Console.Read();
        }
    }
}
