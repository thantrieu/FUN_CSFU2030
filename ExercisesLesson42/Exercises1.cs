using System;

namespace ExercisesLesson42
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            GetData(ref a, ref b, ref c);
            ShowData(in a, in b, in c);
        }

        /// <summary>
        /// Phương thức nhập thông tin cho ba số nguyên a, b, c.
        /// </summary>
        /// <param name="a">Số thứ nhất.</param>
        /// <param name="b">Số thứ hai.</param>
        /// <param name="c">Số thứ ba.</param>
        static void GetData(ref int a, ref int b, ref int c)
        {
            Console.Write("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen c: ");
            c = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Phương thức tính tổng ba số.
        /// </summary>
        /// <param name="a">Số nguyên thứ 1.</param>
        /// <param name="b">Số nguyên thứ 2.</param>
        /// <param name="c">Số nguyên thứ 3.</param>
        /// <returns>Tổng ba số.</returns>
        static int Sum(in int a, in int b, in int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Phương thức hiển thị thông tin tổng ba số.
        /// </summary>
        /// <param name="a">Số nguyên thứ 1.</param>
        /// <param name="b">Số nguyên thứ 2.</param>
        /// <param name="c">Số nguyên thứ 3.</param>
        static void ShowData(in int a, in int b, in int c)
        {
            Console.WriteLine($"{a} + {b} + {c} = {Sum(a, b, c)}");
        }
    }
}
