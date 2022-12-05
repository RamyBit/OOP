using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MiniProjektLotto
{
    class ZufallsZahlGen
    {
        private Random rnd = new Random();
        public List<int> Ziehen()
        {
            List<int> ziehung = new List<int>();
            do
            {
                Thread.Sleep(1);
                int zahl = rnd.Next(1, 49);

                if (!ziehung.Contains(zahl))
                {
                    ziehung.Add(zahl);
                }
            } while (ziehung.Count() < 6);
            ziehung.Sort();
            return ziehung;
        }
        
    }
}
