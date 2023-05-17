using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14 вариант");
            Console.WriteLine("Задание 1.Подсчитать, какое количество слов в тексте начинается на букву «а». Слова обязательно \r\nразделены пробелом. В качестве текста для тестового примера (тестовых примеров) взять \r\nне менее двух предложений.");
            Console.WriteLine("Предложение: Apple is a fruit, and a very tasty one. Anna ate an apple for breakfast");
            string text = "Apple is a fruit, and a very tasty one. Anna ate an apple for breakfast.";
            int count = 0;

            // Разделить текст на слова, используя пробел в качестве разделителя
            string[] words = text.Split(' ');

            // Пройти по каждому слову и проверить, начинается ли оно на букву "a"
            foreach (string word in words)
            {
                if (word.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            // Вывести количество найденных слов, начинающихся на "a"
            Console.WriteLine("Количество слов, начинающихся на 'a': " + count);

            Console.WriteLine("Задание 2.Составить программу, которая заменяет во всей строке все римские числа на \r\nсоответствующие им двоичные числа.");


            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // массив римских чисел и соответствующих им двоичных чисел
            string[] romanNums = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] decimalNums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            // замена римских чисел на соответствующие им двоичные числа
            for (int i = 0; i < romanNums.Length; i++)
            {
                while (input.Contains(romanNums[i]))//проверяет, содержит ли строка input римское число romanNums[i].
                {
                    input = input.Replace(romanNums[i], Convert.ToString(decimalNums[i], 2));//заменяет все вхождения римского числа romanNums[i]
                                                                  //в строке input на его двоичное представление Convert.ToString(decimalNums[i], 2).
                                                                 //Convert.ToString(decimalNums[i], 2) преобразует десятичное число decimalNums[i]
                                                                 //в его двоичную строку.
                }
            }

            Console.WriteLine($"Результат замены: {input}");




        }
        }


    }


