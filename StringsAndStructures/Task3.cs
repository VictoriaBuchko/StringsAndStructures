using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndStructures
{
    internal class Task3
    {
        public static void Run()
        {
            //3) Напишите программу, которая принимает строку, содержащую несколько слов,
            //и разделяет ее на отдельные слова.
            Console.WriteLine("\n3 задание");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            char[] separators = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
