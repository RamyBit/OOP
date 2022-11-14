using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Insel
    {
        private string bezeichnung;
        private Lokation[] lokationen = new Lokation[3];
        int pos;

        public Insel(string bez)
        {

            bezeichnung = bez;
        }
        public string GetBez()
        {
            return bezeichnung;
        }


        public Lokation[] GetLokationen()
        {
            return this.lokationen;
        }

        public Strand CreateStrand(string name)
        {
            Strand strand = new Strand(name);
            this.lokationen[pos] = strand;
            pos++;
            return strand;
                      
        }

        public Kneipe CreateKneipe(string name)
        {
            Kneipe kneipe = new Kneipe(name);
            this.lokationen[pos] = kneipe;
            pos++;
            return kneipe;

        }
      
    }
}
