using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Enigma_maschine
{
    class Save
    {
        public static string FileOpen()
        {
            try
            {
                string data = String.Empty;
                FileStream fs = new FileStream(@"message.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                data = sr.ReadToEnd();
                sr.Close();
                fs.Close();

                return data;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public static void SaveTo(string data)
        {
            try
            {
                FileStream fs = new FileStream(@"message.txt", FileMode.OpenOrCreate);
                BufferedStream bs = new BufferedStream(fs);
                StreamWriter sw = new StreamWriter(bs);
                sw.Write(data);
                sw.Close();
                bs.Close();
                fs.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
