/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.29
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises12
    {
        // phương thức tạo ma trận xoắn ốc với giá trị tăng dần từ trong ra ngoài
        static void CreateSpiralMatrix(int[,] arr, int prevRow, int nextRow, 
            int prevCol, int nextCol, ref int counter, int bound, int row)
        {
            if(counter >= bound)
            {
                return;
            }
            for (int i = prevCol + 1; i < nextCol + 1; i++)
            {
                if(prevRow >= 0 && i < row)
                {
                    arr[prevRow, i] = counter++;
                }
            }
            prevCol--;
            if(nextCol < row)
            {
                for (int i = prevRow + 1; i < nextRow + 1; i++)
                {
                    if(i < row)
                    {
                        arr[i, nextCol] = counter++;
                    }
                }
                prevRow--;
            }
            if (nextRow < row)
            {
                for (int i = nextCol - 1; i > prevCol - 1; i--)
                {
                    if(i >= 0)
                    {
                        arr[nextRow, i] = counter++;
                    }
                }
                nextCol++;
            }
            if (prevCol >= 0)
            {
                for (int i = nextRow - 1; i > prevRow - 1; i--)
                {
                    if(i >= 0)
                    {
                        arr[i, prevCol] = counter++;
                    }
                }
                nextRow++;
            }
            CreateSpiralMatrix(arr, prevRow, nextRow, prevCol, nextCol, ref counter, bound, row);
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int row = int.Parse(Console.ReadLine());
                int col = row;
                int[,] arr = new int[row, col];
                var value = 1;
                // khởi tạo các giá trị
                var centerRowIndex = (row - 1) / 2;
                var centerColIndex = (col - 1) / 2;
                var nextRow = centerRowIndex + 1;
                var nextCol = centerColIndex + 1;
                var prevRow = centerRowIndex;
                var prevCol = centerColIndex;
                // gán giá trị phần tử chính giữa ma trận
                arr[centerRowIndex, centerColIndex] = value++;
                var upperBound = row * col;
                // tạo ma trận xoắn ốc
                CreateSpiralMatrix(arr, prevRow, nextRow, prevCol, nextCol, ref value,
                    upperBound, row);
                Console.WriteLine($"Test {test}:\n");
                ShowMatrix(arr, row, col);
            }
        }

        // phương thức hiển thị các phần tử trong ma trận
        static void ShowMatrix(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i, j],5:D}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
