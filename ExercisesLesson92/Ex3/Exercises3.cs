/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises3
    {
        // Phương thức tính tổng các phần tử trong mảng
        static double SumElementsAtEvenIndex(int[] arr)
        {
            int numOfEvenIndex = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                sum += arr[i];
                numOfEvenIndex++;
            }
            return sum * 1.0 / numOfEvenIndex;
        }

        static void Main()
        {
            var inputFileName = "input3.txt";
            var outputFileName = "output3.txt";
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
                            // đọc vào số n và n phần tử mảng
                            int n = int.Parse(reader.ReadLine());
                            var data = reader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                int[] arr = new int[n];
                                for (int i = 0; i < n; i++)
                                {
                                    arr[i] = int.Parse(data[i]);
                                }
                                // tính tổng và in ra kết quả
                                var result = SumElementsAtEvenIndex(arr);
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
