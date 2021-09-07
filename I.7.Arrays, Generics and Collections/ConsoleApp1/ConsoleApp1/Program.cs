using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementation of the generic colection type

            MyCollection<string> myDemoCollection = new();
            myDemoCollection.Add("3a");
            myDemoCollection.Add("4b");
            myDemoCollection.Add("5c");

            Console.WriteLine(myDemoCollection);

            Console.WriteLine(myDemoCollection.GetItemAtIndex(0));

            myDemoCollection.SetItemAtIndex(0, "1231313");

            Console.WriteLine(myDemoCollection);

            myDemoCollection.Swap(0, 1);

            Console.WriteLine(myDemoCollection);

            myDemoCollection.Swap("4b", "5c");

            Console.WriteLine(myDemoCollection);

        }
    }
}
