using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Person
    {
        private string vorname;
        private string nachname;

        public Person()
        {
            vorname = "James";
            nachname = "Blond";
        }
        public Person (string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public void ZeigMal()
        {
            Console.WriteLine(vorname);
            Console.WriteLine(nachname);
        }
    }
}
