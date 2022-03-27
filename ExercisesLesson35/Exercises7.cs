using System;

namespace ExercisesLesson35
{
    class Exercises7
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int k = int.Parse(data[1]);
                Console.WriteLine($"Test {i}:"); // in ra thứ tự bộ test
                if (n < 0 || k <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    for (int j = 1; j <= n; j++) // xét j từ 1 đến n
                    {
                        if (j % k == 0)
                        {
                            Console.Write(j + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
