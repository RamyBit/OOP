using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_01
{
    class Klassenraum
    {
        private Person einePerson;
        private string bezeichnung;

        public void SetEinePerson( Person p)
        {
            einePerson = p;
        }
        public Person GetEinePerson()
        {
            return einePerson;
        }

        public void SetBezeichnung(string s)
        {
            bezeichnung = s;
        }

        public string GetBezeichnung()
        {
            return bezeichnung;
        }
    }
}
