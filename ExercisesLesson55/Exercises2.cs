/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises2
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int index = 0; index < elements.Length; index++)
                    {
                        arr[index] = int.Parse(elements[index]);
                    }
                    Array.Sort(arr); // sắp xếp tăng dần
                    int min2 = Min2(arr);
                    int max2 = Max2(arr);
                    // kiểm tra xem min2 có trùng max2 không
                    if (min2 == max2)
                    {
                        Console.WriteLine("NOT AVAILABLE");
                    }
                    else
                    {
                        Console.WriteLine(min2 + " " + max2);
                    }
                }
                else
                {
                    Console.WriteLine("N INVALID");
                }
            }
        }

        // phương thức tìm giá trị nhỏ thứ hai trong mảng
        static int Min2(int[] arr)
        {
            int min = arr[0];
            foreach (var item in arr)
            {
                if (item > min)
                {
                    min = item;
                    break;
                }
            }
            return min;
        }

        // phương thức tìm giá trị lớn thứ hai trong mảng
        static int Max2(int[] arr)
        {
            int max = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < max)
                {
                    max = arr[i];
                    break;
                }
            }
            return max;
        }
    }
}
