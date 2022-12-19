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
        public  Geschlecht Geschlecht { get; set; }
        public int Alter { get; set; }
        public Beeinfulssbarkeit Beeinflussbarkeit { get; set; }
        public Heimat Heimat { get; set; }
    }
}
