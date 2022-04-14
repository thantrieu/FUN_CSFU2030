/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises9
    {
        // phương thức đếm số lần xuất hiện của x
        static int CountX(int[] arr, int x)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if(item == x)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {
            var inputFileName = "input9.txt";
            var outputFileName = "output9.txt";
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
                            var data = reader.ReadLine().Split(' ');
                            int n = int.Parse(data[0]);
                            int x = int.Parse(data[1]);
                            var elements = reader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                int[] arr = new int[n];
                                for (int i = 0; i < n; i++)
                                {
                                    arr[i] = int.Parse(elements[i]);
                                }
                                var result = CountX(arr, x);
                                writer.WriteLine($"Test {test}:\n{result}");
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
