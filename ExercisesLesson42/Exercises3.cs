using System;

namespace ExercisesLesson42
{
    class Exercises3
    {
        static void Main()
        {
            GetN(out uint n);
            SumDigits(n, out uint sum);
            ProductDigits(n, out uint product);
            FirstDigits(n, out uint digit);
            PrintResult("Tong cac chu so cua " + n, sum);
            PrintResult("Tich cac chu so cua " + n, product);
            PrintResult("Chu so dau tien cua " + n, digit);
        }

        /// <summary>
        /// Phương thức tính tổng các chữ số của n.
        /// </summary>
        /// <param name="n">Số nguyên cần tính tổng chữ số.</param>
        /// <param name="result">Tổng tìm được.</param>
        static void SumDigits(uint n, out uint result)
        {
            result = 0;
            while(n > 0)
            {
                result += n % 10;
                n /= 10;
            }
        }

        /// <summary>
        /// Phương thức tính tích các chữ số của số nguyên dương n.
        /// </summary>
        /// <param name="n">Số nguyên cần tính tích chữ số.</param>
        /// <param name="result">Tích tính được.</param>
        static void ProductDigits(uint n, out uint result)
        {
            result = 1;
            while (n > 0)
            {
                result *= n % 10;
                n /= 10;
            }
        }

        /// <summary>
        /// Phương thức tìm chữ số đầu tiên của số nguyên dương n.
        /// </summary>
        /// <param name="n">Số nguyên cần tìm chữ số đầu tiên.</param>
        /// <param name="result">Chữ số đầu tiên của n.</param>
        static void FirstDigits(uint n, out uint result)
        {
            while (n > 10)
            {
                n /= 10;
            }
            result = n;
        }

        /// <summary>
        /// Phương thức nhập dữ liệu cho số nguyên dương n.
        /// </summary>
        /// <param name="n">Số n cần nhập giá trị.</param>
        static void GetN(out uint n)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            n = uint.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Phương thức hiển thị kết quả lên màn hình.
        /// </summary>
        /// <param name="msg">Thông điệp kết quả.</param>
        /// <param name="result">Giá trị cần hiển thị.</param>
        static void PrintResult(in string msg, in uint result)
        {
            Console.WriteLine(msg + ": " + result);
        }
    }
}
