using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiniProjektLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            ZufallsZahlGen ziehung = new ZufallsZahlGen();
            List<List<int>> Ziehungen = new List<List<int>>();
            Hashtable AlleNummer = new Hashtable();
            for (int i = 0; i < 10; i++)
            {
                Ziehungen.Add(ziehung.Ziehen());
            }

           
            Zeigen(Ziehungen);
            MGZahl(Ziehungen, AlleNummer);
            NGZahl(AlleNummer);
            Console.ReadLine();
        }

        static void Zeigen(List<List<int>>Ziehungen)
        {
            foreach (var item in Ziehungen)
            {
                foreach (int nummer in item)
                {
                    Console.Write(" "+nummer);
                }
                Console.WriteLine();
                Console.WriteLine("_______________");
            }
        }
        static void MGZahl(List<List<int>> Ziehungen, Hashtable  hashtable)
        {
            int zaehler = 0;
            int maxValue = 0;
            int maxZahl = 0;

            for (int i = 1; i < 50; i++)
            {
                foreach (var ziehung in Ziehungen)
                {
                    foreach (int nummer in ziehung)
                    {
                        if (i == nummer)
                        {
                            if (hashtable.ContainsKey(i))
                            {
                                hashtable[i]= Convert.ToInt32(hashtable[i])+1;
                            }
                            else
                            {
                                hashtable[i] = 1;
                            }
                        }
                    }
                }
            }
            //foreach (var Ziehung in Ziehungen)
            //{
                
            //    foreach (int nummer in Ziehung)
            //    {
            //        zaehler = 0;
            //        foreach (var andereZiehung in Ziehungen)
            //        {                        
            //            if (andereZiehung.Contains(nummer))
            //            {
            //                zaehler++;
            //            }
            //        }
            //        if (hashtable.ContainsKey(nummer))
            //        {
            //            hashtable[nummer] = Convert.ToInt32(hashtable[nummer]) + zaehler;
            //        }
            //        else
            //        {
            //            hashtable.Add(nummer, zaehler);
            //        }
                    
                   
            //    }
                
            //}

            //for (int i = 0; i < hashtable.Count; i++)
            //{
            foreach (var zahl in hashtable.Keys)
            {

                if (Convert.ToInt32(zahl) > maxValue)
                {
                    maxValue = Convert.ToInt32(hashtable[zahl]);
                    maxZahl = Convert.ToInt32(zahl);
                }
            }
               
            
            Console.WriteLine($"Der Zahl {maxZahl} hat {maxValue} mal wiederholt.");
        }

        static void NGZahl(Hashtable hashtable)
        {
            for (int i = 1; i <= 49; i++)
            {
                if (!hashtable.ContainsValue(i))
                {
                    Console.WriteLine($"Der Zahl {i} ist noch gar nicht gezogen wird.");
                }
                
            }
            
        }
         
    }
}
