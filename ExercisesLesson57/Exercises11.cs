/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises11
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {i}: ");
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int index = 0; index < elements.Length; index++)
                    {
                        arr[index] = int.Parse(elements[index]);
                    }
                    ListedSymmetryNumbers(arr);
                }
                else
                {
                    Console.WriteLine("N INVALID");
                }
            }
        }

        // phương thức liệt kê số thuận nghịch
        static void ListedSymmetryNumbers(int[] arr)
        {
            Func<int, bool> isSymmetry = (x) =>
            {
                if(x < 0)
                {
                    x = -x;
                }
                if (x < 10)
                {
                    return false;
                }
                var reverseOfN = Revert(x);
                return reverseOfN == x;
            };
            // hàm cục bộ đảo ngược giá trị của n
            int Revert(int n)
            {
                int rev = 0;
                while (n > 0)
                {
                    rev = rev * 10 + n % 10;
                    n /= 10;
                }
                return rev;
            }
            // đoạn chương trình liệt kê các số thuận nghịch
            for (int i = 0; i < arr.Length; i++)
            {
                if (isSymmetry(arr[i]))
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
