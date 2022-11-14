using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aggregation
            Person moro = new Person();
            moro.SetName("Moro");
            Klassenraum raum4 = new Klassenraum();
            raum4.SetBezeichnung("Raum4");
            raum4.SetEinePerson(moro);

            // Komposition
            Klassenraum neu = new Klassenraum();
            neu.SetBezeichnung("das Ende");
            neu.SetEinePerson(new Person());
            neu = null;
        }
    }
}
