/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson54
{
    class Exercises2
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
                var data = Console.ReadLine().Split(' ');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                Console.WriteLine($"Test {i}: ");
                ShowArray(arr);
                var result = CountElements(arr, x, y);
                Console.WriteLine(result);
            }
        }

        // phương thức đếm số phần tử của mảng nằm trong đoạn x, y
        static int CountElements(int[] arr, int x, int y)
        {
            if (x > y)
            {
                return 0;
            } else
            {
                int counter = 0;
                foreach (var item in arr)
                {
                    if(item >= x && item <= y)
                    {
                        counter++;
                    }
                }
                return counter;
            }
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
