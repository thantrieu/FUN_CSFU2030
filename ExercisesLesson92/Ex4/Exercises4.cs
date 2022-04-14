/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises4
    {
        // Phương thức tính tổng các phần tử trong mảng
        static void Solve(int[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(IsPrimeNumber(arr[i]))
                {
                    writer.Write($"({i}, {arr[i]}) ");
                }
            }
            writer.WriteLine(); // in xuong dong
        }


        // phương thức kiểm tra số nguyên tố
        static bool IsPrimeNumber(int n)
        {
            if(n < 2)
            {
                return false;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            var inputFileName = "input4.txt";
            var outputFileName = "output4.txt";
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
                                writer.Write($"Test {test}:\n");
                                Solve(arr, writer);
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
