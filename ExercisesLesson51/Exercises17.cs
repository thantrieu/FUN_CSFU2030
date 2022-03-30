/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises17
    {
        // phương thức nối hai mảng arr1 và arr2 thành arr
        static float[] ConcatArrays(float[] arr1, float[] arr2)
        {
            float[] result = new float[arr1.Length + arr2.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }
            return result;
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static float[] GetArrayElements()
        {
            var elements = Console.ReadLine().Split(' ');
            var n = elements.Length;
            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = float.Parse(elements[i]);
            }
            return arr;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n, x và n phần tử mảng
                var arr1 = GetArrayElements();
                var arr2 = GetArrayElements();
                var arr = ConcatArrays(arr1, arr2);
                Console.WriteLine($"Test {test}:");
                ShowElements(arr);
            }
        }
    }
}
