using System;

namespace ExercisesLesson41
{
    class Exercises29
    {
        static void Main()
        {
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} la so nguyen to? {IsPrime(n)}");
            Console.WriteLine($"{n} la so dep? {IsSymmetry(n)}");
            int reverseOfN = ReverseNumber(n);
            Console.WriteLine($"{reverseOfN} la so nguyen to? {IsPrime(reverseOfN)}");
            int sumDigits = SumDigits(n);
            Console.WriteLine($"{sumDigits} la so nguyen to? {IsPrime(sumDigits)}");
        }

        /// <summary>
        /// Phương thức tính tổng các chữ số của n.
        /// </summary>
        /// <param name="n">Số cần tính tổng các chữ số.</param>
        /// <returns>Tổng các chữ số của n.</returns>
        static int SumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Phương thức tìm số đảo ngược của n.
        /// Ví dụ 123 -> 321
        /// </summary>
        /// <param name="n">Số cần đảo ngược.</param>
        /// <returns>Giá trị đảo ngược của n.</returns>
        static int ReverseNumber(int n)
        {
            int reverse = 0;
            while (n > 0)
            {
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            return reverse;
        }

        /// <summary>
        /// Phương thức kiểm tra một số có phải số thuận nghịch không.
        /// Ví dụ số thuận nghịch: 1221
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsSymmetry(int n)
        {
            int reverse = ReverseNumber(n);
            return reverse == n;
        }

        /// <summary>
        /// Phương thức kiểm tra một số nguyên có phải số nguyên tố không.
        /// Số nguyên tố là các số chỉ chia hết cho 1 và chính nó.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsPrime(int n)
        {
            if(n < 2) // mọi số nhỏ hơn 2 không phải nguyên tố
            {
                return false;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            { 
                if(n % i == 0) // nếu n có ước khác 1 và n
                {
                    return false; // n không phải số nguyên tố
                }
            }
            return true; // n là số nguyên tố
        }
    }
}
