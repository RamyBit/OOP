using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace US_Wahl
{
    static class Model
    {
        public static void ZeigeWahlvolk(this Person person)
        {

        }
        private static void OpenFile()
        {
            FileStream fsnachnamen = new FileStream(@".\data\nachnamen.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fsnachnamen);

        }
    }
}
