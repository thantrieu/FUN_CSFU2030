/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises8
    {
        // phương thức tìm giá trị lớn nhất và nhỏ nhất
        static void FindMinMax(int[] arr, out int min, out int max)
        {
            min = max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
        }

        // phương thức tìm giá trị lớn thứ 2 và nhỏ thứ 2
        static void SecondMinMax(int[] arr, out int secondMin, out int secondMax)
        {
            FindMinMax(arr, out int min, out int max);
            secondMin = max;
            secondMax = min;
            foreach (var item in arr)
            {
                if(item != max && item > secondMax)
                {
                    secondMax = item;
                }
                if(item != min && item < secondMin)
                {
                    secondMin = item;
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
                    SecondMinMax(arr, out int min2, out int max2);
                    Console.WriteLine($"Test {test}:\n{(min2 == max2 ? "NOT AVAILABLE" : min2 + " " + max2)}");

                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
