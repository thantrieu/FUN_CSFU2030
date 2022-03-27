using System;

namespace ExercisesLesson45
{
    class Exercises2
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var data = Console.ReadLine().Split(' ');
                int a = int.Parse(data[0]);
                int b = int.Parse(data[1]);
                Console.WriteLine($"Test {test}: ");
                ListedPrimes(a, b);
            }
        }

        /// <summary>
        /// Phương thức liệt kê các số nguyên tố trong đoạn [a, b].
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        static void ListedPrimes(int a, int b)
        {
            int counter = 0;
            for (int k = a; k <= b; k++)
            {
                if (IsPrime(k))
                {
                    Console.Write(k + " ");
                    counter++;
                }
            }
            Console.WriteLine(counter == 0 ? "NO RESULT" : ""); // ghi xuong dong

            bool IsPrime(int n)
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
}
