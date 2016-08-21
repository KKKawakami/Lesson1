using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Garage
    {
        Car _car;

       public string ListCarsInGarage()
        {
            if(_car != null)
            {
                return "In garage: " + _car._name;
            }
            else
            {
                return "No cars in garage";
            }
            
        }

       public void PutCarInGarage(Car inputCar)
        {
            _car = inputCar;
        }
    }
}
