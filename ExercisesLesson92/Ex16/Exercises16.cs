/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises16
    {
        // phương thức tìm vị trí bắt đầu và độ dài dãy con tăng dài nhất
        static void MaxIncrement(int[] arr, ref int startPos, ref int length)
        {
            int countElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                countElement++;
                if (i + 1 < arr.Length && arr[i + 1] < arr[i])
                {
                    if (countElement > length)
                    {
                        length = countElement;
                        startPos = i - length + 1;
                    }
                    countElement = 0;
                }
            }
            length = length == -1 ? arr.Length : length;
        }

        // phương thức hiển thị các phần tử của dãy con tăng dài nhất trong mảng
        static void ShowElements(int[] arr, int startPos, int numOfElement, StreamWriter writer)
        {
            for (int i = startPos; i < startPos + numOfElement; i++)
            {
                writer.Write(arr[i] + " ");
            }
            writer.WriteLine();
        }

        static void Main()
        {
            var inputFileName = "input16.txt";
            var outputFileName = "output16.txt";
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
                            var elements = reader.ReadLine().Split(' ');
                            var n = elements.Length;
                            int[] arr = new int[n];
                            for (int i = 0; i < n; i++)
                            {
                                arr[i] = int.Parse(elements[i]);
                            }
                            writer.WriteLine($"Test {test}:");
                            var startPos = 0;
                            var length = -1;
                            MaxIncrement(arr, ref startPos, ref length);
                            ShowElements(arr, startPos, length, writer);
                        }
                    }
                }
            }
        }
    }
}
