using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 03\n 14 вариант");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Вычислить N");
            Console.WriteLine("введите целое число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите целое число x");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите целое число a (начальное)");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите целое число ak (конечное)");
            int ak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите целое число ah (шаг)");
            int ah = Convert.ToInt32(Console.ReadLine());
            double N = 0;

            while (a <= ak)
            {
                a += ah;
                N = Math.Pow(X, 2) + (Math.Sqrt(Math.Pow(a, 2) + Math.Cos(a) - Math.Pow(b, 2)) / Math.Tan(a));
            }
            Console.WriteLine("N :");
            Console.WriteLine(Math.Round(N, 2));


            Console.WriteLine("Задание 2");
            Console.WriteLine("Вычислить N для элементов n ряда");
            
            // Запрашиваем у пользователя два числа x, а также длину ряда n
            Console.WriteLine("введите число: x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите длину ряда");
            double n = Convert.ToDouble(Console.ReadLine());
            N = -1.5;
            

            

            // Определяем функцию для вычисления факториала числа k
            double fa(double l)
            {
                if (l == 1) return 1;

                return l * fa(l - 1);
            }

            // Выполняем цикл для вычисления значения переменной a
            for (int i = 1, h = 15, g = 5,d = 1, k = 3, m = 1; i <= n; i++, h += 5, g+=5, k++, d+=d, m++)
            {
                // Если номер итерации нечетный
                if (g % 10 == 0)
                    N += (Math.Pow(fa(k) + g * Math.Pow(x, d), 1.0 / 3.0)) / Math.Sin(Math.Pow(x, m)) + h;
                // Если номер итерации четный
                else
                    N += (Math.Pow(fa(k) + g * Math.Pow(x, d), 1.0 / 3.0) )/ Math.Sin(Math.Pow(x, m)) - h;

            }

            // Выводим значение переменной a с округлением до двух знаков после запятой
            Console.WriteLine("N :");
            Console.WriteLine(Math.Round(N, 2));



        }

    }
}
