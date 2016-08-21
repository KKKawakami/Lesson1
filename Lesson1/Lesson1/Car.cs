using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Car
    {
       string _name;

        public Car(string nameOfCar)
        {
            _name = nameOfCar;
        }

       public void Ride()
        {
            Console.WriteLine("I'm riding "+_name);

            var navigator = new GpsNavigator();
            navigator.GetDistance();
        }
        
    }
}
