/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises3
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
                // câu lệnh lambda đếm số lần xuất hiện của x trong mảng
                Func<int[], int, int> countX = (data, x) =>
                {
                    int count = 0;
                    foreach (var item in data)
                    {
                        if (item == x)
                        {
                            count++;
                        }
                    }
                    return count;
                };
                Console.WriteLine(countX(arr, xValue));
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
