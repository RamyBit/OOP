using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobeispiel2
{
    class Person
    {
        private string name;
        private string vorname;
        private int geburtsjahr;
        
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetVorname(string vorname)
        {
            this.vorname = name;
        }

        public void SetGeburtsjahr(int geburtsjahr)
        {
            this.geburtsjahr = geburtsjahr;
        }

        public string GetName()
        {
            return name;
        }
        public string GetVorname()
        {
            return (this.vorname);
        }
        public int GetGeburtsjahr()
        {
            return (this.geburtsjahr);
        }


    }
}
