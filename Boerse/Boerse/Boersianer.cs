using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boerse
{
    class Boersianer
    {
        public List<Aktie> Profolio { get; set; }
        public decimal Kapital { get; set; }

        public void AddAktie(Aktie aktie)
        {
            Profolio.Add(aktie);
        }
    }
}
