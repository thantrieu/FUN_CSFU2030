/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.29
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises11
    {
        /* 
            B1: khởi tạo các biến row_start-chỉ số hàng đầu, row_end-chỉ số hàng cuối,
            col_start-cột đầu, col_end-cột cuối.
            B2: Lặp chừng nào tất cả các cạnh cấu thành ma trận xoắn ốc được duyệt:
            B2.1: in ra hàng đầu tiên trong vùng đang xét của ma trận, tăng row_start lên 1.
            B2.2: in ra cột cuối cùng trong vùng đang xét của ma trận, giảm col_end đi 1.
            B2.3: in ra hàng cuối cùng trong vùng đang xét của ma trận, giảm row_end đi 1.
            B2.4: in ra cột đầu tiên trong vùng đang xét của ma trận, tăng col_start lên 1.
         */
        static void CreateSpiralMatrix(int[,] arr, int rowStart, int rowEnd, int colStart, int colEnd, ref int counter)
        {
            if (rowStart >= rowEnd || colStart >= colEnd)
            {
                return;
            }
            // gán giá trị cho hàng đầu trong số các hàng còn lại
            for (int i = colStart; i < colEnd; i++)
            {
                arr[rowStart, i] = counter;
                counter++;
            }
            rowStart++; // chuyển đến hàng kế tiếp ở lần duyệt tới
            // # gán giá trị cho cột cuối trong số các cột còn lại
            for (int i = rowStart; i < rowEnd; i++)
            {
                arr[i, colEnd - 1] = counter;
                counter++;
            }
            colEnd--; // chuyển tới cột liền trước ở lần duyệt tới
            // gán giá trị cho hàng cuối trong các hàng còn lại
            if (rowStart < rowEnd)
            {
                for (int i = colEnd - 1; i > colStart - 1; i--)
                {
                    arr[rowEnd - 1, i] = counter;
                    counter += 1;
                }
                rowEnd--;  // chuyển tới hàng liền trước ở lần duyệt tới
            }
            // gán giá trị cho cột đầu trong số các cột còn lại
            if (colStart < colEnd)
            {
                for (int i = rowEnd - 1; i > rowStart - 1; i--)
                {
                    arr[i, colStart] = counter;
                    counter += 1;
                }
                colStart += 1; // chuyển đến cột kế tiếp ở lần duyệt tới
            }
            CreateSpiralMatrix(arr, rowStart, rowEnd, colStart, colEnd, ref counter);
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var data = Console.ReadLine().Split(' ');
                int row = int.Parse(data[0]);
                int col = int.Parse(data[1]);
                int[,] arr = new int[row, col];
                var value = 1;
                var startRow = 0;
                var startCol = 0;
                // tạo ma trận xoắn ốc
                CreateSpiralMatrix(arr, startRow, row, startCol, col, ref value);
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
