/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises9
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
                    ListedPrimeNumbers(arr);
                }
                else
                {
                    Console.WriteLine("N INVALID");
                }
            }
        }

        static void ListedPrimeNumbers(int[] arr)
        {
            Func<int, bool> isPrime = (x) =>
            {
                if (x < 2)
                {
                    return false;
                }
                int bound = (int)Math.Sqrt(x);
                for (int i = 2; i <= bound; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]))
                {
                    Console.Write($"({i}, {arr[i]}) ");
                }
            }
            Console.WriteLine();
        }
    }
}
