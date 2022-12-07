using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBeispielFlugzeug
{
    enum Schalter
    {
        Ein,
        Aus
    }
    class Flugzeug
    {
        private Random zfg = new Random();
        private Schalter motor = Schalter.Ein;
        public int Flughoehe { get; set; } = 10000;
        public string Name { get; set; } = "AirBoing 7+7";
        public int Oeldruck { get; set; }
        public event EventHandler<EventArgs> OelDruckMesser;

        public virtual void OnEventEintritt(object source, EventArgs args)
        {
            if (source != null)
            {
                Console.WriteLine("Ops der Öldruck ist zu niedring"+
                    "ich schalte mal den Motor ab");
                this.MotorZustandAendern();
                Console.WriteLine(motor.ToString());
            }
        }

        public void FliegHerum()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Oeldruck = zfg.Next(0, 101);

                if (Oeldruck < 10)
                {
                    OelDruckMesser(this, new EventArgs());
                }
            }
        }
        public void MotorZustandAendern()
        {
            Console.WriteLine("MotoZustand geändert wird.");
        }
    }
}
