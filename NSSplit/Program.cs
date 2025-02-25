using System;

namespace NSSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет. Меня зовут Евгений. Я прохожу курс.";
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}