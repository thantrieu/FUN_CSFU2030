using System;

namespace ExercisesLesson41
{
    class Exercses30
    {
        static void Main()
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so nguyen to trong doan [a, b]: ");
            ListedPrimeNumbers(a, b);
            Console.WriteLine("Cac so chinh phuong trong doan [a, b]: ");
            ListedSquareNumbers(a, b);
            Console.WriteLine("Cac so thuan nghich trong doan [a, b]: ");
            ListedSymmetryNumbers(a, b);
            Console.WriteLine("Cac so co tong chu so la so nguyen to trong doan [a, b]: ");
            ListedNumberSumDigitsIsPrime(a, b);
        }

        /// <summary>
        /// Phương thức thực hiện đảo ngược giá trị số nguyên n.
        /// Ví dụ 123 -> 321
        /// </summary>
        /// <param name="n">Số nguyên cần đảo ngược</param>
        /// <returns>Số đảo ngược thứ tự các chữ số của n</returns>
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
        /// Phương thức kiểm tra n có phải số đẹp không.
        /// </summary>
        /// <param name="n">Số cần kiểm tra.</param>
        /// <returns>true nếu n là số thuận nghịch(đẹp) và false nếu ngược lại.</returns>
        static bool IsSymmetry(int n)
        {
            int reverse = ReverseNumber(n);
            return reverse == n;
        }

        /// <summary>
        /// Phương thức kiểm tra số n có phải số nguyên tố hay không.
        /// </summary>
        /// <param name="n">Số cần kiểm tra.</param>
        /// <returns>true nếu n nguyên tố và false nếu ngược lại.</returns>
        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Phương thức tính tổng các chữ số của số nguyên n.
        /// </summary>
        /// <param name="n">Số nguyên dương cần tính tổng chữ số.</param>
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
        /// Phương thức kiểm tra số n là số chính phương.
        /// Lấy phần nguyên x của căn bậc hai của n. Nếu 
        /// x*x bằng n thì n là số chính phương.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra.</param>
        /// <returns>true nếu n là số chính phương và false nếu ngược lại.</returns>
        static bool IsSquare(int n)
        {
            if(n < 0)
            {
                return false; // tất cả số âm KHÔNG phải số chính phương
            }
            int x = (int)Math.Sqrt(n);
            return x * x == n;
        }

        /// <summary>
        /// Phương thức liệt kê các số nguyên tố trong đoạn [a, b].
        /// </summary>
        /// <param name="a">Biên dưới thỏa a <= b.</param>
        /// <param name="b">Biên trên thỏa a <= b.</param>
        static void ListedPrimeNumbers(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if(IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Phương thức liệt kê các số thuận nghịch trong đoạn [a, b].
        /// </summary>
        /// <param name="a">Biên dưới thỏa a <= b.</param>
        /// <param name="b">Biên trên thỏa a <= b.</param>
        static void ListedSymmetryNumbers(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (IsSymmetry(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Phương thức liệt kê các số có tổng các chữ số 
        /// là số nguyên tố trong đoạn [a, b].
        /// </summary>
        /// <param name="a">Biên dưới thỏa a <= b.</param>
        /// <param name="b">Biên trên thỏa a <= b.</param>
        static void ListedNumberSumDigitsIsPrime(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (IsPrime(SumDigits(i)))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Phương thức liệt kê các số chính phương trong đoạn [a, b].
        /// </summary>
        /// <param name="a">Biên dưới.</param>
        /// <param name="b">Biên trên.</param>
        static void ListedSquareNumbers(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (IsSquare(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
