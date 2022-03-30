/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises10
    {
        // phương thức đếm số phần tử chia hết cho k
        static int DivisibleByK(int[] arr, int k)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (item % k == 0)
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
                // đọc vào số n, k và n phần tử mảng
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int k = int.Parse(data[1]);
                var elements = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    if(k == 0)
                    {
                        Console.WriteLine($"Test {test}:\nK INVALID");
                    } else
                    {
                        int[] arr = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = int.Parse(elements[i]);
                        }
                        var result = DivisibleByK(arr, k);
                        Console.WriteLine($"Test {test}:\n{result}");
                    }
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
