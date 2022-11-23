using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder
{
    class Kind
    {
        public string Name { get; set; }
        private List<Nahrung> Magen = new List<Nahrung>();
        private int AktuellerBrennwert { get; set; }

        public void Gefuetert(Nahrung n)
        {
            this.Magen.Add(n);
            
            AktuellerBrennwert += n.Brennwert;
        }

        public void IchHabeGegessen()
        {
            foreach (Nahrung nahrung in Magen)
            {
                Console.WriteLine(nahrung.Brennwert);
            }
            Console.WriteLine("Brennwert gesamt: {0} ", AktuellerBrennwert);
        }
        public void Toben()
        {
            AktuellerBrennwert -= Magen[0].Brennwert;
            Magen.RemoveAt(0);                    

        }
    }
}
