using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab51
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string[] menu1 = { "1. ИУЦТ", "2. ИТТСУ", "3. ИЭФ", "4. ИТТСУ", "5. ИКБ", "6. ЮИ", "7. ИПСС", "8. АВИШ", "9. Далее" };
            string[] menu2 = { "1. Администрация", "2. Профсоюз", "3. ИМТК", "4. Пиццерия", "5. Дом физики", "6. Дом спорта", "7. Дворец культуры" };

            int currentPage = 1; // Текущая страница меню
            int currentIndex = 0; // Индекс текущего пункта меню
            bool confirm = false; // Подтверждение выбора пункта меню

            while (!confirm) //Условие while (!confirm) означает, что цикл while будет выполняться,
                             //пока значение переменной confirm не станет true.
                             //Пока пользователь не подтвердит выбранный пункт меню, цикл будет продолжаться
            {
                Console.Clear(); // Очистка консоли
                Console.WriteLine("Выберите учебный корпус РУТ (МИИТ) из списка:\n");

                if (currentPage == 1)
                {
                    Console.WriteLine("---- Первая страница ----");
                    DisplayMenu(menu1, currentIndex);
                }
                else if (currentPage == 2)
                {
                    Console.WriteLine("---- Вторая страница ----");
                    DisplayMenu(menu2, currentIndex);
                }

                ConsoleKeyInfo key = Console.ReadKey();//считывает пользовательский ввод с клавиатуры и сохраняет его в переменной key типа ConsoleKeyInfo.
                switch (key.Key) //для проверки значения свойства Key объекта key
                {
                    case ConsoleKey.UpArrow:
                        currentIndex = (currentIndex == 0) ? GetMenuLength(currentPage) - 1 : currentIndex - 1; // Пролистывание вверх
                       //Если текущий индекс, если он равен 0 (первый пункт меню), то присваивает ему значение - 1.
                       //В противном случае значение индекса уменьшается на 1.

                        break;
                    case ConsoleKey.DownArrow:
                        currentIndex = (currentIndex == GetMenuLength(currentPage) - 1) ? 0 : currentIndex + 1; // Пролистывание вниз
                        //Проверяет текущий индекс, если он равен GetMenuLength(currentPage) - 1 (последний пункт меню), то присваивает ему значение 0,
                        //что означает переход к первому пункту меню. В противном случае,
                        //значение индекса увеличивается на 1, что приводит к пролистыванию меню вниз.
                        break;
                    case ConsoleKey.D0:
                        currentIndex = 0; // Переход к началу меню
                        break;
                    case ConsoleKey.Y:
                        confirm = true; // Подтверждение выбранного пункта меню
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D4:
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:
                        int num = (int)key.Key;//получаем числовое значение пункта меню
                        if (num <= GetMenuLength(currentPage))//проверка на нахождение этого индекса на странице
                        {
                            currentIndex = num - 1; // Выбор пункта меню по нажатию цифровой клавиши
                            confirm = true;
                        }
                        break;
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    currentPage = (currentPage == 1) ? 2 : 1; // Переключение на предыдущую страницу
                    currentIndex = 0; // Сброс текущего индекса
                   //сли текущая страница равна 1, то устанавливаем значение 2, что означает переключение на предыдущую страницу.
                   //Если текущая страница равна 2, то устанавливаем currentPage в значение 1, что означает переключение на следующую страницу.

                    currentIndex = 0;
                    //Здесь мы сбрасываем текущий индекс(currentIndex) в 0, так как при переключении страницы мы начинаем с первого пункта меню.
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    currentPage = (currentPage == 2) ? 1 : 2; // Переключение на следующую страницу
                    //Если текущая страница равна 2, то устанавливаем currentPage в значение 1,
                    //что означает переключение на следующую страницу. Если текущая страница равна 1,
                    //то устанавливаем currentPage в значение 2, что означает переключение на предыдущую страницу.
                    currentIndex = 0; // Сброс текущего индекса
                }
            }
            Console.Clear(); // Очистка консоли

            if (currentPage == 1)
            {
                Console.WriteLine("Выбран пункт первой страницы меню:");
                Console.WriteLine(menu1[currentIndex]);
            }
            else if (currentPage == 2)
            {
                Console.WriteLine("Выбран пункт второй страницы меню:");
                Console.WriteLine(menu2[currentIndex]);
            }

            Console.ReadLine();
        }

        // Вывод пунктов меню с выделением текущего пункта
        static void DisplayMenu(string[] menu, int currentIndex)
        {
            for (int i = 0; i < menu.Length; i++)
            {
                if (i == currentIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(menu[i]);
            }
        }

        // Получение количества пунктов меню на текущей странице
        static int GetMenuLength(int currentPage)
        {
            return (currentPage == 1) ? 9 : 7;
        }
        //возвращает количество пунктов меню на текущей странице.
        //Она принимает значение currentPage и возвращает 9,
        //если currentPage равно 1, и 7, если currentPage равно 2.
    }
}



