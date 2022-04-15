/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises18
    {
        // phương thức trộn hai mảng arr1 và arr2 thành arr sắp xếp tăng
        static float[] Merge(float[] arr1, float[] arr2)
        {
            float[] result = new float[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            int index = 0;
            while(i < arr1.Length && j < arr2.Length)
            {
                result[index++] = arr1[i] <= arr2[j] ? arr1[i++] : arr2[j++];
            }
            for (; i < arr1.Length; i++)
            {
                result[index++] = arr1[i];
            }
            for (; j < arr2.Length; j++)
            {
                result[index++] = arr2[j];
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
                var arr1 = GetArrayElements();
                var arr2 = GetArrayElements();
                var arr = Merge(arr1, arr2);
                Console.WriteLine($"Test {test}:");
                ShowElements(arr);
            }
        }
    }
}
