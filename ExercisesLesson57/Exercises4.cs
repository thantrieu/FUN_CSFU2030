/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises4
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
                var xValue = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {test}: ");
                ShowElements(arr);
                // câu lệnh lambda tìm vị trí xuất hiện cuối cùng của x trong mảng
                Func<int[], int, int> lastIndexOf = (data, x) =>
                {
                    for (var i = data.Length - 1; i >= 0; i--)
                    {
                        if (arr[i] == x)
                        {
                            return i;
                        }
                    }
                    return -1;
                };
                Console.WriteLine(lastIndexOf(arr, xValue));
            }
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
