using System;

namespace Lesson1
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();

            for (int i = 0; i > -10; i--)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();

            const int f = 100;
            Console.Write(f);

            Console.ReadLine();
        }
    }
}
