/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.15
/// </summary>

using System.IO;

namespace ExercisesLesson92
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
        static void ShowElements(int[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                writer.Write(arr[i] + " ");
            }
            writer.WriteLine();
        }

        static int[] GetArrayElements(StreamReader reader)
        {
            var elements = reader.ReadLine().Split(' ');
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
            var inputFileName = "input21.txt";
            var outputFileName = "output21.txt";
            FileInfo fileReader = new FileInfo(inputFileName);
            FileInfo fileWriter = new FileInfo(outputFileName);
            using (var stream = fileWriter.OpenWrite())
            {
                using (var writer = new StreamWriter(stream))
                {
                    using (var reader = fileReader.OpenText())
                    {
                        int t = int.Parse(reader.ReadLine());
                        for (int test = 1; test <= t; test++)
                        {
                            var arr1 = GetArrayElements(reader);
                            var arr2 = GetArrayElements(reader);
                            int k = int.Parse(reader.ReadLine());
                            var arr = InsertArray(arr1, arr2, k);
                            writer.WriteLine($"Test {test}:");
                            ShowElements(arr, writer);
                        }
                    }
                }
            }
        }
    }
}
