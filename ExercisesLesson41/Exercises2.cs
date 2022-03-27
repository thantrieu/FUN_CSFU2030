using System;

namespace ExercisesLesson41
{
    class Exercises2
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int k = int.Parse(data[1]);
                Console.WriteLine($"Test {test}: ");
                if (n > 0 && k <= n)
                {
                    ListedOddNumbers(n, k);
                }
                else
                {
                    Console.WriteLine("NO RESULT");
                }
            }
        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static void ListedOddNumbers(int n, int k)
        {
            int counter = 0;
            for (int i = k; i <= n; i++)
            {
                if (!IsEven(i))
                {
                    Console.Write(i + " ");
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("NO RESULT");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
