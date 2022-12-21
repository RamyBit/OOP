using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class Arche
    {
        public string Name { get; set; } = "Noahs Arche";
        public List<IBerechtigung> Berechtigte;
        public List<string> NoGo { get; set; } = Inventory.blacklisted;
        public IVerantwortlicher Verantwortlicher;

        // Constructor
        public Arche(IVerantwortlicher verantwortlicher, List<IBerechtigung> berechtigte)
        {
            Verantwortlicher = verantwortlicher;
            Berechtigte = berechtigte;
        }

        public void AddMitreisenden(IBerechtigung passagier)
        {
            passagier.Eintreten(this);

            if (Verantwortlicher.BerechtigungPruefen(passagier))
            {
                Berechtigte.Add((IBerechtigung)passagier);
            }
            else
            {
                System.Console.WriteLine($"Ein Berechtigter muß berechtigt draußen bleiben! ");
            }
        }


        public void AddMitreisenden(UnTier passagier)
        {
            Alien a = (Alien)Verantwortlicher;

            System.Console.WriteLine($"{a.Name} sagt: {passagier.Name} muß draußen bleiben! ");
        }

        public void ZeigeAlleMitreisenden()
        {
            foreach (var berechtigter in Berechtigte)
            {
                System.Console.WriteLine(berechtigter.ZeigeInfo());
            }
        }
    }
}
