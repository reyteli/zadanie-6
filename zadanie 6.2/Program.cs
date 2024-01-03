using System;

namespace zadanie_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            string words = s.ToLower();
            string[] hasil = words.Split(' ');
            foreach (string temp in hasil)
            {
                string str = string.Empty;
                int x = temp.Length;

                for (int y = x - 1; y >= 0; y--)
                {
                    str = str + temp[y];
                }

                int count = 0;
                if (str == temp)
                {
                    count++;
                    Console.WriteLine(temp + " Это полиндром = " + count);

                }
                i++;
            }
        }
    }
}
