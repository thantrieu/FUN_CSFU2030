/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.09.15
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson47
{
    class Exercises13
    {
        // phương thức tạo ma trận xoắn ốc
        static void CreateSpiralMatrix(int[,] arr, int startRow, int stopRow, int startCol, int stopCol)
        {
            if (startRow >= stopRow || startCol >= stopCol)
            {
                return;
            }
            // gán giá trị cho hàng đầu trong số các hàng còn lại
            for (int i = startCol; i < stopCol; i++)
            {
                Console.Write($"{arr[startRow, i]} ");
            }
            startRow++;
            // gán giá trị cho cột cuối trong số các cột còn lại
            for (int i = startRow; i < stopRow; i++)
            {
                Console.Write($"{arr[i, stopCol - 1]} ");
            }
            stopCol--;
            // gán giá trị cho hàng cuối trong các hàng còn lại
            if (startRow < stopRow)
            {
                for (int i = stopCol - 1; i > startCol - 1; i--)
                {
                    Console.Write($"{arr[stopRow - 1, i]} ");
                }
                stopRow--;
            }
            // gán giá trị cho cột đầu trong số các cột còn lại
            if (startCol < stopCol)
            {
                for (int i = stopRow - 1; i > stopRow - 1; i--)
                {
                    Console.Write($"{arr[i, startCol]} ");
                }
                startCol++;
            }
            CreateSpiralMatrix(arr, startRow, stopRow, startCol, stopCol);
        }

        static void Main()
        {
            // ta nhập giá trị vào từ bàn phím.
            // Mỗi lần nhập tất cả các phần tử trên từng hàng một nhé
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc cả dòng có kích thước hai chiều của ma trận
                string[] sizes = Console.ReadLine().Split(' ');
                int row = int.Parse(sizes[0]); // tách lấy hàng(số thứ nhất)
                int col = int.Parse(sizes[1]); // tách lấy cột(số thứ hai)
                int[,] arr = new int[row, col]; // tạo mảng 2 chiều kích thước row x col
                for (int i = 0; i < row; i++) // đọc ra các phần tử của ma trận
                {
                    var line = Console.ReadLine(); // đọc cả dòng thứ i + 1
                    var numbers = line.Split(' '); // tách các phần tử tại vị trí có dấu cách
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        arr[i, j] = int.Parse(numbers[j]); // chuyển string sang số nguyên kiểu int
                    }
                }
                Console.WriteLine($"Test {test}:\n");
                // tạo và in ra ma trận xoắn ốc
                CreateSpiralMatrix(arr, 0, row, 0, col);
                Console.WriteLine(); // in xuống dòng
            }
        }
    }
}

