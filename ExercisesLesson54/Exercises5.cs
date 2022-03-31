/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson54
{
    class Exercises5
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                int n = elements.Length;
                int[] arr = new int[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = int.Parse(elements[index]);
                }
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: ");
                ShowArray(arr);
                IndexOf(arr, x, out int first, out int last);
                Console.WriteLine($"{first} {last}");
            }
        }

        // phương thức đếm số phần tử của mảng nằm trong đoạn x, y
        static void IndexOf(int[] arr, int x, out int first, out int last)
        {
            first = -1; // giả định ban đầu không tồn tại x trong mảng
            last = -1; // ta gán vị trí xuất hiện đầu tiên(first) và cuối cùng(last) của x là -1
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x) // tìm thấy x cuối cùng(xét từ phải sang)
                {
                    last = i;
                    break;
                }
            }
            // first index of x
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) // tìm thấy x đầu tiên(trái sang)
                {
                    first = i;
                    break;
                }
            }
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
