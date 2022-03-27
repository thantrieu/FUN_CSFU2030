using System;

namespace ExercisesLesson35
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine()); // đọc vào số n
                Console.WriteLine($"Test {i}:"); // in ra thứ tự bộ test
                if (n < 0)
                {
                    Console.WriteLine("NO RESULT");
                }
                else
                {
                    for (int j = 0; j <= n; j++) // xét j từ 0 đến n
                    {
                        if (j % 2 == 0) // nếu j là số chẵn
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
