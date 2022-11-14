using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Meer
    {
        private string bezeichnung;
        private Insel[] inseln = new Insel[2];
        private Schiff[] schiffe = new Schiff[5];
        private Pirat[] piraten = new Pirat[10];
        int pos = 0;
        int pos2 = 0;
        int pos3 = 0;
        int pos4 = 0;


        public Meer(string bez)
        {

            bezeichnung = bez;
        }
        public string GetBez()
        {
            return bezeichnung;
        }

      
        
        public Insel[] GetInsel()
        {
            return this.inseln;
        }

        public Insel CreateInseln(string s)
        {
            Insel insel = new Insel(s);
            inseln[pos4]=insel;
            pos4++;
            return insel;
        }
        public void AddSchiff(Schiff schiff)
        {
            this.schiffe[pos] = schiff;
            pos++;
        }
        public void RmSchiff(Schiff schiff)
        {
            foreach (Schiff s in schiffe)
            {
                pos2++;
                if (schiff == s)
                {
                    schiffe[pos2] = null;
                }
            }
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
                if (person != null)
                {
                    pos2++;
                    if (person == pirat)
                    {
                        piraten[pos2] = null;
                    }
                }

            }
        }
    }
}
