using System;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadLine();
        }
    }
}
