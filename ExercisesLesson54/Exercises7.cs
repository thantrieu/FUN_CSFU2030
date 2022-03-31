/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises7
    {
        // phương thức tìm độ dài dãy con tăng dài nhất
        static int MaxIncrement(int[] arr)
        {
            int length = -1; // độ dài của dãy con mặc định là -1
            int countElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                countElement++;
                if (i + 1 < arr.Length && arr[i + 1] < arr[i])
                {
                    if (countElement > length)
                    {
                        length = countElement;
                    }
                    countElement = 0;
                }
            }
            return length == -1 ? arr.Length : length;
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
                // đọc vào số n, x và n phần tử mảng
                var elements = Console.ReadLine().Split(' ');
                var n = elements.Length;
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(elements[i]);
                }
                Console.WriteLine($"Test {test}:");
                int maxLength = MaxIncrement(arr);
                Console.WriteLine(maxLength);
                FindPosition(arr, maxLength);
            }
        }

        // phương thức tìm
        static void FindPosition(int[] arr, int maxLength)
        {
            int countElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                countElement++;
                if (i + 1 < arr.Length && arr[i + 1] < arr[i])
                {
                    if (countElement == maxLength)
                    {
                        ShowElements(arr, i + 1 - maxLength, maxLength);
                    }
                    countElement = 0;
                }
                if(i == arr.Length - 1 && (countElement == arr.Length || countElement == maxLength))
                {
                    ShowElements(arr, 0, maxLength);
                }
            }
        }
    }
}
