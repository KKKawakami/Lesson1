using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.CoffeeMachine
{
    class CoffeeMachine
    {
        public string _choese;
        public static void menu()
        {
            
        while (true)
            {
                Console.WriteLine("1)Latte/n2)Americano/n3)Bylionchik/n4Turn Off");
                string choese = Console.ReadLine();
                _choese = choese;
                //sw1(choese);
            }

        }

        static void sw1(string s)
        {
            switch (s)
            {
                case "1":
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Бро");
                    break;
                case "10":
                    Console.WriteLine("Старший бро");
                    break;
                case "многа":
                    Console.WriteLine("О.Л.Д.фаг");
                    break;
                default:
                    Console.WriteLine(":P");
                    break;
            
            }
        }
    }
}
