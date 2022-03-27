using System;

namespace ExercisesLesson41
{
    class Exercises27
    {
        static void Main()
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN = " + Gcd(a, b));
            Console.WriteLine("BCNN = " + Lcm(a, b));
        }

        /// <summary>
        /// Phương thức tìm bội chung nhỏ nhất.
        /// Nếu ước chung bằng 0 thì bội chung giả định bằng 0.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        /// <returns>BCNN tìm được.</returns>
        static int Lcm(int a, int b)
        {
            int gcd = Gcd(a, b);
            if(gcd == 0)
            {
                return 0;
            }
            return a * b / gcd;
        }

        /// <summary>
        /// Phương thức tìm ước chung lớn nhất.
        /// Nếu a hoặc b bằng 0 thì ước chung lớn nhất bằng 0.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        /// <returns>UCLN tìm được.</returns>
        static int Gcd(int a, int b)
        {
            if(a <= 0 || b <= 0)
            {
                return 0;
            }
            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                } else
                {
                    b -= a;
                }
            }
            return a;
        }
    }
}
