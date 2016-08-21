using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class AgeTester
    {
       public static void anket()
        {
            while (true)
            {
                Console.WriteLine("Скокка тибе лет: 6, 10, многа");
                string mneLet = Console.ReadLine();
                sw1(mneLet);
                Console.ReadLine();
            }

        }

        static void sw1(string s)
        {
            switch (s)
            {
                case "6":
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
