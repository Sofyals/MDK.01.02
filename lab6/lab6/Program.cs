using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 14");
            Console.WriteLine("Задание 1.Взять любой текстовый файл и найти в нём все слова, которые в точности равны значению средней длины слов в этом файле. Сохранить слова в переменную с разделителем «, », вывести в консоль и записать в том же виде в новый файл.\r\n\r\n");

            Console.WriteLine("Введите текстовые данные:");
            string inputText = Console.ReadLine();

            // Разделители слов
            char[] separators = { ' ', '\n', '\r', '\t' };

            // Разбиение введенного текста на слова
            string[] words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Вычисление средней длины слова
            double averageLength = words.Average(w => w.Length);

            // Поиск слов с длиной, равной средней длине
            var foundWords = words.Where(w => w.Length == averageLength);

            // Вывод найденных слов в консоль
            Console.WriteLine("Найденные слова:");
            foreach (var word in foundWords)
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();

            // Запись найденных слов в новый файл
            Console.WriteLine("Введите путь к новому файлу для сохранения результатов:");
            string outputFilePath = Console.ReadLine();
            File.WriteAllText(outputFilePath, string.Join(", ", foundWords));

            Console.WriteLine("Результаты сохранены в новом файле.");
        }

    }
}

