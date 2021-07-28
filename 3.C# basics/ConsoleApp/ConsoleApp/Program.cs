using System;

namespace ConsoleApp
{

    //Value type
    public struct MyFavoriteStruct
    {
        public int numField;
        public bool boolField;
        public string structName;

        public override string ToString()
        {
            return $"{structName}: {numField} {boolField}";
        }

        //No atribute modifier
        public static void NoAtribute(MyFavoriteStruct a)
        {
            a.numField = 10;
            a.boolField = true;
            a.structName = "Custom name";
        }
        //Ref modifier
        public static void RefAtribute(ref MyFavoriteStruct a)
        {
            a.numField = 100;
            a.boolField = true;
            a.structName = "Cool name";
        }
        //Out modifier
        public static void OutAtribute(out MyFavoriteStruct a)
        {
            a = new MyFavoriteStruct()
            {
                numField = 1000,
                boolField = true,
                structName = "Coolest Name"
            };
        }
    }

    //Reference type
    public class Car
    {
        private int horsePower { get; set; }
        private int price { get; set; }
        private static int numbersSold;
        public Car(int horsePower=90, int price = 11500)
        {
            numbersSold++;
            this.horsePower = horsePower;
            this.price = price;
        }

        //Static Method
        public static int HowMany()
        {
            return numbersSold;
        }
        
    }

    //Static constructor => Example: Singleton design pattern
    class Singleton
    {
        //A private constructor ensures that no other instance can be created
        private Singleton() { }

        // The Singleton's instance is stored in a static field
        private static Singleton _instance;

        // The static method that controls the access to the singleto instance
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    //Say hello to the world
    class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Methods with different attribute modifiers
            MyFavoriteStruct firstStruct = new MyFavoriteStruct();
            MyFavoriteStruct secondStruct;

            Console.WriteLine(firstStruct);

            MyFavoriteStruct.NoAtribute(firstStruct);
            Console.WriteLine(firstStruct);

            MyFavoriteStruct.RefAtribute(ref firstStruct);
            Console.WriteLine(firstStruct);

            MyFavoriteStruct.OutAtribute(out secondStruct);
            Console.WriteLine(secondStruct);


            //Reference type and static methods
            Car DaciaLogan = new Car();
            Car AudiA5 = new Car(286,41400);

            Console.WriteLine(Car.HowMany());

            //Boxing
            object boxed = firstStruct;
            Console.WriteLine(boxed.GetHashCode());

            //Unboxing
            MyFavoriteStruct unboxed = (MyFavoriteStruct)boxed;
            MyFavoriteStruct x = unboxed;

            //Checking that x and the unboxed result are the same;
            Console.WriteLine(firstStruct);
            Console.WriteLine(x);

            
        }
    }
}
