/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises4
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                int[] arr = new int[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = int.Parse(elements[index]);
                }
                // sắp xếp
                Array.Sort(arr); // tăng dần
                ShowArray(arr);
            }
        }

        // phương thức hiển thị các phần tử của mảng arr
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
