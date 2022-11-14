using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobeispiel2
{
    class Klassenraum
    {
        private string raumNummer;
        private string gruppenName;

        public void SetRaumNummer(string s)
        {
            this.raumNummer = s;
        }
        public void SetGruppenName(string s)
        {
            this.gruppenName = s;
        }
        public string GetRaumNummer()
        {
            return this.raumNummer;
        }

        public string GetGruppenName()
        {
            return this.gruppenName;
        }
    }
}
