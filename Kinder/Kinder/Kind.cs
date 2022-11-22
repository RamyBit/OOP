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

        public void Gefuetert(Nahrung n)
        {
            this.Magen.Add(n);
        }
        public int Toben()
        {
            int energie = 0;
            foreach (Nahrung item in Magen)
            {
                energie += item.Brennwert;
            }
            Magen.Clear();
            return energie;

        }
    }
}
