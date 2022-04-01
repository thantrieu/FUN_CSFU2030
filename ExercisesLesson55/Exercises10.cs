/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises10
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var words = Console.ReadLine().Split(' ');
                Array.Sort(words);
                Console.WriteLine($"Test {i}: ");
                ShowArray(words);
            }
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
