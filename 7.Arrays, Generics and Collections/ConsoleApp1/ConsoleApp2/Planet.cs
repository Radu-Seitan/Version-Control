using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Planet
    {
        public float Mass { get; set; }
        public string Name { get; set; }

        public Planet(string Name, float Mass)
        {
            this.Name = Name;
            this.Mass = Mass;
        }

        public abstract void Rotate();

    }
}
