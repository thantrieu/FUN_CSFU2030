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
        static float[,] GetMatrix(int m, int n)
        {
            if (m > 0 && n > 0)
            {
                float[,] matrix = new float[m, n];
                for (int i = 0; i < m; i++)
                {
                    var elements = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = float.Parse(elements[j]);
                    }
                }
                return matrix;
            }
            else
            {
                return null;
            }
        }

        // phương thức tính tổng hai ma trận
        static float[,] AddMatrix(float[,] matrix1, float[,] matrix2)
        {
            int m1 = matrix1.GetLength(0);
            int m2 = matrix1.GetLength(1);
            int n1 = matrix1.GetLength(0);
            int n2 = matrix1.GetLength(1);
            if(m1 != m2 || n1 != n2)
            {
                return null;
            }
            float[,] result = new float[m1, n1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
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
            float[,] matrix1;
            float[,] matrix2;
            var data = Console.ReadLine().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            int p = int.Parse(data[2]);
            int q = int.Parse(data[3]);
            
            if (m != p || n != q)
            {
                Console.WriteLine("INVALID ACTION");
            }
            else
            {
                matrix1 = GetMatrix(m, n);
                matrix2 = GetMatrix(p, q);
                var result = AddMatrix(matrix1, matrix2);
                ShowMatrix(result);
            }
        }
    }
}
