using System;

namespace ExercisesLesson45
{
    class Exercises6
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var data = Console.ReadLine().Split(' ');
                float a = float.Parse(data[0]);
                float b = float.Parse(data[1]);
                float c = float.Parse(data[2]);
                Console.WriteLine($"Test {test}: {(IsTriangle(a, b, c) ? "YES" : "NO")}");
            }
        }

        /// <summary>
        /// Phương thức kiểm tra ba số a, b, c có lập thành tam giác không.
        /// </summary>
        /// <param name="a">Số thực thứ 1.</param>
        /// <param name="b">Số thực thứ 2.</param>
        /// <param name="c">Số thực thứ 3.</param>
        /// <returns>true nếu ba số lập thành tam giác và false nếu ngược lại.</returns>
        static bool IsTriangle(float a, float b, float c)
        {
            return CreateTriangle();
            bool CreateTriangle()
            {
                // lập thành tam giác nếu tổng 2 cạnh bất kì luôn lớn hơn cạnh còn lại
                if (a + b > c && b + c > a && a + c > b)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
