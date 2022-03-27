using System;

namespace ExercisesLesson35
{
    class Exercises3
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine()); // đọc vào số n
                Console.WriteLine($"Test {i}:"); // in ra thứ tự bộ test
                if (n <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    int sum = 0;
                    for (int j = 1; j <= n; j++) // xét j từ 1 đến n
                    {
                        sum += j; // cộng j vào tổng
                    }
                    Console.WriteLine(sum); // in xuống dòng
                }

            }
        }
    }
}
