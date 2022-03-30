/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises24
    {
        // phương thức sắp xếp các từ trong chuỗi kí tự
        static void SortASC(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j].Length > arr[j-1].Length)
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n, x và n phần tử mảng
                var str = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {test}:");
                SortASC(str);
                ShowElements(str);
            }
        }
    }
}
