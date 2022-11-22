using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder
{
    class Fuetter
    {
        public string Name { get; set; }
        public string Vorname { get; set; }

      
        public void Fuettern(Kind kind, Nahrung n)
        {
            kind.Gefuetert(n);
        }
    }
}
