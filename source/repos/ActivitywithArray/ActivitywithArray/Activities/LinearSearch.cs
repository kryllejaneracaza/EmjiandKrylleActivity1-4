using System;
using ActivitywithArray.Interface;

namespace ActivitywithArray.Activities
{
    internal class LinearSearch : ActivityInterface
    {
        public void Run()
        {
            int[] numbers = { 3, 7, 11, 19, 25 };
            Console.Write("Enter a number to search: ");
            int target = int.Parse(Console.ReadLine());

            int index = Search(numbers, target);

            if (index != -1)
                Console.WriteLine($"Number {target} found at index {index}");
            else
                Console.WriteLine($"Number {target} not found.");
        }

        private int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
