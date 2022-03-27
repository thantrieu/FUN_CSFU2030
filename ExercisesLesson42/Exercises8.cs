using System;

namespace ExercisesLesson42
{
    class Exercises8
    {
        static void Main()
        {
            int counter = 0;
            for (int i = 22222222; i <= 77777777; i++)
            {
                IsSymmetry(i, out bool isSymmetry);
                AllDigitsIsPrime(i, out bool isAllDigitsPrime);
                if(isSymmetry && isAllDigitsPrime)
                {
                    counter++;
                    Console.Write(i + " ");
                    if(counter % 10 == 0)
                    {
                        counter = 0;
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Phương thức kiểm tra tất cả các chữ số là số nguyên tố
        /// </summary>
        /// <param name="n">Số cần kiểm tra</param>
        /// <param name="result">Kết luận</param>
        static void AllDigitsIsPrime(int n, out bool result)
        {
            while(n > 0)
            {
                IsPrime(n % 10, out result);
                if(result == false)
                {
                    return;
                }
                n /= 10;
            }
            result = true;
        }

        /// <summary>
        /// Phương thức kiểm tra số thuận nghịch.
        /// </summary>
        /// <param name="n">Số cần kiểm tra</param>
        /// <param name="result">Kết quả kiểm tra</param>
        static void IsSymmetry(int n, out bool result)
        {
            int m = n;
            int x = 0;
            while(n > 0)
            {
                x = x * 10 + n % 10;
                n /= 10;
            }
            result = m == x;
        }

        /// <summary>
        /// Phương thức kiểm tra số nguyên tố.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra</param>
        /// <param name="result">Kết quả kiểm tra</param>
        static void IsPrime(int n, out bool result)
        {
            if(n < 2)
            {
                result = false;
                return;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if(n % i == 0)
                {
                    result = false;
                    return;
                }
            }
            result = true;
        }
    }
}
