using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class SolarSystem
    {
        public Star CentralStar { get; set; }
        public List<Planet> planets = new();

        public SolarSystem(){}

        public void Go()
        {
            CentralStar.Shine();
            foreach(Planet planet in planets)
            {
                planet.Rotate();
            }
        }
    }

    abstract class Star
    {
        public float Mass { get; set; }
        public float Luminosity { get; set; }
        public string Name { get; set; }

        public Star(string Name, float Mass, float Luminosity)
        {
            this.Name = Name;
            this.Mass = Mass;
            this.Luminosity = Luminosity;
        }

        public abstract void Shine();

        public void Shine(int a)
        {
            Console.WriteLine(Luminosity * a);
        }

    }

    class BrownDwarf : Star
    {
        public BrownDwarf(string Name, float Mass, float Luminosity) : base(Name,Mass,Luminosity)
        {

        }

        public override void Shine()
        {
            Console.WriteLine($"{Name}: I'm trying :(");
        }
    }

    class Supernova : Star
    {
        public int Age { get; set; }
        public Supernova(string Name, float Mass, float Luminosity, int Age) : base(Name, Mass, Luminosity)
        {
            this.Age = Age;
        }

        public override void Shine()
        {
            Console.WriteLine($"{Name}: Watch me, dude!");
        }
    }

    class NeutronStar : Star
    {
        public int Age { get; set; }
        public NeutronStar(string Name, float Mass, float Luminosity, int Age) : base(Name, Mass, Luminosity)
        {
            this.Age = Age;
        }

        public override void Shine()
        {
            Console.WriteLine($"{Name}: No way, bruh");
        }
    }

    class Nebula
    {
        public Nebula(Star star)
        {

        }
        public Nebula(params Star [] stars)
        {

        }
    }
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

    class TerrestrialPlanet : Planet
    {
        public TerrestrialPlanet(string Name, float Mass) : base(Name, Mass)
        {

        }

        public override void Rotate()
        {
            Console.WriteLine($"{Name}: Ok");
        }
    }

    class IceGiant : Planet
    {
        public IceGiant(string Name, float Mass) : base(Name, Mass)
        {

        }

        public override void Rotate()
        {
            Console.WriteLine($"{Name}: Ice Ice");
        }
    }

    class GasPlanet : Planet
    {
        public GasPlanet(string Name, float Mass) : base(Name, Mass)
        {

        }

        public override void Rotate()
        {
            Console.WriteLine($"{Name}: Nope");
        }
    }

    class Universe
    {
        static void Main(string[] args)
        {
            SolarSystem solarSystem = new();

            solarSystem.CentralStar = new Supernova("xa12", 123.4f, 5687990.9f, 98499839);
            solarSystem.planets.Add(new TerrestrialPlanet("Earth", 123123.2312f));
            solarSystem.planets.Add(new IceGiant("Icy", 123131.2f));

            solarSystem.Go();
        }
    }
}
