using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Star
    {
        public float Mass { get; set; }
        public float? Luminosity { get; set; }
        public string Name { get; set; }

        public Star(string Name, float Mass, float? Luminosity)
        {
            this.Name = Name;
            this.Mass = Mass;
            this.Luminosity = Luminosity ?? 0;
        }

        public abstract void Shine();

        public void Shine(int a)
        {
            Console.WriteLine(Luminosity * a);
        }

    }
}
