using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Pirat
    {
        private string name;
        private Lokation aktL;
        private Meer aktMeer;
      
        public Pirat(string s, Lokation lokation)
        {
            name = s;
            aktL = lokation;
            lokation.AddPiraten(this);
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        
        public void bewegen(Lokation ziel)
        {

            
            ziel.AddPiraten(this);
            Console.WriteLine("{0} bewegt von {1} nach {2}", this.GetName(), aktL.GetBez(), ziel.GetBez());
            aktL.RmPiraten(this);
            aktL = ziel;
            
        }
        public string GetName()
        {
            return this.name;
        }
        public Lokation GetAktL()
        {
            return this.aktL;
        }
        public Meer GetAktMeer()
        {
            return this.aktMeer;
        }
        public void Schwimmen(Meer meer)
        {
            meer.AddPiraten(this);
            aktMeer.RmPiraten(this);
            Console.WriteLine("{0} Schwimmen von {1} nach {2}", this.GetName(), aktL.GetBez(), meer.GetBez());
            aktMeer = meer;
        }
        public void InWasser(Lokation lokation, Meer meer)
        {
            meer.AddPiraten(this);
            aktL.RmPiraten(this);
            Console.WriteLine("{0} fallen von {1} in  {2}", this.GetName(), aktL.GetBez(), meer.GetBez());
            aktMeer = meer;
        }
        
        public void Reise(Kneipe kneipe, Strand strand, Schiff schiff, Meer meer1, Meer meer2, Strand strand2)
        {

            this.bewegen(strand);
            this.bewegen(schiff);
            schiff.InWasser(strand, meer1);
            schiff.segeln(meer1, meer2);
            schiff.InStrand(meer2, strand2);
            this.bewegen(strand2);
        }
    }
}
