using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    class Bier : Getraenk
    {
        public string Brauerei { get; set; }

        public string GetBrauerei()
        {
            return this.Brauerei;
        }
        public void GetInfo()
        {
            Console.WriteLine("Information über Bier");
        }
    }
}
