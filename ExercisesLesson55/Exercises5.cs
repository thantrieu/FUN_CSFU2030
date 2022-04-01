/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises5
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                float[] arr = new float[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = float.Parse(elements[index]);
                }
                Array.Sort(arr); // sắp xếp tăng dần
                Array.Reverse(arr); // đảo ngược mảng -> giảm dần
                ShowArray(arr);
            }
        }

        // phương thức hiển thị các phần tử của mảng arr
        static void ShowArray(float[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
