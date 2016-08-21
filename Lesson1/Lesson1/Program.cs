using System;

namespace Lesson1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var jiguli = new Car("Жигули");
            var moskvich = new Car("Москвич");

            jiguli.Ride();
            moskvich.Ride();

            Console.ReadLine();
        }
    }
}
