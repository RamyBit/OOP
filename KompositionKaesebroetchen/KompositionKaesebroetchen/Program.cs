using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaese kase = new Kaese("Schafkäse");
            Haeppchen meins = new Haeppchen(new Broetchen("Normales Brötchen"), new Butter("Normale Butter"), new Kaese("Gouda mittlealt"), new Ei("Straußen-Ei"));
            meins.ZeigeInhalt();

            Haeppchen roberts = new Haeppchen(new Broetchen("Kaiser-Brötchen"), new Butter("Normale Butter"), new Kaese("Emmentaler"), new Ei("Hühner-Ei"));
            roberts.ZeigeInhalt();

            Haeppchen edwards = new Haeppchen(new Broetchen("gutes-Brötchen"), new Butter("Normale Butter"), new Kaese("Emmentaler"), new Ei("Straußen-Ei"));
            edwards.ZeigeInhalt();

            Haeppchen khangs = new Haeppchen(new Broetchen("körner-Brötchen"), new Butter("gesalzene Butter"), new Kaese("Gouda jung"), new Ei(""));
            khangs.ZeigeInhalt();
            // was passiert, wenn ich das häppchen-Objekt zerstöre?
            //khangs = null;
            //khangs.ZeigeInhalt();

            Console.Read();
        }
    }
}
