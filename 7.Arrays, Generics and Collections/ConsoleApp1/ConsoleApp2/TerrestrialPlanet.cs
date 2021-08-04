using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TerrestrialPlanet : Planet
    {
        public TerrestrialPlanet(string Name, float Mass) : base(Name, Mass){}
        public override void Rotate()
        {
            Console.WriteLine($"{Name}: Ok");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
