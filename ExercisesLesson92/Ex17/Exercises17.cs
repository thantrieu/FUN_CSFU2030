/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
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
        static void ShowElements(float[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                writer.Write(arr[i] + " ");
            }
            writer.WriteLine();
        }

        static float[] GetArrayElements(StreamReader reader)
        {
            var elements = reader.ReadLine().Split(' ');
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
            var inputFileName = "input17.txt";
            var outputFileName = "output17.txt";
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
                            var arr = ConcatArrays(arr1, arr2);
                            writer.WriteLine($"Test {test}:");
                            ShowElements(arr, writer);
                        }
                    }
                }
            }
            
        }
    }
}
