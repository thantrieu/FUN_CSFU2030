/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson54
{
    class Exercises4
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
                ShowArray(arr);
                var result = LastIndexOf(arr, x);
                Console.WriteLine(result);
            }
        }

        // phương thức đếm số phần tử của mảng nằm trong đoạn x, y
        static int LastIndexOf(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
