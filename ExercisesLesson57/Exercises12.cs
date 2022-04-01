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

        // phương thức hiển thị giá trị nhỏ nhất và lớn nhất
        static void ShowMinMax(int[] arr)
        {
            Func<int[], int> findMin = (elements) =>
            {
                int minValue = arr[0];
                foreach (var item in elements)
                {
                    if (item < minValue)
                    {
                        minValue = item;
                    }
                }
                return minValue;
            };
            Func<int[], int> findMax = (elements) =>
            {
                int maxValue = arr[0];
                foreach (var item in elements)
                {
                    if (item > maxValue)
                    {
                        maxValue = item;
                    }
                }
                return maxValue;
            };
            var min = findMin(arr);
            var max = findMax(arr);
            if (min == max)
            {
                Console.WriteLine("NOT AVAILABLE");
            }
            else
            {
                Console.WriteLine($"{min} {max}");
            }
        }
    }
}
