using System;

namespace ExercisesLesson35
{
    class Exercises2
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]); // chuyển string sang số n
                int k = int.Parse(data[1]); // chuyển string sang số k
                Console.WriteLine($"Test {i}:"); // in ra thứ tự bộ test
                if (n <= 0 || k > n)
                {
                    Console.WriteLine("NO RESULT");
                }
                else
                {
                    for (int j = k; j <= n; j++)
                    {
                        if (j % 2 != 0) // nếu j là số lẻ
                        {
                            Console.Write(j + " "); // in ra
                        }
                    }
                    Console.WriteLine(); // in xuống dòng
                }

            }
        }
    }
}
