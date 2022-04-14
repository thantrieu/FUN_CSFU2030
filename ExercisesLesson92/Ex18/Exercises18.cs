/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises18
    {
        static void Main()
        {
            var inputFileName = "input18.txt";
            var outputFileName = "output18.txt";
            FileInfo fileReader = new FileInfo(inputFileName);
            FileInfo fileWriter = new FileInfo(outputFileName);
            using(var stream = fileWriter.OpenWrite())
            {
                using(var writer = new StreamWriter(stream))
                {
                    using(var reader = fileReader.OpenText())
                    {
                        int t = int.Parse(reader.ReadLine());
                        for (int test = 1; test <= t; test++)
                        {
                            // đọc vào các phần tử của mảng
                            var arr1 = GetArrayElements(reader);
                            var arr2 = GetArrayElements(reader);
                            var arr = Merge(arr1, arr2);
                            // ghi kq
                            writer.WriteLine($"Test {test}: ");
                            WriteElements(arr, writer);
                        }
                    }
                }
            }
        }

        static void WriteElements(float[] arr, StreamWriter writer)
        {
            foreach (var item in arr)
            {
                writer.Write(item + " ");
            }
            writer.WriteLine();
        }

        static float[] Merge(float[] arr1, float[] arr2)
        {
            var result = new float[arr1.Length + arr2.Length];
            int resultIndex = 0; // chỉ số của mảng kết quả
            int i = 0; // chỉ số tăng cho mảng arr1
            int j = 0; // chỉ số tăng cho mảng arr2
            // nếu cả hai mảng cùng còn các phần tử chưa được xét
            while(i < arr1.Length && j < arr2.Length)
            {
                result[resultIndex++] = arr1[i] < arr2[j] ? arr1[i++] : arr2[j++];
            }
            // nếu mảng arr1 còn phần tử chưa xét
            for (; i < arr1.Length; i++)
            {
                result[resultIndex++] = arr1[i];
            }
            // nếu mảng arr2 chưa xét hết
            for (; j < arr2.Length; j++)
            {
                result[resultIndex++] = arr2[j];
            }
            return result;
        }

        static float[] GetArrayElements(StreamReader reader)
        {
            var elements = reader.ReadLine().Split(' ');
            var n = elements.Length;
            float[] result = new float[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = float.Parse(elements[i]);
            }
            return result;
        }

    }
}
