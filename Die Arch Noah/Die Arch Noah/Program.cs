using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Arche a = new Arche(new Alien() {Name = "Ford Perfect" }, Inventory.berechtigte);
            UnTier ut = new UnTier() { Name = "Khan" };
            a.AddMitreisenden(ut);

            Mensch m1 = new Mensch() { Name = "Donald" };
            a.AddMitreisenden(m1);

            Alien a1 = new Alien() { Name = "Donald" };
            a.AddMitreisenden(a1);
            a.ZeigeAlleMitreisenden();
            Console.ReadLine();

        }
    }
}
