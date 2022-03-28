/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.28
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises7
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                string s = Console.ReadLine();
                Console.Write($"Test {test}: ");
                PrintCharacter(s, s.Length - 1);
                Console.WriteLine();
            }
        }

        // phương thức đệ quy in ra các chữ cái của chuỗi kí tự theo thứ tự đảo ngược
        static void PrintCharacter(string str, int n)
        {
            if (n < 0)
            {
                return;
            }
            else
            {
                Console.Write(str[n]);
                PrintCharacter(str, n - 1);
            }
        }
    }
}
