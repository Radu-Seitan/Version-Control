using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        //A basic program that reads line from an input file, writes them in the output type and prints them on screen.
        static void Main(string[] args)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(@"C:\Users\radu.seitan\source\repos\Version-Control\9.File system and streams\input.txt");
                writer = new StreamWriter(@"C:\Users\radu.seitan\source\repos\Version-Control\9.File system and streams\output.txt");
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    writer.WriteLine(line);
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) 
            { 
                Console.WriteLine(e.Message); 
            }
            finally 
            {
                if (reader != null && writer != null)
                {
                    reader.Close();
                    writer.Close();
                }
            }
        }
    }
}
