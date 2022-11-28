using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    
    class Wein : Getraenk
    {
        public string Herkunft { get; set; }

        public string GetHerkunft()
        {
            return this.Herkunft;
        }

        public void GetInfo()
        {
            Console.WriteLine("Info über Wein");
        }
    }
}
