using System;

namespace ExercisesLesson43
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so d: ");
            int d = int.Parse(Console.ReadLine());

            // gọi phương thức tính tổng:
            Console.WriteLine($"{a} + {b} = {Add(a, b)}");
            Console.WriteLine($"{a} + {b} + {c} = {Add(a, b, d)}");
            Console.WriteLine($"{a} + {b} + {c} + {d} = {Add(a, b, c, d)}");
            float x = 12.35f;
            float y = 54.37f;
            double z = -2.57;
            Console.WriteLine($"{x} + {y} = {Add(x, y)}");
            Console.WriteLine($"{x} + {z} = {Add(x, z)}");
        }

        /// <summary>
        /// Phương thức cộng hai số nguyên.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        /// <returns>Tổng hai số nguyên</returns>
        static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Phương thức tính tổng ba số nguyên int.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        /// <param name="c">Số nguyên thứ ba.</param>
        /// <returns>Kết quả tìm được.</returns>
        static int Add(int a, int b, int c)
        {
            return Add(a, b) + c;
        }

        /// <summary>
        /// Phương thức tính tổng 4 số nguyên.
        /// </summary>
        /// <param name="a">Số nguyên thứ 1.</param>
        /// <param name="b">Số nguyên thứ 2.</param>
        /// <param name="c">Số nguyên thứ 3.</param>
        /// <param name="d">Số nguyên thứ 4.</param>
        /// <returns>Tổng 4 số.</returns>
        static int Add(int a, int b, int c, int d)
        {
            return Add(a, b, c) + d;
        }

        /// <summary>
        /// Phương thức tính tổng hai số thực float.
        /// </summary>
        /// <param name="a">Số thứ nhất.</param>
        /// <param name="b">Số thứ hai.</param>
        /// <returns>Tổng tính được.</returns>
        static float Add(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        /// Phương thức tính tổng 3 số thực double.
        /// </summary>
        /// <param name="a">Toán hạng 1.</param>
        /// <param name="b">Toán hạng 2.</param>
        /// <returns>Tổng a + b.</returns>
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
