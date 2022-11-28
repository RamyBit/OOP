using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    class Pirat<T> where T: Getraenk
    {
        public T Getraenk { get; private set; }
        public Pirat()
        {
            Getraenk = default;
        }
        public bool IstLeer()
        {
            return Getraenk == null;
        }
    }
}
