/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises6
    {
        // Phương thức tính tổng các phần tử trong mảng
        static void Solve(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSymmetryNumber(arr[i]))
                {
                    Console.Write($"({i}, {arr[i]}) ");
                }
            }
            Console.WriteLine(); // in xuong dong
        }


        // phương thức kiểm tra số thuận nghịch
        static bool IsSymmetryNumber(int n)
        {
            if(n < 10)
            {
                return false;
            }
            if(n < 0)
            {
                n = -n;
            }
            int rev = 0;
            int m = n;
            while(m > 0)
            {
                rev = rev * 10 + m % 10;
                m /= 10;
            }
            return rev == n;
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
