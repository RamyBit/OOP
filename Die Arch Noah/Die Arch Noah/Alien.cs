using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class Alien: IBerechtigung, IVerantwortlicher
    {
        public string Name { get; set; }
        public IVerantwortlicher verantwortlicher { get; set; }
        public Arche Zufluchtsort { get; set; }
        public void Eintreten(Arche arche)
        {
            Zufluchtsort = arche;
        }
        public string ZeigeInfo()
        {
            return this.Name;
        }
        public bool BerechtigungPruefen(IBerechtigung berechtigter)
        {
            Mensch mensch = null;
            bool erlaubt = true;
            if (berechtigter is Mensch)
            {
                mensch = (Mensch)berechtigter;
                if (mensch.Zufluchtsort.NoGo.Contains(mensch.Name))
                {
                    erlaubt = false;
                }
            }
            return erlaubt;
        }
    }
}

