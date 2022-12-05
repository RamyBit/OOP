using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenMeschen
{
    class Staple
    {
        private Stack<Karte> staple = new Stack<Karte>();
        //private Stack<Karte>[] geteilteStaplen = new Stack<Karte>[4];

        public Stack<Karte> GetStaple()
        {
            return this.staple;
        }

        //public void GetTeilen(out Stack<Karte>[] teilen)
        //{
        //    teilen = geteilteStaplen;
        //    geteilteStaplen = null;
        //}

        public void add(string[] kartenWert, string farbe)
        {
            foreach (string karteWert in kartenWert)
            {
                staple.Push(new Karte() { Wert = karteWert, Farbe = farbe });
            }
        }
        public void MischenMit( Staple staple2)
        {
            
            if (staple.Count == 0)
            {
                staple = staple2.GetStaple();
            }
            else
            {
                foreach (Karte karte in staple2.GetStaple())
                {
                    staple.Push(karte);
                }
            }
               
        }
        public void Zeigen()
        {
            foreach (Karte karte in this.staple)
            {
                Console.WriteLine($"{karte.Wert} {karte.Farbe}");
            }
        }

        public Stack<Karte>[] Teilen()
        {
            Stack<Karte>[] geteilteStaplen = new Stack<Karte>[4];
            Stack<Karte> teil1 = new Stack<Karte>();
            Stack<Karte> teil2 = new Stack<Karte>();
            Stack<Karte> teil3 = new Stack<Karte>();
            Stack<Karte> teil4 = new Stack<Karte>();
            int teilen = staple.Count / 4;
            for (int i = 0; i < teilen; i++)
            {
                teil1.Push(staple.Peek());
                staple.Pop();
            }

            for (int i = 0; i < teilen; i++)
            {
                teil2.Push(staple.Peek());
                staple.Pop();
            }
            for (int i = 0; i < teilen; i++)
            {
                teil3.Push(staple.Peek());
                staple.Pop();
            }
            for (int i = 0; i < teilen; i++)
            {
                teil4.Push(staple.Peek());
                staple.Pop();
            }
            geteilteStaplen[0] = teil1;
            geteilteStaplen[1] = teil2;
            geteilteStaplen[2] = teil3;
            geteilteStaplen[3] = teil4;
            return geteilteStaplen;
        }

        // Staple muss zuerst gteilt wirden bevor abgeheben wird
        public void Abheben(Stack<Karte> st_01, Stack<Karte> st_02, Stack<Karte> st_03, Stack<Karte> st_04)
        {
            List<Karte> zielListe = new List<Karte>();

            zielListe.AddRange(st_01.ToArray());
            zielListe.AddRange(st_03.ToArray());
            zielListe.AddRange(st_02.ToArray());
            zielListe.AddRange(st_04.ToArray());
            foreach (Karte karte in zielListe)
            {
                staple.Push(karte);
            }

        }
    }
}
