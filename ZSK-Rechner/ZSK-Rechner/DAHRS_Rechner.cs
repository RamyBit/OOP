using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSK_Rechner
{
    class DAHRS_Rechner
    {
      

        private double dwert;
        private double awert;
        private double hwert;
        private double rwert;
        private double swert;

        public DAHRS_Rechner()
        {
            dwert = 8;
            awert = dwert / 11;
            hwert = awert / 5;
            rwert = 9 * hwert + 7 * awert;
            swert = hwert / 11;
         }
        public int[] EuroInDAHRS(double betrag)
        {
            int[] erg = new int[5];
            int d = (int)(betrag / dwert);
            betrag %= dwert;
            int a = (int)(betrag / awert);
            betrag %= awert;
            int h = (int)(betrag / hwert);
            betrag %= hwert;
            int r = (int)(betrag / rwert);
            betrag %= rwert;
            int s = (int)(betrag / swert);
            erg[0] = d;
            erg[1] = a;
            erg[2] = h;
            erg[3] = r;
            erg[4] = s;
            return erg;
            //Console.WriteLine("Der Betrag ist :{0} Dorsch, {1} Aal, {2} Hering, {3} Rochen, {4} Sprotten", d, a, h, r, s);
        }

        public double DAHRSInEuro(int d, int a, int h, int r, int s)
        {
            double betrag;
            betrag = d * dwert + a * awert + h * hwert + r * rwert + s * swert;
            return betrag;
        }
        
    }
}
