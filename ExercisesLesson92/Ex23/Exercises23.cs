/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.15
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises23
    {
        // phương thức sắp xếp các từ theo độ dài từ
        static void SortASC(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j].Length < arr[j - 1].Length)
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
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

        static void Main()
        {
            var inputFileName = "input23.txt";
            var outputFileName = "output23.txt";
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
                            var str = reader.ReadLine().Split(' ');
                            writer.WriteLine($"Test {test}:");
                            SortASC(str);
                            ShowElements(str, writer);
                        }
                    }
                }
            }
            
        }
    }
}
