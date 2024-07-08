using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndStructures
{
    internal class Task1
    {
        public static void Run()
        {
            //1) Создать двумерный массив целых чисел размером 5х4.
            //Заполнить его случайными числами. Найти максимальный
            //и минимальный элемент в массиве.Найти максимальный
            //и минимальный элемент для каждой строки массива.
            Console.WriteLine("1 задание");
            Random rand = new Random();
            int rows = 5;
            int cols = 4;

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    array[i, j] = rand.Next(0, 50);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            FindMinAndMax(array);
            FindMinAndMaxOne(array);

        }

        public static void FindMinAndMax(int[,] array)
        {
            int min = array[0, 0];
            int max = array[0, 0];

            foreach (int value in array)
            {
                if (value < min)
                {
                    min = value;
                }
                if (value > max)
                {
                    max = value;
                }
            }

            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
        }

        public static void FindMinAndMaxOne(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int[] minPerRow = new int[rows];
            int[] maxPerRow = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                minPerRow[i] = array[i, 0];
                maxPerRow[i] = array[i, 0];

                for (int j = 1; j < cols; j++)
                {
                    if (array[i, j] < minPerRow[i])
                    {
                        minPerRow[i] = array[i, j];
                    }
                    if (array[i, j] > maxPerRow[i])
                    {
                        maxPerRow[i] = array[i, j];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Минимальный элемент: {minPerRow[i]}, Максимальный элемент: {maxPerRow[i]}");
            }
        }
    }
}
