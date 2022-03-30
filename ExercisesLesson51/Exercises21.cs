/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises21
    {
        // phương thức chèn mảng arr2 vào vị trí k của mảng arr1
        static int[] InsertArray(int[] arr1, int[] arr2, int k)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            if (k <= 0) // chèn đầu mảng kết quả
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    result[i] = arr2[i];
                }
                for (int i = 0; i < arr1.Length; i++)
                {
                    result[i + arr2.Length] = arr1[i];
                }
            }
            else if (k >= arr1.Length) // chèn cuối mảng kết quả
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    result[i] = arr1[i];
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    result[i + arr1.Length] = arr2[i];
                }
            }
            else // chèn vị trí khác đầu, cuối
            {
                // sao chép các phần tử trước vị trí k
                for (int i = 0; i < k; i++)
                {
                    result[i] = arr1[i];
                }
                // chèn các phần tử mảng arr2 vào vị trí k của arr1
                for (int i = 0; i < arr2.Length; i++)
                {
                    result[i + k] = arr2[i];
                }
                // chép các phần tử còn lại trong mảng arr1
                for (int i = k; i < arr1.Length; i++)
                {
                    result[arr2.Length + i] = arr1[i];
                }
            }
            return result;
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] GetArrayElements()
        {
            var elements = Console.ReadLine().Split(' ');
            var n = elements.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(elements[i]);
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
                int k = int.Parse(Console.ReadLine());
                var arr = InsertArray(arr1, arr2, k);
                Console.WriteLine($"Test {test}:");
                ShowElements(arr);
            }
        }
    }
}
