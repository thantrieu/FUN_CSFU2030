using System;

namespace ExercisesLesson45
{
    class Exercises3
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
                ListedSquareNumbers(a, b);
            }
        }

        /// <summary>
        /// Phương thức liệt kê các số chính phương trong đoạn [a, b].
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất.</param>
        /// <param name="b">Số nguyên thứ hai.</param>
        static void ListedSquareNumbers(int a, int b)
        {
            int counter = 0;
            for (int k = a; k <= b; k++)
            {
                if (IsSquare(k))
                {
                    Console.Write(k + " ");
                    counter++;
                }
            }
            Console.WriteLine(counter == 0 ? "NO RESULT" : ""); // ghi xuong dong

            bool IsSquare(int n)
            {
                if (n < 0)
                {
                    return false;
                }
                int bound = (int)Math.Sqrt(n);
                return bound * bound == n;
            }
        }
    }
}
