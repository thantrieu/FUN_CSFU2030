/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
    class Exercises6
    {
        // phương thức vẽ hình chữ nhật
        static char[,] DrawRect(int m, int n)
        {
            char[,] rect = new char[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == 0 || j == 0 || i == m-1 || j == n-)
                    {
                        rect[i, j] = '*';
                    } else
                    {
                        rect[i, j] = ' ';
                    }
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
            var data = Console.ReadLine().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            if (m <= 0 || n <= 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                var result = DrawRect(m, n);
                ShowResult(result);
            }
        }
    }
}
