/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.15
/// </summary>

using System.IO;

namespace ExercisesLesson92
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
        static void ShowElements(string[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                writer.Write(arr[i] + " ");
            }
            writer.WriteLine();
        }

        static string[] GetArrayElements(StreamReader reader)
        {
            var elements = reader.ReadLine().Split(' ');
            return elements;
        }

        static void Main()
        {
            var inputFileName = "input19.txt";
            var outputFileName = "output19.txt";
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
                            var str1 = GetArrayElements(reader);
                            var str2 = GetArrayElements(reader);
                            var arr = Merge(str1, str2);
                            writer.WriteLine($"Test {test}:");
                            ShowElements(arr, writer);
                        }
                    }
                }
            }
        }
    }
}
