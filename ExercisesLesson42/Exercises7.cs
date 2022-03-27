using System;

namespace ExercisesLesson42
{
    class Exercises7
    {
        static void Main()
        {
            GetData(out int a, out int b);
            Gcd(a, b, out int gcd);
            Lcm(a, b, out int lcm);
            ShowResult("UCLN", gcd);
            ShowResult("BCNN", lcm);
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
        /// Phương thức tìm ước chung lớn nhất của hai số.
        /// Giả định nếu cả hai số bằng 0 thì UCLN bằng 0.
        /// </summary>
        /// <param name="a">Số nguyên a</param>
        /// <param name="b">Số nguyên b</param>
        /// <param name="gcd">Ước chung lớn nhất của a và b.</param>
        static void Gcd(int a, int b, out int gcd)
        {
            if (a == 0 && b == 0)
            {
                gcd = 0;
                return;
            }
            else if (a == 0 && b != 0 || a != 0 && b == 0)
            {
                gcd = a == 0 ? b : a;
                return;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            gcd = a;
        }
        /// <summary>
        /// Phương thức tìm bội chung nhỏ nhất của hai số a, b.
        /// Giả định hai số bằng 0 thì BCNN bằng 0.
        /// </summary>
        /// <param name="a">Số nguyên a.</param>
        /// <param name="b">Số nguyên b.</param>
        /// <param name="lcm">Bội chung nhỏ nhất của hai số.</param>
        static void Lcm(int a, int b, out int lcm)
        {
            if (a * b == 0)
            {
                lcm = 0;
            }
            else
            {
                Gcd(a, b, out int gcd);
                lcm = a * b / gcd;
            }
        }

        /// <summary>
        /// Phương thức nhập dữ liệu đầu vào cho hai số nguyên.
        /// </summary>
        /// <param name="a">Số nguyên a.</param>
        /// <param name="b">Số nguyên b.</param>
        static void GetData(out int a, out int b)
        {
            Console.Write("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
        }
    }
}
