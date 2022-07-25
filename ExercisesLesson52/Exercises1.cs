/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
    class Exercises1
    {
        // phương thức nhập vào các thông tin ma trận và trả về một ma trận
        static int[,] GetMatrix()
        {
            var data = Console.ReadLine().Split(' ');
            var m = int.Parse(data[0]);
            var n = int.Parse(data[1]);
            if (m > 0 && n > 0)
            {
                int[,] matrix = new int[m, n];
                var elements = Console.ReadLine().Split(' ');
                //int index = 0;
                for (int i = 0; i < m; i++)
                {                   
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(elements[i * n + j]);
                    }
                }
                return matrix;
            }
            else
            {
                return null;
            }
        }

        // phương thức hiển thị các phần tử của ma trận
        static void ShowMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            Console.WriteLine($"{m} {n}");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var matrix = GetMatrix();
            if (matrix != null)
            {
                ShowMatrix(matrix);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
