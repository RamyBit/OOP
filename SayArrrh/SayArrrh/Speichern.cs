using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SayArrrh
{
    static class Speichern
    {
        public static void SpeichernDiese(this Insel insel)
        {
            FileStream fs = File.Open(@"Save.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, insel);
            fs.Close();
        }
        public static Insel Einladen()
        {
            Insel insel;
            FileStream fs = File.Open(@"Save.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            insel = (Insel)formatter.Deserialize(fs);
            return insel;
        }
    }
}
