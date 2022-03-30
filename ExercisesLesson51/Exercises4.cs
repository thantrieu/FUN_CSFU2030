/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises4
    {
        // Phương thức tính tổng các phần tử trong mảng
        static void Solve(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(IsPrimeNumber(arr[i]))
                {
                    Console.Write($"({i}, {arr[i]}) ");
                }
            }
            Console.WriteLine(); // in xuong dong
        }


        // phương thức kiểm tra số nguyên tố
        static bool IsPrimeNumber(int n)
        {
            if(n < 2)
            {
                return false;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if(n % i == 0)
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
                    Console.Write($"Test {test}:\n");
                    Solve(arr);
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
