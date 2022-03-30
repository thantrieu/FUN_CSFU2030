/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises2
    {
        // Phương thức tính tổng các phần tử trong mảng
        static double SumElementsAtEvenIndex(int[] arr)
        {
            int numOfEvenIndex = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i+= 2)
            {
                sum += arr[i];
                numOfEvenIndex++;
            }
            return sum * 1.0 / numOfEvenIndex;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n và n phần tử mảng
                int n = int.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(data[i]);
                    }
                    // tính tổng và in ra kết quả
                    var result = SumElementsAtEvenIndex(arr);
                    Console.WriteLine($"Test {test}:\n{result}");
                }
                else
                {
                    Console.WriteLine($"Test {test}:\nN INVALID");
                }
            }
        }
    }
}
