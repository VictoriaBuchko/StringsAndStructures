using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndStructures
{
    internal class Task4
    {
        public static void Run()
        {
            //4) Дан текст. Верно ли, что в нем есть пять идущих подряд одинаковых символов?
            //Вывести соответствующее сообщение.
            Console.WriteLine("\n4 задание");
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            bool fiveChars = false;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                string pattern = new string(c, 5);
                if (text.Contains(pattern))
                {
                    fiveChars = true;
                    break;
                }
            }

            if (fiveChars)
            {
                Console.WriteLine("Есть 5 повторений");
            }
            else
            {
                Console.WriteLine("Нет 5 повторений");
            }

        }
    }
}
