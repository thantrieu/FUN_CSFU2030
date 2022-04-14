/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises6
    {
        // Phương thức tính tổng các phần tử trong mảng
        static void Solve(int[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSymmetryNumber(arr[i]))
                {
                    writer.Write($"{arr[i]} ");
                }
            }
            writer.WriteLine(); // in xuong dong
        }


        // phương thức kiểm tra số thuận nghịch
        static bool IsSymmetryNumber(int n)
        {
            if(n < 0)
            {
                n = -n;
            }
            if (n < 10)
            {
                return false;
            }
            int rev = 0;
            int m = n;
            while(m > 0)
            {
                rev = rev * 10 + m % 10;
                m /= 10;
            }
            return rev == n;
        }

        static void Main()
        {
            var inputFileName = "input6.txt";
            var outputFileName = "output6.txt";
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
