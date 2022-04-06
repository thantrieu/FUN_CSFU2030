///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.06</version>
///</summary>

using System;

namespace ExercisesLesson61
{
    /// <summary>
    /// Lớp mô tả thông tin và hành động của một ma trận.
    /// </summary>
    class Matrix
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int[,] data;

        public Matrix(int row, int col)
        {
            Row = row;
            Column = col;
            data = new int[row, col];
        }
        // phương thức nhập dữ liệu đầu vào
        public void GetData()
        {
            Console.WriteLine($"So hang x so cot: {Row} x {Column}");
            for (int i = 0; i < Row; i++)
            {
                Console.WriteLine("Cac phan tu hang " + i + ": ");
                var elements = Console.ReadLine().Split(' ');
                for (int j = 0; j < Column; j++)
                {
                    data[i, j] = int.Parse(elements[j]);
                }
            }
        }
        // phương thức hiển thị các phần tử của ma trận
        public void ShowElements()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // phương thức cộng hai ma trận cùng cấp
        public Matrix Add(Matrix other)
        {
            if (other == null || other.Row != this.Row || other.Column != this.Column)
            {
                return null; // nếu ma trận cần nhân là null hoặc không cùng cấp, trả về null
            }
            Matrix result = new Matrix(Row, Column);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    result.data[i, j] = data[i, j] + other.data[i, j];
                }
            }
            return result;
        }
        // phương thức nhân hai ma trận khả tích
        public Matrix Mul(Matrix other)
        {
            if (Column != other.Row)
            {
                return null;
            }
            Matrix result = new Matrix(Row, other.Column);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < other.Column; j++)
                {
                    for (int k = 0; k < Column; k++)
                    {
                        result.data[i, j] += data[i, k] * other.data[k, j];
                    }
                }
            }
            return result;
        }
    }

    class Exercises2
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix(3, 4);
            Matrix matrix2 = new Matrix(3, 4);
            Matrix matrix3 = new Matrix(4, 3);
            matrix1.GetData();
            Console.WriteLine("================");
            matrix2.GetData();
            Console.WriteLine("================");
            matrix3.GetData();
            Console.WriteLine("================");
            var sum = matrix1.Add(matrix2);
            Console.WriteLine("==> Ma tran A: ");
            matrix1.ShowElements();
            Console.WriteLine("==> Ma tran B: ");
            matrix2.ShowElements();
            Console.WriteLine("==> Ma tran C: ");
            matrix3.ShowElements();
            Console.WriteLine("=> Ma tran tong A + B: ");
            sum.ShowElements();
            var product = matrix1.Mul(matrix3);
            Console.WriteLine("Ma tran tich A x C: ");
            product.ShowElements();
        }
    }
}
