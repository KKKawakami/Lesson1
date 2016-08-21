using System;

namespace Lesson1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var jiguli = new Car("Жигули");
            var moskvich = new Car("Москвич");
            var garage1 = new Garage();

            garage1.PutCarInGarage(moskvich);
            Console.WriteLine(garage1.ListCarsInGarage());
            Console.ReadLine();
        }
    }
}
