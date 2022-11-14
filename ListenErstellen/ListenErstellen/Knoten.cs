using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenErstellen
{
    class Knoten
    {
        private int information;
        private Knoten next;

        public Knoten(int info)
        {
            information = info;
            next = null;
        }

        public void SetNext(Knoten k)
        {
            next = k;
        }

        public Knoten GetNext() { return next; }

        public int GetInformation()
        {
            return information;
        }
    }
}
