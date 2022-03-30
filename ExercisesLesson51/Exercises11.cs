/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises11
    {
        // phương thức kiểm tra tính đối xứng của mảng
        static bool IsSymmetry(int[] arr)
        {
            int mid = arr.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n, x và n phần tử mảng
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(elements[i]);
                    }
                    Console.WriteLine($"Test {test}:\n{(IsSymmetry(arr) ? "YES" : "NO")}");
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
