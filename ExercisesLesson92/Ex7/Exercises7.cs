/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises7
    {
        // phương thức tìm giá trị lớn nhất và nhỏ nhất
        static void FindMinMax(int[] arr, out int min, out int max)
        {
            min = max = arr[0];
            foreach (var item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
                if(item < min)
                {
                    min = item;
                }
            }
        }

        static void Main()
        {
            var inputFileName = "input7.txt";
            var outputFileName = "output7.txt";
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
                            int n = int.Parse(reader.ReadLine());
                            var data = reader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                int[] arr = new int[n];
                                for (int i = 0; i < n; i++)
                                {
                                    arr[i] = int.Parse(data[i]);
                                }
                                FindMinMax(arr, out int min, out int max);
                                writer.WriteLine($"Test {test}:\n{(min == max ? "NOT AVAILABLE" : min + " " + max)}");
                            }
                            else
                            {
                                writer.WriteLine($"Test {test}:\nN INVALID");
                            }
                        }
                    }
                }
            }
        }
    }
}
