/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises14
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                int n = elements.Length;
                Console.WriteLine($"Test {i}: ");
                int[] arr = new int[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = int.Parse(elements[index]);
                }
                ShowElement(arr);
            }
        }

        // phương thức hiển thị các phần tử mảng duy nhất một lần
        static void ShowElement(int[] arr)
        {
            Func<int, int, bool> isExisted = (x, pos) =>
            {
                for (int i = 0; i < pos; i++)
                {
                    if (arr[i] == x)
                    {
                        return true;
                    }
                }
                return false;
            };
            for (int i = 0; i < arr.Length; i++)
            {
                if (!isExisted(arr[i], i))
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
