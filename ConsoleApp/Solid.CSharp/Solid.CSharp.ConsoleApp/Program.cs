using System;

namespace Solid.CSharp.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //basic();
            dataTypes();
        }

        private static void dataTypes()
        {
            int e = 10; //32 bit signed integer number
            short s = 10; //16 bit int number
            e = 65546;
            s = (short)e;
            Console.WriteLine("Int value = " + e);
            Console.WriteLine("short value = " + s);

            //char > int > long > float > double
            //implicit casting
            char c = 'C';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //explicit casting
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;
            c = (char)d;
        }

        private static void basic()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Name = " + name);
        }
    }
}