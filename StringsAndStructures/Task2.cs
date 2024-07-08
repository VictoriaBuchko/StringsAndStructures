using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndStructures
{
    internal class Task2
    {
        public static void Run()
        {
            //2) Напишите программу, которая принимает строку от пользователя и меняет
            //регистр всех букв в этой строке на противоположный
            //(то есть большие буквы становятся маленькими, а маленькие буквы - большими).
            Console.WriteLine("\n2 задание");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            char[] invertedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    invertedChars[i] = char.ToUpper(input[i]);
                }
                else if (char.IsUpper(input[i]))
                {
                    invertedChars[i] = char.ToLower(input[i]);
                }
                else
                {
                    invertedChars[i] = input[i];
                }
            }
            string invertedString = new string(invertedChars);
            Console.WriteLine($"Результат: {invertedString}");
        }
    }
}
