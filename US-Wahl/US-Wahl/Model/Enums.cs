using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl.Model
{
    class Enums
    {
        public enum Beeinfulssbarkeit
        {
            LEICHT,
            MITTEL,
            SCHWER
        }
        public enum Alter
        {
            ERSTWAEHLER,
            BIS30,
            BIS40,
            BIS50,
            RESTLICHE
        }
        public enum Schicht
        {
            UNTERSCHICHT,
            UNTEREMITTELSCHICHT,
            OBEREMITTELSCHICHT,
            OBERSCHICHT
        }
        public enum Geschlecht 
        {
            WEIBLICH,
            MAENNLICH
        }
        public enum Heimat
        {
            REPUBLIKANER,
            DEMOKRATEN
        }
    }
}
