/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises9
    {
        // phương thức đếm số lần xuất hiện của x
        static int CountX(int[] arr, int x)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if(item == x)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n, x và n phần tử mảng
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int x = int.Parse(data[1]);
                var elements = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(elements[i]);
                    }
                    var result = CountX(arr, x);
                    Console.WriteLine($"Test {test}:\n{result}");
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
