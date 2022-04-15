/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises14
    {
        // phương thức kiểm tra xem phần tử giá trị x đã tồn tại trước vị trí pos chưa
        static bool IsExisted(int[] arr, int x, int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                if(arr[i] == x)
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
                if(!IsExisted(arr, arr[i], i))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                if (n > 0)
                {
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
}
