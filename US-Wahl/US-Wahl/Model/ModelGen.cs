using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using US_Wahl.Model;
using static US_Wahl.Model.Enums;

namespace US_Wahl
{
    static class ModelGen
    {

        public static List<Person> ZeigeWahlvolk()
        {
            int id;
            string nachname;
            string vorname;
            int plz;
            Geschlecht geschlecht;
            int alter;
            Beeinfulssbarkeit beeinfulssbarkeit;
            Heimat heimat;
            List <Person> people = new List<Person>();
            Random random = new Random();
            
         
            List<string>[] data = OpenFile();
            List<string> lsNachnamen = data[0];
            List<string> lsWnamen = data[1];
            List<string> lsMnamen = data[2];
            
            
            for (int i = 0; i < 10; i++)
            {
                               
                Thread.Sleep(1);
               
                id = i;
                nachname = lsNachnamen.ElementAt(random.Next(0, lsNachnamen.Count));
                geschlecht = (Geschlecht)random.Next(0,2);
                if (geschlecht == Geschlecht.WEIBLICH)
                {
                    vorname = lsWnamen.ElementAt(random.Next(0, lsWnamen.Count));
                }
                else
                {
                    vorname = lsMnamen.ElementAt(random.Next(0, lsMnamen.Count));
                }
                plz = random.Next(47111, 50000);
                heimat = (Heimat)random.Next(0, 1);
                beeinfulssbarkeit = (Beeinfulssbarkeit)random.Next(0, 1);
                alter = random.Next(18, 105);

                people.Add(new Person {ID = id, Nachname = nachname, Vorname= vorname,
                                        Alter = alter, Beeinflussbarkeit=beeinfulssbarkeit, Geschlecht = geschlecht,
                                        PLZ = plz, Heimat = heimat});
                
            }
            return people;
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}
        }
        static ModelGen()
        {

        }
        private static List<string>[] OpenFile()
        {
            List<string>[] data = new List<string>[3];
            List<string> lsNachnamen = new List<string>();
          
            StreamReader srNachnamen = new StreamReader(@".\data\nachnamen.txt");
            string line;
            while ((line= srNachnamen.ReadLine()) != null)
            {
                lsNachnamen.Add(line);
            }
            srNachnamen.Close();
            data[0]= lsNachnamen;

            List<string> lsWnamen = new List<string>();
            StreamReader srWnamen = new StreamReader(@".\data\maedchennamen.txt");
            string line2;
            while ((line2 = srWnamen.ReadLine()) != null)
            {
                lsWnamen.Add(line2);
            }
            srNachnamen.Close();
            data[1]=lsWnamen;

            List<string> lsMnamen = new List<string>();
            StreamReader srMnamen = new StreamReader(@".\data\maedchennamen.txt");
            string line3;
            while ((line3 = srMnamen.ReadLine()) != null)
            {
                lsMnamen.Add(line3);
            }
            srNachnamen.Close();
            data[2]=lsMnamen;

            return data;
        }
    }
}
