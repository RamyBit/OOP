using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom
{
    class Tier
    {
        private string name;
        private int zahlen;
        private double futtermenge;

        public void SetZahlen(int zahlen)
        {
            this.zahlen = zahlen;
        }

        public int GetZahlen()
        {
            return this.zahlen;
        }

        public void SetFutterMenge(double futtermenge)
        {
            this.futtermenge = futtermenge;
        }

        public double GetFutterMenge()
        {
            return this.futtermenge;
        }

        public void SetName(string name)
        {
            this.name = name;
        } 
        public string GetName()
        {
            return this.name;
        }
    }
}
