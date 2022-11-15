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
            Mitarbeiter kevin = new Mitarbeiter();
            Untersuchung untersuchung = new Untersuchung();
            Fuetterung fuetterung1 = new Fuetterung();
            Futter futter1 = new Futter();
            kevin.Name = "Kevin";
            untersuchung.ID = 0;
            string name = "Organ Utan";
            Console.WriteLine("Tier Name:{0}", name);
            Tier ou = new Tier(name,untersuchung,fuetterung1,futter1,kevin);
            TierPass pass = ou.GetTierPass();
            Console.WriteLine("Tier Pass Information: ");
            Console.WriteLine("Name: {0}", pass.TierName);
            Console.WriteLine("Gesundheitzustand: {0}", pass.FZustand);
            Console.WriteLine("Fütter Art: {0}", pass.FuetterArt);
            Console.WriteLine("Fütter Menge: {0}", pass.FutterMenge);


            Console.ReadLine();
        }
    }
}
