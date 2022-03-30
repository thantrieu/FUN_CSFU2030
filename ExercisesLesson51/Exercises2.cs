/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises2
    {
        // Phương thức tính tổng các phần tử trong mảng
        static int SumElements(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n và n phần tử mảng
                int n = int.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(data[i]);
                    }
                    // tính tổng và in ra kết quả
                    var result = SumElements(arr);
                    Console.WriteLine($"Test {test}:\n{result * 1.0 / n}");
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
