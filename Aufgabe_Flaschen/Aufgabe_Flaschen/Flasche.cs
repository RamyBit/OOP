using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Flaschen
{
    class Flasche<T>
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
        public List<T> Leeren()
        {
            return Inhalt;
            Inhalt.Clear();
        }
    }
}
