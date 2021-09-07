using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SolarSystem
    {
        public Galaxy Location { get; set; }
        public Star CentralStar { get; set; }
        public List<Planet> Planets = new();

        public SolarSystem(Galaxy Location)
        {
            this.Location = Location;
        }

        public void Go()
        {
            CentralStar.Shine();
            foreach (Planet planet in Planets)
            {
                planet.Rotate();
            }
        }
    }
}
