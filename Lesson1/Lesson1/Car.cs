using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
   class Car
    {
       public void Ride()
        {
            Console.WriteLine("I'm riding");
            var navigator = new GpsNavigator();
            navigator.GetDistance();
        }
        
    }
}
