/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
    class Exercises2
    {
        // phương thức nhập vào các thông tin ma trận và trả về một ma trận
        static float[,] GetMatrix()
        {
            var data = Console.ReadLine().Split(' ');
            var m = int.Parse(data[0]);
            var n = int.Parse(data[1]);
            if(m > 0 && n > 0)
            {
                float[,] matrix = new float[m, n];
                int index = 0;
                for (int i = 0; i < m; i++)
                {
                    var elements = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = float.Parse(elements[j]);
                    }
                }
                return matrix;
            } else
            {
                return null;
            }
        }

        // phương thức chuyển vị ma trận
        static float[,] Transposition(float[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            float[,] result = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = matrix[j, i];
                }
            }
            return result;
        }

        // phương thức hiển thị các phần tử của ma trận
        static void ShowMatrix(float[,] matrix)
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
            if(matrix != null)
            {
                ShowMatrix(matrix);
                var result = Transposition(matrix);
                ShowMatrix(result);
            } else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
