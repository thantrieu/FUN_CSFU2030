/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises3
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int x = int.Parse(data[1]);
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int index = 0; index < elements.Length; index++)
                    {
                        arr[index] = int.Parse(elements[index]);
                    }
                    // sắp xếp
                    Array.Sort(arr); // tăng dần
                    int result = CountX(arr, x);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("N INVALID");
                }
            }
        }

        // phương thức đếm số lần xuất hiện của x trong mảng
        static int CountX(int[] arr, int x)
        {
            int indexOfX = Array.IndexOf(arr, x);
            int count = indexOfX >= 0 ? 1 : 0;
            if (count > 0) // nếu tìm thấy x
            {   // xét các phần tử sau vị trí x xem có bằng x không
                for (int i = indexOfX + 1; i < arr.Length; i++)
                {
                    if (arr[i] == x) // nếu có
                    {
                        count++; // tăng biến đếm x lên
                    }
                }
            }
            return count;
        }
    }
}
