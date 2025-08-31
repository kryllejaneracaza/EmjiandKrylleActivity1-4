using System;
using ActivitywithArray.Interface;
using ActivitywithArray.Activities;

namespace ActivitywithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Array Manipulation");
                Console.WriteLine("2. Linear Search");
                Console.WriteLine("3. String Reversal");
                Console.WriteLine("4. String Split and Count");
                Console.WriteLine("5. Exit");
                Console.Write("Choose activity: ");

                string choice = Console.ReadLine();
                ActivityInterface activity = null;

                switch (choice)
                {
                    case "1": activity = new ArrayManipulation(); break;
                    case "2": activity = new LinearSearch(); break;
                    case "3": activity = new StringReversal(); break;
                    case "4": activity = new StringSplitandCount(); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid choice."); break;
                }

                activity?.Run();
            }
        }
    }
}
