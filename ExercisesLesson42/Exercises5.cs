using System;

namespace ExercisesLesson42
{
    class Exercises5
    {
        static void Main()
        {
            GetData(out int a, out int b, out int c);
            Max(a, b, c, out int max);
            Min(a, b, c, out int min);
            Average(a, b, c, out float avg);
            SecondMax(a, b, c, out int max2);
            SecondMin(a, b, c, out int min2);
            Console.WriteLine("=====================");
            ShowResult("Gia tri max", max);
            ShowResult("Gia tri min", min);
            ShowResult("Gia tri TB", avg);
            ShowResult("Gia tri max2", max2);
            ShowResult("Gia tri min2", min2);
        }

        /// <summary>
        /// Phương thức tìm giá trị nhỏ thứ hai.
        /// </summary>
        /// <param name="a">Số thứ 1</param>
        /// <param name="b">Số thứ 2</param>
        /// <param name="c">Số thứ 3</param>
        /// <returns>Giá trị nhỏ thứ 2 trong 3 số</returns>
        static void SecondMin(int a, int b, int c, out int secondMin)
        {
            if (a == b && b == c)
            {
                secondMin = a;
                return;
            }
            Min(a, b, c, out int min);
            Max(a, b, c, out int max);
            secondMin = max;
            if (secondMin > a && a != min)
            {
                secondMin = a;
            }
            if (secondMin > b && b != min)
            {
                secondMin = b;
            }
            if (secondMin > c && c != min)
            {
                secondMin = c;
            }
        }

        /// <summary>
        /// Phương thức tìm giá trị lớn thứ hai.
        /// </summary>
        /// <param name="a">Số thứ 1</param>
        /// <param name="b">Số thứ 2</param>
        /// <param name="c">Số thứ 3</param>
        /// <returns>Giá trị lớn thứ 2 trong 3 số</returns>
        static void SecondMax(int a, int b, int c, out int secondMax)
        {
            if (a == b && b == c)
            {
                secondMax = a;
                return;
            }
            Min(a, b, c, out int min);
            Max(a, b, c, out int max);
            secondMax = min;
            if (secondMax < a && a != max)
            {
                secondMax = a;
            }
            if (secondMax < b && b != max)
            {
                secondMax = b;
            }
            if (secondMax < c && c != max)
            {
                secondMax = c;
            }
        }

        /// <summary>
        /// Phương thức hiển thị kết quả lên màn hình.
        /// </summary>
        /// <param name="msg">Thông điệp cần hiển thị.</param>
        /// <param name="result">Giá trị kết quả.</param>
        static void ShowResult(in string msg, in float result)
        {
            Console.WriteLine(msg + ": " + result);
        }

        /// <summary>
        /// Phương thức tính trung bình cộng của ba số.
        /// </summary>
        /// <param name="a">Số thứ 1.</param>
        /// <param name="b">Số thứ 2.</param>
        /// <param name="c">Số thứ 3.</param>
        /// <param name="result">Kết quả trung bình cộng.</param>
        static void Average(in int a, in int b, in int c, out float result)
        {
            result = (a + b + c) / 3.0f;
        }

        /// <summary>
        /// Phương thức tìm giá trị nhỏ nhất trong ba số.
        /// </summary>
        /// <param name="a">Số thứ 1.</param>
        /// <param name="b">Số thứ 2.</param>
        /// <param name="c">Số thứ 3.</param>
        /// <param name="result">Giá trị nhỏ nhất tìm được.</param>
        static void Min(in int a, in int b, in int c, out int result)
        {
            result = Math.Min(a, Math.Min(b, c));
        }

        /// <summary>
        /// Phương thức tìm giá trị lớn nhất trong ba số.
        /// </summary>
        /// <param name="a">Số thứ 1.</param>
        /// <param name="b">Số thứ 2.</param>
        /// <param name="c">Số thứ 3.</param>
        /// <param name="result">Giá trị lớn nhất tìm được.</param>
        static void Max(in int a, in int b, in int c, out int result)
        {
            result = Math.Max(a, Math.Max(b, c));
        }

        /// <summary>
        /// Phương thức nhập thông tin cho ba số nguyên a, b, c.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        /// <param name="c">Số nguyên thứ ba.</param>
        static void GetData(out int a, out int b, out int c)
        {
            Console.Write("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen c: ");
            c = int.Parse(Console.ReadLine());
        }
    }
}
