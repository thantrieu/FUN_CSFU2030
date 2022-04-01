/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises8
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                int n = elements.Length;
                int[] arr = new int[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = int.Parse(elements[index]);
                }
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: ");
                ListedNearestNumbers(arr, x);
                ListedFurthestNumbers(arr, x);
            }
        }

        // phương thức liệt kê các phần tử gần x nhất trong mảng
        static void ListedNearestNumbers(int[] arr, int x)
        {
            Func<int> nearestX = () =>
            {
                int minDiff = Math.Abs(arr[0] - x); // độ chênh lệch hiệu số nhỏ nhất
                foreach (var item in arr)
                {
                    var diff = Math.Abs(item - x); // hiệu số hiện tại
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                    }
                }
                return minDiff;
            };

            var min = nearestX();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - x) == min)
                {
                    Console.Write($"({arr[i]}, {i})");
                }
            }
            Console.WriteLine();
        }

        // phương thức liệt kê các phần tử xa x nhất trong mảng
        static void ListedFurthestNumbers(int[] arr, int x)
        {
            Func<int> furthestX = () =>
            {
                int maxDiff = Math.Abs(arr[0] - x); // độ chênh lệch hiệu số lớn nhất
                foreach (var item in arr)
                {
                    var diff = Math.Abs(item - x); // hiệu số hiện tại
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                return maxDiff;
            };
            Action<int> printResult = (max) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Math.Abs(arr[i] - x) == max)
                    {
                        Console.Write($"({arr[i]}, {i})");
                    }
                }
                Console.WriteLine();
            };
            printResult(furthestX());
        }
    }
}
