using System;

namespace ExercisesLesson41
{
    class Exercises28
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum digits of {n}: {SumDigits(n)}");
            Console.WriteLine($"Product digits of {n}: {ProductDigits(n)}");
            Console.WriteLine($"First digit of {n}: {FirstDigit(n)}");
        }

        /// <summary>
        /// Phương thức tính tổng các chữ số của số nguyên n.
        /// </summary>
        /// <param name="n">Số cần tính tổng các chữ số.</param>
        /// <returns>Tổng các chữ số của số n.</returns>
        static int SumDigits(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int ProductDigits(int n)
        {
            int product = 1;
            while(n > 0)
            {
                product *= n % 10;
                n /= 10;
            }
            return product;
        }

        /// <summary>
        /// Phương thức tìm chữ số đầu tiên của n.
        /// </summary>
        /// <param name="n">Số nguyên cần tìm chữ số đầu tiên.</param>
        /// <returns>Chữ số đầu tiên của n.</returns>
        static int FirstDigit(int n)
        {
            while(n > 10)
            {
                n /= 10;
            }
            return n;
        }
    }
}
