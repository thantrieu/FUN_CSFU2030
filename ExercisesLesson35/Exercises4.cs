using System;

namespace ExercisesLesson35
{
    class Exercises4
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
                    double sum = 0;
                    for (int j = 1; j <= n; j++) // xét j từ 1 đến n
                    {
                        sum += 1.0 / j; // cộng 1/j vào tổng
                    }
                    // in kết quả hiển thị 3 chữ số sau dấu phẩy
                    Console.WriteLine($"{sum:f3}"); 
                }

            }
        }
    }
}
