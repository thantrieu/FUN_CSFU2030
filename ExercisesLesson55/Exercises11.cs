/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises11
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var words = Console.ReadLine().Split(' ');
                Array.Sort(words, Comparer);
                Console.WriteLine($"Test {i}: ");
                ShowArray(words);
            }
        }

        // phương thức chỉ định việc sắp xếp tăng dần theo độ dài từ
        static int Comparer(string str1, string str2)
        {
            return str1.Length - str2.Length;
        }


        // phương thức hiển thị các phần tử của mảng arr
        static void ShowArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
