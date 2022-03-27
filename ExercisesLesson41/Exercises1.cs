using System;

namespace ExercisesLesson41
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: ");
                if(n >= 0)
                {
                    ListedEvenNumbers(n);
                } else
                {
                    Console.WriteLine("NO RESULT");
                }
            }
        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static void ListedEvenNumbers(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (IsEven(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
