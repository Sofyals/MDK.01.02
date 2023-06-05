using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14 вариант");
            Console.WriteLine("Задание 1.Проверьте соотношение");
            if (Math.Acos(1 / 2) == 60)
            {
                Console.WriteLine("Yes");

            }
            else 
            { 
                Console.WriteLine("No");
            }
            Console.WriteLine("Задание 2.Вычислите");
            double a = ((Math.Pow((((85 + (7 / 30)) - (85 + (5 / 18))) / (2 + (2 / 3))) / 0.04, 1.0 / 4.0)) + (((140 + (7 / 30) - 138 + (5 / 12) / 18 + (1 / 6))) / (0.02 + (1 / 5))) - 1.45 - Math.Pow((1 / 3), 1.0 / 5.0));
      
            Console.WriteLine(Math.Round(a, 2));


        }
    }
}
