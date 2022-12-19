using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static US_Wahl.Model.Enums;

namespace US_Wahl
{
    class Person
    {
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int PLZ { get; set; }
        public  GESCHLECHT Geschlecht { get; set; }
        public int Alter { get; set; }
        public BEEINFLUSSBARKEIT Beeinflussbarkeit { get; set; }
        public HEIMAT Heimat { get; set; }
        public SCHICHT Schicht { get; set; }
    }
}
