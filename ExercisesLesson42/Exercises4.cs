using System;

namespace ExercisesLesson42
{
    class Exercises4
    {
        static void Main()
        {
            GetData(out int a, out int b);
            Add(a, b, out int sum);
            Div(a, b, out float quot);
            Mul(a, b, out int product);
            Console.WriteLine("=================");
            ShowResult(a, b, "+", sum);
            ShowResult(a, b, "/", quot);
            ShowResult(a, b, "*", product);
        }

        /// <summary>
        /// Tính tổng hai số.
        /// </summary>
        /// <param name="a">Toán hạng 1.</param>
        /// <param name="b">Toán hạng 2.</param>
        /// <param name="sum">Tổng hai số.</param>
        static void Add(int a, int b, out int sum)
        {
            sum = a + b;
        }

        /// <summary>
        /// Tính thương a chia b. 
        /// </summary>
        /// <param name="a">Toán hạng 1.</param>
        /// <param name="b">Mẫu số, khác 0.</param>
        /// <param name="quot">Thương a chia b.</param>
        static void Div(int a, int b, out float quot)
        {
            quot = (float)a / b;
        }

        /// <summary>
        /// Tính tích hai số nguyên và lưu kết quả vào biến product.
        /// </summary>
        /// <param name="a">Toán hạng 1.</param>
        /// <param name="b">Toán hạng 2.</param>
        /// <param name="product">Tích hai số.</param>
        static void Mul(int a, int b, out int product)
        {
            product = a * b;
        }

        /// <summary>
        /// Phương thức hiển thị thông tin phép toán và kết quả lên màn hình.
        /// </summary>
        /// <param name="a">Toán hạng 1.</param>
        /// <param name="b">Toán hạng 2.</param>
        /// <param name="op">Phép toán.</param>
        /// <param name="result">Kết quả phép toán.</param>
        static void ShowResult(in int a, in int b, in string op, in float result)
        {
            Console.WriteLine($"{a} {op} {b} = {result}");
        }

        /// <summary>
        /// Phương thức nhập thông tin cho hai số nguyên a, b.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        static void GetData(out int a, out int b)
        {
            Console.Write("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
        }
    }
}
