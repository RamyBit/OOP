using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder
{
    class Nahrung
    {
        public string NahrungsName { get; set; }
        public int Brennwert { get; set; }

        public Nahrung(string name, int brennwert )
        {
            this.NahrungsName = name;
            this.Brennwert = brennwert;
        }
    }
    
}
