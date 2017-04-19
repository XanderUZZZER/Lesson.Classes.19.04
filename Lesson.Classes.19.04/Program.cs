using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Classes._19._04
{
    class Test1
    {
        public const double PI = 3.14;
        public readonly double E;

        public Test1 ()
        {
            E = 2.7;
        }

        public Test1 (double a)
        {
            E = a;
        }
    }

    class Test2
    {
        public void M()
        {
            Console.WriteLine("M");
            //throw new NullReferenceException();
        }
    }

    class InvalidInputException : ApplicationException
    {
        public InvalidInputException()
            :base()
        {

        }
        public InvalidInputException(string message)
            : base(message)
        {

        }
    }

    class Connection : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose"); ;
        }

        ~Connection()
        {
            Console.WriteLine("Connection closed \nFinaliztor");
        }

        
    }

    class Names
    {
        private string[] array = new string[4];

        public Names()
        {
            array = new string[] { "awfwerf", "wefwef", "fwef", "wefwef" };
        }

        public string this [int index]
        {
            get { return array[index]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Names test = new Names();
            Console.WriteLine(test[0]);

            //Connection connection1 = new Connection();
            //connection1.Dispose();
            //Console.ReadLine();
            //Test1 test1 = new Test1();
            //Console.WriteLine(test1.E);
            //Console.WriteLine(Test1.PI); // Console.WriteLine(test1.PI); Use type instead

            //Test1 test2 = new Test1(6);
            //Console.WriteLine(test2.E);
            //Console.WriteLine(Test1.PI); // Console.WriteLine(test2.PI); Use type instead

            //double result = 0;
            //int n = 0;
            //int x = 1;
            //try
            //{
            //    //n = int.Parse(Console.ReadLine());
            //    //x = int.Parse(Console.ReadLine());

            //    result = n / x;
            //    try
            //    {
            //       int x2 = int.Parse(Console.ReadLine());
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Inner Format exception is here! Try once again");
            //        //Main(null);
            //    }
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Result / 1 ");
            //    result = n / 1;
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("outer Format exception is here! Try once again");
            //    Main(null);
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Argument null exeption");
            //}

            //Console.WriteLine(n);
            //try
            //{
            //    int x = int.Parse(Console.ReadLine());

            //}
            //catch
            //{
            //    Console.WriteLine("Exception handled");
            //}
            //finally
            //{
            //    Console.WriteLine("Always execute");
            //}

            //try
            //{
            //    throw new InvalidInputException();
            //}
            //catch(InvalidInputException)
            //{
            //    Console.WriteLine("InvalidInputException");
            //}


            //Console.ReadLine();
        }
    }
}
