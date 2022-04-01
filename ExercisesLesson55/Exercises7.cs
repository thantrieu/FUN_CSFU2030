/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises7
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                int[] arr = new int[elements.Length];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = int.Parse(elements[index]);
                }
                ShowArray(arr);
            }
        }

        // phương thức kiểm tra xem x đã xuất hiện trước vị trí pos hay chưa
        static bool IsExisted(int[] arr, int x, int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                if (arr[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

        // phương thức đếm số lần xuất hiện của x trong mảng
        static int CountX(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }
            return count;
        }

        // phương thức hiển thị các phần tử của mảng arr
        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!IsExisted(arr, arr[i], i))
                {
                    Console.WriteLine($"{arr[i]}: {CountX(arr, arr[i])}");
                }
            }
        }
    }
}
