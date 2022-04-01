/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    internal class Exercises9
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var arr1 = GetArray();
                var arr2 = GetArray();
                // tạo mảng kết quả có kích thước bằng tổng độ dài hai mảng
                var arr = Merge(arr1, arr2);
                Console.WriteLine($"Test {i}: ");
                ShowArray(arr);
            }
        }

        // phương thức chép mảng nguồn vào mảng đích và sau đó sắp xếp lại
        static float[] Merge(float[] arr1, float[] arr2)
        {
            var arr = new float[arr1.Length + arr2.Length];
            // chép các phần tử trong mảng arr1 sang mảng arr
            Array.Copy(arr1, 0, arr, 0, arr1.Length);
            // chép các phần tử trong mảng arr2 sang mảng arr
            Array.Copy(arr2, 0, arr, arr1.Length, arr2.Length);
            Array.Sort(arr); // sắp xếp
            return arr;
        }

        // phương thức hiển thị các phần tử của mảng arr
        static void ShowArray(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // phương thức nhập vào các phần tử mảng
        static float[] GetArray()
        {
            var elements = Console.ReadLine().Split(' ');
            float[] arr = new float[elements.Length];
            for (int index = 0; index < elements.Length; index++)
            {
                arr[index] = float.Parse(elements[index]);
            }
            return arr;
        }
    }
}
