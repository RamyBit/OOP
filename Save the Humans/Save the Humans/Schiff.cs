using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    
    class Schiff: Lokation
    {
        private string schiffName;
        private Lokation aktL;
        private Meer aktMeer;
        
        public Schiff(string name, Lokation lokation) : base(name)
        {
            this.schiffName = name;
            lokation.AddSchiff(this);
            aktL = lokation;
        }
        public void segeln(Meer quelle,Meer ziel)
        {
            ziel.AddSchiff(this);
            aktMeer.RmSchiff(this);
            Console.WriteLine("{0} segelt von {1} nach {2}", this.GetName(), aktMeer.GetBez(), ziel.GetBez());
            aktMeer = ziel;
        }
        public void InWasser(Lokation lokation, Meer meer)
        {
            meer.AddSchiff(this);
            aktL.RmSchiff(this);
            aktMeer = meer;
            Console.WriteLine("{0} segelt von {1} in  {2}", this.GetName(), aktL.GetBez(), meer.GetBez());
        }
        public void InStrand(Meer meer, Lokation lokation)
        {
            lokation.AddSchiff(this);
            aktMeer.RmSchiff(this);
            Console.WriteLine("{0} Schiff auf {1} gelandet", this.GetName(), lokation.GetBez());
            aktL = lokation;
        }

        public Lokation GetAktL()
        {
            return this.aktL;
        }
        public Meer GetAktMeer()
        {
            return this.aktMeer;
        }
        public string GetName()
        {
            return this.schiffName;
        }
    }
    
}
