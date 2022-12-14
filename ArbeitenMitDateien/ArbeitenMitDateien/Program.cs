using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArbeitenMitDateien
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = File.Open(@"datei.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(fs);
            //Console.WriteLine(sr.ReadToEnd());
            //fs.Close();
            //Console.ReadLine();

            //StreamReader sr = new StreamReader("datei.txt");

            //string line;

            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}

            FileStream fs = File.Open(@"datei2.txt", FileMode.OpenOrCreate);
            BufferedStream bs = new BufferedStream(fs);

            StreamWriter sw = new StreamWriter(bs);
            sw.WriteLine("neue Daten");
            sw.Close();
            fs.Close();
            
            Console.ReadLine();
        }
    }
}
