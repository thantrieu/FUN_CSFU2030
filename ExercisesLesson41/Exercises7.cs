using System;

namespace ExercisesLesson41
{
    class Exercises7
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
                if (n > 0 && k > 0)
                {
                    DivisibleByK(n, k);
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }

        static void DivisibleByK(int n, int k)
        {
            for (int i = 1; i <= n; i++)
            {
                if(i % k == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
