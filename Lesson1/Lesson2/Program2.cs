using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Katya Daineko";
            var age = 22;
            var isProgrammer = true;

            // Определяем тип переменных
            //Хотя я без понятия почму типы станут именно такими
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isProgrammerType = isProgrammer.GetType();

            // Выводим в консоль результаты
            Console.WriteLine("Тип name: {0}", nameType);
            Console.WriteLine("Тип age {0}", ageType);
            Console.WriteLine("Тип isProgrammer {0}", isProgrammerType);
            Console.ReadLine();
        }
    }
}