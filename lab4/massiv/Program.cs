using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вариант 14");
            Console.WriteLine("задание 1.Вывести трёхмерный массив «змейкой». Первый элемент расположить в левом верхнем углу окна \r\nконсоли.");

            int[,,] array3D = new int[3, 3, 3]
{
    {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}},
    {{10, 11, 12}, {13, 14, 15}, {16, 17, 18}},
    {{19, 20, 21}, {22, 23, 24}, {25, 26, 27}}
};

            int xSize = array3D.GetLength(0);
            int ySize = array3D.GetLength(1);
            int zSize = array3D.GetLength(2);

            Console.WriteLine("{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}},\r\n{{10, 11, 12}, {13, 14, 15}, {16, 17, 18}},\r\n{{19, 20, 21}, {22, 23, 24}, {25, 26, 27}}");

            for (int z = 0; z < zSize; z++)

            {
                Console.WriteLine("Layer " + (z + 1) + ":");
                if (z % 2 == 0)
                {
                    for (int y = 0; y < ySize; y++)
                    {
                        for (int x = 0; x < xSize; x++)
                        {
                            Console.Write(array3D[x, y, z] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int y = ySize - 1; y >= 0; y--)
                    {
                        for (int x = xSize - 1; x >= 0; x--)
                        {
                            Console.Write(array3D[x, y, z] + " ");
                        }
                        Console.WriteLine();
                    }
                }

            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("задание 2.Найти сумму элементов одномерного массива, стоящих между первым и последним нулевыми элементами.");

            int[] array = { 2, 4, 0, 3, 0, 7, 8, 0, 1 };
            int firstZeroIndex = -1;
            int lastZeroIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    if (firstZeroIndex == -1)
                    {
                        firstZeroIndex = i;
                    }
                    lastZeroIndex = i;
                }
            }

            if (firstZeroIndex == -1 || lastZeroIndex == -1)
            {
                Console.WriteLine("В массиве нет нулевых элементов.");
            }
            else
            {
                int sum = 0;
                for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine("2, 4, 0, 3, 0, 7, 8, 0, 1");
                Console.WriteLine($"Сумма элементов между первым и последним нулями: {sum}");
            }
        }
    }
}
