/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
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
        static void ShowElements(int[] arr, int startPos, int numOfElement)
        {
            for (int i = startPos; i < startPos + numOfElement; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var elements = Console.ReadLine().Split(' ');
                var n = elements.Length;
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(elements[i]);
                }
                Console.WriteLine($"Test {test}:");
                var startPos = 0;
                var length = -1;
                MaxIncrement(arr, ref startPos, ref length);
                ShowElements(arr, startPos, length);
            }
        }
    }
}
