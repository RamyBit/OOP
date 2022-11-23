using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenwelt
{
    class GangContext
    {
        public int GangContextId { get; set; }
        public string Name { get; set; }
        public Random ZG { get; set; } = new Random();
        private List<Pirat> piraten = new List<Pirat>();

        public GangContext()
        {
            GangContextId = 1;
            Name = "Standardgang";
        }
        public void AddPirat(Pirat pirat)
        {
            pirat.PirateID = ZG.Next(815, 1815);
            piraten.Add(pirat);
            pirat.GangId = this.GangContextId;
        }
        public GangContext AddAnotherGang()
        {
            GangContext gang = new GangContext();
            gang.GangContextId += 1;
            return gang;
        }
        public void ListPirat()
        {
            Console.WriteLine("Liste von Piraten:");
            foreach (Pirat pirat in piraten)
            {
                Console.WriteLine(pirat.Name+" ID: "+pirat.PirateID);
            }
            
        } 
    }
}
