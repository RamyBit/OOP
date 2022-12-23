using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayArrrh
{
    [Serializable]
    class Insel
    {
        private List<Pirat> Piraten = new List<Pirat>();
        private List<Kneipe> kneipen = new List<Kneipe>();
        private List<Wald> walds = new List<Wald>();
        public void ZeigDichPirat()
        {
            int counter = 1;
            foreach (Pirat pirat in Piraten)
            {
                Console.WriteLine($"{counter} Name : {pirat.Name} Ort: {pirat.Aufenhaktsort}");
                counter++;
            }
        }
        public void AddPirat(Pirat pirat)
        {
            this.Piraten.Add(pirat);
        }
        public List<Kneipe> GetKneipe()
        {
            return this.kneipen;
        }
        public List<Wald> GetWalds()
        {
            return this.walds;
        }
        public Insel()
        {
            Kneipe kneipe = new Kneipe();
            kneipe.Name = "Kneipe";
            kneipen.Add(kneipe);
            Wald wald = new Wald();
            wald.Name = "wald";
            walds.Add(wald);
        }
    }
}
