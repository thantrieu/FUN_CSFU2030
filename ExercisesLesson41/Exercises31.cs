using System;

namespace ExercisesLesson41
{
    class Exercises31
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"So nguyen to ke tiep cua {n}: {NextPrimeNumber(n)}");
            int x = PrevPrimeNumber(n);
            Console.WriteLine($"So nguyen to lien truoc cua {n}: {(x == -1 ? "NOT AVAILABLE" : x + "")}");
            Console.Write(n + " = ");
            Factorize(n);
            Console.Write(n + " = ");
            FactorizeWithExponent(n);
            Console.WriteLine("Cac so nguyen to 5 chu so: ");
            ListedPrimeNumber5Digits();
        }

        /// <summary>
        /// Phương thức phân tích số nguyên n thành thừa số nguyên tố.
        /// </summary>
        /// <param name="n">Số n cần phân tích.</param>
        static void Factorize(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Khong the phan tich ra thua so nguyen to.");
            }
            else
            {
                int k = 2;
                while (n > 1)
                {
                    if (n % k == 0)
                    {
                        Console.Write(k + (n != k ? "x" : ""));
                        n /= k; // giảm n đi k lần
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Phương thức phân tích.
        /// </summary>
        /// <param name="n"></param>
        static void FactorizeWithExponent(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Khong the phan tich ra thua so nguyen to.");
            }
            else
            {
                int k = 2;
                int count = 0;
                while (n > 1)
                {
                    if (n % k == 0)
                    {
                        if (count == 0)
                        {
                            Console.Write(k);
                        }
                        count++;
                        n /= k; // giảm n đi k lần
                    }
                    else
                    {
                        k++;
                        if (count > 1)
                        {
                            Console.Write($"^{count}");
                        }
                        if (count >= 1)
                        {
                            count = 0;
                            Console.Write("x");
                        }
                    }
                }
                Console.WriteLine($"{(count > 1 ? "^" + count : "")}");
            }
        }

        /// <summary>
        /// Tìm số nguyên tố kế tiếp.
        /// </summary>
        /// <param name="n">Số nguyên chọn làm mốc.</param>
        /// <returns>Số nguyên tố đứng ngay sau số n.</returns>
        static int NextPrimeNumber(int n)
        {
            if (n < 1)
            {
                n = 1;
            }
            while (true)
            {
                n++;
                if (IsPrime(n))
                {
                    return n;
                }
            }
        }

        /// <summary>
        /// Phương thức tìm số nguyên tố liền trước của n.
        /// </summary>
        /// <param name="n">Giá trị mốc.</param>
        /// <returns>Số nguyên tố tìm được hoặc -1 nếu không có kết quả.</returns>
        static int PrevPrimeNumber(int n)
        {
            if (n <= 2)
            {
                return -1;
            }
            while (n > 2)
            {
                n--;
                if (IsPrime(n))
                {
                    return n;
                }
            }
            return -1;
        }

        /// <summary>
        /// Phương thức liệt kê các số nguyên tố có 5 chữ số.
        /// </summary>
        static void ListedPrimeNumber5Digits()
        {
            int counter = 0;
            for (int i = 10000; i < 100000; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    counter++;
                    if (counter % 20 == 0) // mỗi dòng in 20 số
                    {
                        counter = 0;
                        Console.WriteLine(); // in xuống dòng
                    }
                }
            }
            Console.WriteLine();
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
    }
}
