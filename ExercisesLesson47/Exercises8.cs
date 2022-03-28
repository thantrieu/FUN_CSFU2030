/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises8
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var data = Console.ReadLine().Split(' ');
                int a = int.Parse(data[0]);
                int b = int.Parse(data[1]);
                if (a * b == 0)
                {
                    if (a == 0 && b == 0)
                    {
                        Console.WriteLine($"Test {test}: {"ERROR ERROR"}");
                    }
                    else if (a != 0 || b != 0)
                    {
                        Console.WriteLine($"Test {test}: {(a == 0 ? b : a)} ERROR");
                    }
                }
                else
                {
                    var g = Gcd(a, b);
                    Console.WriteLine($"Test {test}: {g} {a * b / g}");
                }
            }
        }

        // phương thức đệ quy tìm ước chung lớn nhất giữa hai số nguyên dương
        static int Gcd(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a > b)
            {
                return Gcd(a - b, b);
            }
            else
            {
                return Gcd(a, b - a);
            }
        }
    }
}
