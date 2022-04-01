/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises15
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var arr1 = GetArrayElement();
                var arr2 = GetArrayElement();
                var result = Merge(arr1, arr2);
                Console.WriteLine($"Test {i}: ");
                ShowElement(result);
            }
        }

        // phương thức trộn hai mảng đã sắp xếp thành một mảng cũng sắp xếp tăng dần
        static float[] Merge(float[] arr1, float[] arr2)
        {
            Func<float[]> merge = () =>
            {
                var result = new float[arr1.Length + arr2.Length];
                int i = 0;
                int j = 0;
                int index = 0;
                while (i < arr1.Length && j < arr2.Length)
                {
                    result[index++] = arr1[i] < arr2[j] ? arr1[i++] : arr2[j++];
                }
                // chep cac phan tu con lai vao mang ket qua
                for (; i < arr1.Length; i++)
                {
                    result[index++] = arr1[i];
                }
                for (; j < arr2.Length; j++)
                {
                    result[index++] = arr2[j];
                }
                return result;
            };
            return merge();
        }

        // phương thức nhập các phần tử cho mảng
        static float[] GetArrayElement()
        {
            Func<float[]> getInput = () =>
            {
                var elements = Console.ReadLine().Split(' ');
                int n = elements.Length;
                float[] arr = new float[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = float.Parse(elements[index]);
                }
                return arr;
            };
            return getInput();
        }

        // phương thức hiển thị các phần tử mảng duy nhất một lần
        static void ShowElement(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
