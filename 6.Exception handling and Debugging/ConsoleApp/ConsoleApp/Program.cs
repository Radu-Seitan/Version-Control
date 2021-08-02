#define MYCONDITION
using System;
using System.Diagnostics;

namespace ConsoleApp
{
    class MustBeIntVar
    {
        object a;
        public MustBeIntVar(object a)
        {
            this.a = a;
        }

        public static MustBeIntVar TakeExternalVar(object a)
        {
            return new MustBeIntVar(a);
        }

        [Conditional("MYCONDTION")]
        public void doSomething()
        {
            Console.WriteLine("Hello");
        }
    }

    class NotANumberException : Exception
    {
        public NotANumberException(string message) : base (message) {}
    }

    class NotAnIntException : NotANumberException
    {
        public NotAnIntException(string message) : base(message){}
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Program x = new();
                //double x = 3.2f;
                int x = 10;

                if (!((x is int) || (x is Double))) throw new NotANumberException("External variable is not a number");
                if (!(x is int)) throw new NotAnIntException("External variable is not an int");
                MustBeIntVar exampleVar = MustBeIntVar.TakeExternalVar(x);
                exampleVar.doSomething();
            }
            catch (NotAnIntException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (NotANumberException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.WriteLine("Execution ready");
            }
        }
    }
}
