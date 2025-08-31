using System;
using ActivitywithArray.Interface;

namespace ActivitywithArray.Activities
{
    internal class ArrayManipulation : ActivityInterface
    {
        public void Run()
        {
            int[] numbers = { 10, 25, 5, 47, 30 };

            // Largest value
            int largest = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largest)
                    largest = num;
            }
            Console.WriteLine($"Largest value: {largest}");

            // Reverse using iteration
            Console.Write("Reversed array: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
