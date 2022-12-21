using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    static class Inventory
    {
        public static List<IBerechtigung> berechtigte = new List<IBerechtigung>()
        {
            new Mensch(){Name = "Jim"},
            new Mensch(){Name = "Pille"},
            new Mensch(){Name = "Scotty"},
            new Mensch(){Name = "Ohura"},
            new Mensch(){Name = "Spock"},
            new Tier(){Tierart = "Pottwal"},
            new Tier(){Tierart = "Buckelwal"},
            new Mensch(){Name = "Pinocchio"},
            new Tier() {Tierart = "Stubenfliege"}
        };
        public static List<string> blacklisted = new List<string>()
        {
            "Donald",
            "Hanni",
            "Nanni",
            "Fliwatüt",
            "Der Imperator"
        };
    }
}
