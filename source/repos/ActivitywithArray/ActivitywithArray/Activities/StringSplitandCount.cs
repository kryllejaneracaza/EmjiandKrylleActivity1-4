using System;
using ActivitywithArray.Interface;

namespace ActivitywithArray.Activities
{
    internal class StringSplitandCount : ActivityInterface
    {
        public void Run()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Sentence: \"{sentence}\"");
            Console.WriteLine($"Word count: {words.Length}");
        }
    }
}
