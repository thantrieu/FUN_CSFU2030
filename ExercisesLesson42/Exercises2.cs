using System;

namespace ExercisesLesson42
{
    class Exercises2
    {
        static void Main()
        {
            GetData(out float a, out float b, out float c);
            CanCreateTriangle(a, b, c, out bool result);
            Console.WriteLine("Tao tam giac? " + result);
            float sum = Sum(a, b, c);
            Console.WriteLine($"{a} + {b} + {c} = " + sum);
        }

        /// <summary>
        /// Phương thức tính tổng ba số thực.
        /// </summary>
        /// <param name="a">Số thứ 1.</param>
        /// <param name="b">Số thứ 2.</param>
        /// <param name="c">Số thứ 3.</param>
        /// <returns></returns>
        static float Sum(in float a, in float b, in float c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Phương thức nhập thông tin cho ba số thực float.
        /// </summary>
        /// <param name="a">Số thứ 1.</param>
        /// <param name="b">Số thứ 2.</param>
        /// <param name="c">Số thứ 3.</param>
        static void GetData(out float a, out float b, out float c)
        {
            Console.Write("Nhap so thuc a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c: ");
            c = float.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Phương thức kiểm tra ba số thực có lập thành tam giác không.
        /// </summary>
        /// <param name="a">Số thứ 1.</param>
        /// <param name="b">Số thứ 2.</param>
        /// <param name="c">Số thứ 3.</param>
        /// <param name="result">Kết quả true hoặc false.</param>
        static void CanCreateTriangle(float a, float b, float c, out bool result)
        {
            if(a + b > c && a + c > b && b + c > a)
            {
                result = true; 
            } else
            {
                result = false;
            }
        }
    }
}
