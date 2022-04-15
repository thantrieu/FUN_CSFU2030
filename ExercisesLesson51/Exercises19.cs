/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises19
    {
        // phương thức trộn hai mảng str1 và str2 thành str
        static string[] Merge(string[] str1, string[] str2)
        {
            string[] result = new string[str1.Length + str2.Length];
            int i = 0;
            int j = 0;
            int index = 0;
            while (i < str1.Length && j < str2.Length)
            {
                result[index++] = str1[i].CompareTo(str2[j]) > 0 ? str1[i++] : str2[j++];
            }
            for (; i < str1.Length; i++)
            {
                result[index++] = str1[i];
            }
            for (; j < str2.Length; j++)
            {
                result[index++] = str2[j];
            }
            return result;
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static string[] GetArrayElements()
        {
            var elements = Console.ReadLine().Split(' ');
            return elements;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào 2 mảng str1, str2 và tiến hành trộn
                var str1 = GetArrayElements();
                var str2 = GetArrayElements();
                var arr = Merge(str1, str2);
                Console.WriteLine($"Test {test}:");
                ShowElements(arr);
            }
        }
    }
}
