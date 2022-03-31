/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson54
{
    class Exercises6
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().ToCharArray();
                Console.WriteLine($"Test {i}: ");
                Solve(elements);
            }
        }

        // phương thức đếm số kí tự có giá trị bằng x trong mảng
        static int CountX(char[] data, char x)
        {
            var count = 0;
            foreach (char c in data)
            {
                if(c == x)
                {
                    count++;
                }
            }
            return count;
        }

        // phương thức kiểm tra xem kí tự x đã tồn tại trước vị trí pos chưa
        static bool IsExisted(char[] data, int x, int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                if(data[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

        // phương thức hiển thị từng kí tự và số lần xuất hiện của nó
        static void Solve(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(!IsExisted(arr, arr[i], i))
                {
                    Console.WriteLine($"'{arr[i]}' {CountX(arr, arr[i])}");
                }
            }
        }
    }
}
