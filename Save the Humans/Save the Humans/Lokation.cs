using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Lokation
    {
        private string bezeichnung;
        private Pirat[] piraten = new Pirat[10];
        private Schiff[] schiffe = new Schiff[5];
        int pos=0;
        int pos2 = 0;
        int pos3 = 0;
        int pos4 = 0;
        public Lokation(string bez)
        {
            bezeichnung = bez;
        }
        public string GetBez()
        {
            return bezeichnung;
        }

        

        public Pirat[] GetPiraten()
        {
            return this.piraten;
        }

        public void AddPiraten(Pirat pirat)
        {
            this.piraten[pos] = pirat;
            pos++;            
        }
        public void RmPiraten(Pirat pirat)
        {
            foreach (Pirat person in piraten)
            {
                if(person != null)
                {
                    pos2++;
                    if (person == pirat)
                    {
                        piraten[pos2] = null;
                    }
                }
                
            }
        }

        public void AddSchiff(Schiff schiff)
        {
            this.schiffe[pos] = schiff;
            pos3++;
        }
        public void RmSchiff(Schiff schiff)
        {
            foreach (Schiff s in schiffe)
            {
                if (s != null)
                {
                    pos4++;
                    if (s == schiff)
                    {
                        schiffe[pos4] = null;
                    }
                }

            }
        }
    }
}
