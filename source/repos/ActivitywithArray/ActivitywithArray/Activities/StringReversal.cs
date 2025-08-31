using System;
using ActivitywithArray.Interface;

namespace ActivitywithArray.Activities
{
    internal class StringReversal : ActivityInterface
    {
        public void Run()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reversed = ReverseString(word);

            Console.WriteLine($"Original: {word}");
            Console.WriteLine($"Reversed: {reversed}");
        }

        private string ReverseString(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
