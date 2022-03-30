/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises7
    {
        // phương thức tìm giá trị lớn nhất và nhỏ nhất
        static void FindMinMax(int[] arr, out int min, out int max)
        {
            min = max = arr[0];
            foreach (var item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
                if(item < min)
                {
                    min = item;
                }
            }
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
                    FindMinMax(arr, out int min, out int max);
                    Console.WriteLine($"Test {test}:\n{(min == max ? "NOT AVAILABLE" : min + " " + max)}");
                    
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
