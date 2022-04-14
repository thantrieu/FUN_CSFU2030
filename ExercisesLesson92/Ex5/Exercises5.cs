/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises5
    {
        // Phương thức tính tổng các phần tử trong mảng
        static void Solve(int[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSquareNumber(arr[i]))
                {
                    writer.Write($"({i}, {arr[i]}) ");
                }
            }
            writer.WriteLine(); // in xuong dong
        }


        // phương thức kiểm tra số chính phương
        // nếu tích phần nguyên căn bậc hai của n bằng chính n thì n là số chính phương
        static bool IsSquareNumber(int n)
        {
            int x = (int)Math.Sqrt(n);
            return x * x == n;
        }

        static void Main()
        {           
            var inputFileName = "input5.txt";
            var outputFileName = "output5.txt";
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
