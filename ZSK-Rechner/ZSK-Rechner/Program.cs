using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSK_Rechner
{
    class Program
    {
        private Preisliste preisliste = new Preisliste();
        static void Main(string[] args)
        {
            Program p = new Program();

            p.ZeigtMal();
            
            Console.ReadLine();
        }

        public Preisliste GetPreisliste()
        {
            return preisliste;
        }
        public void ZeigtMal()
        {
            
            double betrag;
            string eingabe;
            Waerungsrechner wrechner = new Waerungsrechner();
            DAHRS_Rechner drechner = new DAHRS_Rechner();
            while (true)
            {
                Console.WriteLine("1 vom Euro in ZSK umrechnen \n2 vom ZSK in Euro umrechnen \n3 von Euro in DAHRS umrechenen\n4 von ZSK in DAHRS" +
                    "\n5 Wechselkurse aktulasieren");
                eingabe = Console.ReadLine();
                if (eingabe == "1")
                {
                    Console.WriteLine("Geben Sie einen Betrag ein:");
                    betrag = Convert.ToDouble(Console.ReadLine());
                    int[] erg = wrechner.EuroInZSK(betrag);
                    Console.WriteLine("Der Betrag ist :{0} kuh, {1} shaf, {2} zeige, {3} kleinen Zeigen", erg[0], erg[1], erg[2], erg[3]);
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Wie viel Kuh?");
                    int kuh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wie viel Schaf?");
                    int schaf = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wie viel Zeige?");
                    int zeige = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wie viel kleinen Zeigen?");
                    int klein_zeige = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(wrechner.ZSKInEuro(kuh, schaf, zeige, klein_zeige));
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("Geben Sie einen Betrag ein:");
                    betrag = Convert.ToDouble(Console.ReadLine());
                    int[] erg = drechner.EuroInDAHRS(betrag);
                    Console.WriteLine("Der Betrag ist :{0} Dorsch, {1} Aal, {2} Hering, {3} Rochen, {4} Sprotten", erg[0], erg[1], erg[2], erg[3], erg[4]);
                }
                else if (eingabe == "4")
                {
                    Console.WriteLine("Wie viel Kuh?");
                    int kuh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wie viel Schaf?");
                    int schaf = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wie viel Zeige?");
                    int zeige = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wie viel kleinen Zeigen?");
                    int klein_zeige = Convert.ToInt32(Console.ReadLine());
                    double buffer = wrechner.ZSKInEuro(kuh, schaf, zeige, klein_zeige);
                    int[] erg = drechner.EuroInDAHRS(buffer);
                    Console.WriteLine("Der Betrag ist :{0} Dorsch, {1} Aal, {2} Hering, {3} Rochen, {4} Sprotten", erg[0], erg[1], erg[2], erg[3], erg[4]);
                }
                else if (eingabe == "5")
                {
                    Console.WriteLine("Geben Sie Kuh Preis ein:");
                    preisliste.setPreisliste("Kuh", Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Geben Sie Schaf Preis ein:");
                    preisliste.setPreisliste("Schaf", Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Geben Sie Zeige Preis ein:");
                    preisliste.setPreisliste("Zeige", Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Geben Sie Kleine Zeige Preis:");
                    preisliste.setPreisliste("Klein Zeige", Convert.ToInt32(Console.ReadLine()));
                    wrechner.updatePreis(preisliste);
                    continue;
                }
            }
        }
    }
}
