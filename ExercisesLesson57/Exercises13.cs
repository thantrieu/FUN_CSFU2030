/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises12
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int index = 0; index < elements.Length; index++)
                    {
                        arr[index] = int.Parse(elements[index]);
                    }
                    ShowMinMax(arr);
                }
                else
                {
                    Console.WriteLine("N INVALID");
                }
            }
        }

        // phương thức tìm số lớn thứ hai trong mảng
        static int SecondMin(int[] arr)
        {
            var min = Min(arr);
            var min2 = Max(arr);
            foreach (var item in arr)
            {
                if (item < min2 && item != min)
                {
                    min2 = item;
                }
            }
            return min2;
        }

        // phương thức tìm giá trị nhỏ nhất
        static int Min(int[] arr)
        {
            Func<int> findMin = () =>
            {
                int minValue = arr[0];
                foreach (var item in arr)
                {
                    if (item < minValue)
                    {
                        minValue = item;
                    }
                }
                return minValue;
            };
            return findMin();
        }

        // phương thức tìm giá trị lớn nhất trong mảng
        static int Max(int[] arr)
        {
            Func<int> findMax = () =>
            {
                int maxValue = arr[0];
                foreach (var item in arr)
                {
                    if (item > maxValue)
                    {
                        maxValue = item;
                    }
                }
                return maxValue;
            };
            return findMax();
        }

        // phương thức tìm số nhỏ thứ hai trong mảng
        static int SecondMax(int[] arr)
        {
            var max = Max(arr);
            var max2 = Min(arr);
            foreach (var item in arr)
            {
                if (item > max2 && item != max)
                {
                    max2 = item;
                }
            }
            return max2;
        }

        // phương thức hiển thị giá trị nhỏ nhất và lớn nhất
        static void ShowMinMax(int[] arr)
        {
            var min2 = SecondMin(arr);
            var max2 = SecondMax(arr);
            if (min2 == max2)
            {
                Console.WriteLine("NOT AVAILABLE");
            }
            else
            {
                Console.WriteLine($"{min2} {max2}");
            }
        }
    }
}
