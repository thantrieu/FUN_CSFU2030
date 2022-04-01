/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises7
    {
        static void Main()
        {
            // nhập dữ liệu đầu vào
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var elements = Console.ReadLine().Split(' ');
                var arr = new int[elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    arr[i] = int.Parse(elements[i]);
                }
                // tìm được độ dài dãy tăng có số phần tử max
                int maxLength = MaxIncrement(arr);
                Console.WriteLine($"Test {test}: ");
                Console.WriteLine(maxLength);
                // tìm tất cả các dãy tăng
                // khi thấy 1 dãy thỏa mãn -> hiển thị các phần tử của nó ra màn hình
                FindPosition(arr, maxLength);
            }
        }

        // phương thức tìm độ dài dãy con tăng dài nhất
        static int MaxIncrement(int[] arr)
        {
            // delegate tìm độ dài max của tất cả các dãy con tăng
            Func<int> findMaxLength = () =>
            {
                int length = -1;
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
                    if (i == arr.Length - 1 && length < countElement)
                    {
                        length = countElement;
                    }
                }
                return length == -1 ? arr.Length : length;
            };
            return findMaxLength();
        }

        // phương thức tìm tất cả các dãy tăng dài nhất
        static void FindPosition(int[] arr, int maxLength)
        {
            // câu lệnh lambda hiển thị ra màn hình các phần tử của dãy tăng
            Action<int[], int, int> showElement = (data, start, numOfElement) =>
            {
                for (int i = start; i < start + numOfElement; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            };

            int startPos = 0;
            int countElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                countElement++;
                if (i + 1 < arr.Length && arr[i + 1] < arr[i])
                {
                    if (countElement == maxLength)
                    {
                        showElement(arr, i + 1 - maxLength, maxLength);
                    }
                    countElement = 0;
                    startPos = i + 1;
                }
                if (i == arr.Length - 1 && (arr.Length == countElement || countElement == maxLength))
                {
                    showElement(arr, startPos, maxLength);
                }
            }
        }
    }
}
