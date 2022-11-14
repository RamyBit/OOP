using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Agregation----------
            Meer karibisches = new Meer("Karibisches Meer");
            Meer meer2 = new Meer("Meer2");
            //Insel nevis = new Insel("Nevis");
            //Lokation lokation = new Lokation("test_location");
            //Lokation strand1 = new Strand("\"lange dinge Strand\"");
            //Lokation Strand2 = new Strand("\"Kurz dinge Strand\"");
            //Lokation kneipe1 = new Kneipe("\"ertrunken betrunken Pirat Kneipe\"");
            //----------------------------------
            // ---------------------Komposition--------------------
            Insel nevis = karibisches.CreateInseln("Nevis");
            Insel monkey = meer2.CreateInseln("Monkey 's Island");
            Strand strand1 = nevis.CreateStrand("\"lange dinge Strand\"");
            Strand strand2 = monkey.CreateStrand("\"Kurz dinge Strand\"");
            Kneipe kneipe1 = nevis.CreateKneipe("\"Kneipe1\"");
            Kneipe kneipe2 = monkey.CreateKneipe("\"ertrunken betrunken Pirat Kneipe\"");
            //------------------------------------------------
            Pirat guybrush = new Pirat("GuyBrush", strand1);
            Pirat elaine = new Pirat("Elaine",strand1);
            Pirat leChuck = new Pirat("LeChuck",kneipe1);
            Schiff schiff1 = new Schiff("Golden Made", strand1);
            //Console.WriteLine("test:{0}",lokation.GetPiraten());
            ZeigtPiraten(strand1);
            Console.WriteLine("LeChuck ist in "+leChuck.GetAktL().GetBez());
            leChuck.bewegen(strand1);
            Console.WriteLine("Piraten, die in {0} sind: ",strand1.GetBez());
            ZeigtPiraten(strand1);
            //Pirat[] piraten = strand1.GetPiraten();
            //Console.WriteLine(piraten[0].GetName());
            //Console.WriteLine(piraten[1].GetName());
            //Console.WriteLine(piraten[2].GetName());
            elaine.bewegen(kneipe1);
            Console.WriteLine("Piraten die in {0} sind ", kneipe1.GetBez());
            Pirat[] piraten2 = kneipe1.GetPiraten();
            Console.WriteLine(piraten2[0].GetName());
            Console.WriteLine(piraten2[1].GetName());
            leChuck.Reise(kneipe1, strand1, schiff1, karibisches, meer2, strand2);
            //Console.WriteLine("test:{0}", lokation.GetPiraten()[0].GetName());


            Console.Read();
          
        }
        public static void ZeigtPiraten(Lokation lokation)
        {
            Pirat[] piraten = lokation.GetPiraten();
            foreach (Pirat pirat in piraten )
                if (pirat != null)
                {
                    Console.WriteLine(pirat.GetName());
                }
        }

       
    }
}
