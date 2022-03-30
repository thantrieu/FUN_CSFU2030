/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises13
    {
        // phương thức sắp xếp các phần tử mảng giảm dần
        static void SortDESC(float[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(float[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n, x và n phần tử mảng
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    float[] arr = new float[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = float.Parse(elements[i]);
                    }
                    SortDESC(arr); // gọi phương thức sắp xếp
                    Console.WriteLine($"Test {test}:");
                    ShowElements(arr);
                }
            }
        }
    }
}
