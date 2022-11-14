using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen
{
    class Haeppchen
    {
        private string name;
        private Broetchen  zustat_1;
        private Butter zustat_2;
        private Kaese zustat_3;
        private Ei zustat_4;

        public Haeppchen(Broetchen  br, Butter bu, Kaese k, Ei ei)
        {
            zustat_1 = br;
            zustat_2 = bu;
            zustat_3 = k;
            zustat_4 = ei;
            name = "Ich bin Dein Brötchen";
        }

        public void ZeigeInhalt()
        {
            Console.WriteLine(this.name + " und ich bestehe aus: ");
            Console.WriteLine(this.zustat_1.GetBezeichnung() +"\n"+ 
                              this.zustat_2.GetBezeichnung() + "\n"+
                              this.zustat_3.GetBezeichnung() + "\n"+
                              this.zustat_4.GetBezeichnung() + "\n");
        }

    }
}
