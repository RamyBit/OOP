using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace PiratesCoveLine
{
    class Karte
    {
        private Hashtable weg1 = new Hashtable();
        public int Lange { get; set; }
        public Karte()
        {
            weg1.Add(1, "Dublin");
            weg1.Add(4, "Antwerpen");
            weg1.Add(7, "Kassel");
            weg1.Add(10, "Genua");
            Lange = 10; 
        }

        public string GetStation(int pos)
        {
            if (weg1[pos] != null)
            {
                return (string)weg1[pos];
            }
            else
            {
                return "unterweg";
            }
        }

    }

   
}
