using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLesson35
{
    class Exercises6
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine()); // đọc vào số n
                Console.WriteLine($"Test {i}:"); // in ra thứ tự bộ test
                if (n <= 0 || n > 20)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    ulong sum = 0;
                    ulong factorial = 1;
                    for (int j = 1; j <= n; j++) // xét j từ 1 đến n
                    {
                        factorial *= (ulong)j; // tính j!
                        sum += factorial; // cộng j! vào tổng
                    }
                    Console.WriteLine($"{sum}");
                }

            }
        }
    }
}
