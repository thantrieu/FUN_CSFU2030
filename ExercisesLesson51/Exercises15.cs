/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises15
    {
        // phương thức đếm số lần xuất hiện của x trong mảng
        static int CountX(int[] arr, int x)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == x)
                {
                    counter++;
                }
            }
            return counter;
        }

        // phương thức kiểm tra xem phần tử giá trị x đã tồn tại trước vị trí pos chưa
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

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!IsExisted(arr, arr[i], i))
                {
                    Console.WriteLine(arr[i] + ": " + CountX(arr, arr[i]));
                }
            }
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var elements = Console.ReadLine().Split(' ');
                var n = elements.Length;
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(elements[i]);
                }
                Console.WriteLine($"Test {test}:");
                ShowElements(arr);
            }
        }
    }
}
