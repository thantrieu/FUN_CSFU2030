/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
    class Exercises7
    {
        // phương thức vẽ hình tam giác
        static char[,] DrawTriangle(int h)
        {
            char[,] rect = new char[h, h];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    rect[i, j] = '*';
                }
            }
            return rect;
        }

        // phương thức hiển thị kết quả
        static void ShowResult(char[,] rect)
        {
            for (int i = 0; i < rect.GetLength(0); i++)
            {
                for (int j = 0; j < rect.GetLength(1); j++)
                {
                    Console.Write($" {rect[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                var result = DrawTriangle(h);
                ShowResult(result);
            }
        }
    }
}
