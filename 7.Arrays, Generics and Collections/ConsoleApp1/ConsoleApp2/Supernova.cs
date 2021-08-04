using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Supernova : Star
    {
        public int Age { get; set; }
        public Supernova(string Name, float Mass, float? Luminosity, int Age) : base(Name, Mass, Luminosity)
        {
            this.Age = Age;
        }

        public override void Shine()
        {
            Console.WriteLine($"{Name}: Watch me, dude!");
        }
    }
}
