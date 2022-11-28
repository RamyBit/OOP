using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    class Flasche<T> where T:Getraenk
    {
        public List<T> Inhalt { get; set; } = new List<T>();
        public bool IstLeer()
        {
            if (Inhalt.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public void Fuellen(T getraenk)
        {
            Inhalt.Add(getraenk);
        }
        public void Leeren(out List<T> getraenk)
        {
            getraenk = Inhalt;
            Inhalt = null;
        }
        
    }
}
