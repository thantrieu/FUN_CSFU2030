/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises10
    {
        // phương thức đếm số phần tử chia hết cho k
        static int DivisibleByK(int[] arr, int k)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (item % k == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {
            var inputFileName = "input10.txt";
            var outputFileName = "output10.txt";
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
                            int k = int.Parse(data[1]);
                            var elements = reader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                if (k == 0)
                                {
                                    writer.WriteLine($"Test {test}: K INVALID");
                                }
                                else
                                {
                                    int[] arr = new int[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        arr[i] = int.Parse(elements[i]);
                                    }
                                    var result = DivisibleByK(arr, k);
                                    writer.WriteLine($"Test {test}: {result}");
                                }
                            }
                            else
                            {
                                writer.WriteLine($"Test {test}: N INVALID");
                            }
                        }
                    }
                }
            }
        }
    }
}
