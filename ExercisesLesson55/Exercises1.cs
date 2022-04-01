/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson55
{
    class Exercises1
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
                    // sắp xếp
                    Array.Sort(arr); // tăng dần
                    int min = arr[0]; // giá trị đầu mảng là min
                    int max = arr[arr.Length - 1]; // giá trị cuối mảng là max
                    // kiểm tra xem min có trùng max không
                    if (min == max)
                    {
                        Console.WriteLine("NOT AVAILABLE");
                    }
                    else
                    {
                        Console.WriteLine(min + " " + max);
                    }
                }
                else
                {
                    Console.WriteLine("N INVALID");
                }
            }
        }
    }
}
