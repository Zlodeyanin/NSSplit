using System;

namespace NSSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет. Меня зовут Евгений. Я прохожу курс.";
            char whitespace = ' ';
            string[] words = text.Split(whitespace);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}