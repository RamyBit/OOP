using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl.Model
{
    class Enums
    {
        public enum BEEINFLUSSBARKEIT
        {
            LEICHT,
            MITTEL,
            SCHWER
        }
        public enum ALTER
        {
            ERSTWAEHLER,
            BIS30,
            BIS40,
            BIS50,
            RESTLICHE
        }
        public enum SCHICHT
        {
            UNTERSCHICHT,
            UNTEREMITTELSCHICHT,
            OBEREMITTELSCHICHT,
            OBERSCHICHT
        }
        public enum GESCHLECHT
        {
            WEIBLICH,
            MAENNLICH
        }
        public enum HEIMAT
        {
            REPUBLIKANER,
            DEMOKRATEN
        }
    }
}
