/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises1
    {
        // phương thức tính tổng các phần tử trong mảng
        static int SumElements(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Main()
        {
            string inputFileName = "input1.txt";
            string outputFileName = "output1.txt";
            FileInfo fileInput = new FileInfo(inputFileName);
            FileInfo fileOutput = new FileInfo(outputFileName);
            using (var stream = fileOutput.OpenWrite())
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    using (var streamReader = fileInput.OpenText())
                    {
                        int t = int.Parse(streamReader.ReadLine());
                        for (int test = 1; test <= t; test++)
                        {
                            int n = int.Parse(streamReader.ReadLine());
                            var data = streamReader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                int[] arr = new int[n];
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    arr[i] = int.Parse(data[i]);
                                }
                                var result = SumElements(arr);
                                streamWriter.WriteLine($"Test {test}: \n{result}");
                            }
                            else
                            {
                                streamWriter.WriteLine($"Test {test}: \nN INVALID");
                            }
                        }
                    }
                }
            }
        }
    }
}
