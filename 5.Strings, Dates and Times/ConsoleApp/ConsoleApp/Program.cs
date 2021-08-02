using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        //Strings
        static void Main(string[] args)
        {
            string myString = "      asda asdfgh asdada asdad     ";

            Console.WriteLine(myString);

            string trimmedString = myString.Trim(' ', 'a', 'd');

            Console.WriteLine(trimmedString + "\n");

            string[] words = trimmedString.Split(" ");

            Console.WriteLine("Words contained:");
            foreach(string el in words)
            {
                Console.WriteLine(el.ToUpper());
            }

            String finalWords = String.Join('*',words);

            Console.WriteLine(finalWords + "\n");

            //StringBuilder
            //StringBuilder is a type that represents a sequence of characters. Unlike String, the StringBuilder type is mutable.
            //Mutability means that once an instance of the class has been created, it can be modified by appending, removing, replacing, or inserting characters.

            StringBuilder sb = new StringBuilder();

            sb.Append("This is a sentence.");

            Console.WriteLine("StringBuilder:\n" + sb);

            StringBuilder sb2 = new StringBuilder("TTHIS");

            Console.WriteLine(sb2);

            Console.WriteLine(sb.Replace("This", sb2.ToString()) + "\n");


            //DateTime

            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddDays(24).AddHours(27).AddMinutes(12);

            TimeSpan t = d2 - d1;

            Console.WriteLine("DateTime\n" + d2);
            Console.WriteLine(t);

        }
    }
}
