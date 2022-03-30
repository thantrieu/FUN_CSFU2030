/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
    class Exercises11
    {
        static int M = 6;
        static int N = 7;
        // phương thức vẽ hình tam giác
        static string[,] DrawTriangle()
        {
            var heat = new string[M, N];
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (((i != 2 && i != 3) && (j == 1 || j == 7))
                        || (i == 1 && j == 4)
                        || (i >= 5 && (j == 2 || j == 6))
                        || (i == 6 && (j == 3 || j == 5)))
                    {
                        heat[i - 1, j - 1] = "   ";
                    }
                    else
                    {
                        heat[i - 1, j - 1] = " * ";
                    }
                }
            }
            return heat;
        }

        // phương thức hiển thị kết quả
        static void ShowResult(string[,] rect)
        {
            for (int i = 0; i < rect.GetLength(0); i++)
            {
                for (int j = 0; j < rect.GetLength(1); j++)
                {
                    Console.Write($" {rect[i, j]} ");
                }
                Console.WriteLine("\n");
            }
        }

        static void Main()
        {
            var result = DrawTriangle();
            ShowResult(result);
        }
    }
}
