using System;

namespace ExercisesLesson42
{
    class Exercises6
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen k khac 0: ");
            int k = int.Parse(Console.ReadLine());
            if(k != 0)
            {
                MaxX(n, k, out int x);
                MinY(n, k, out int y);
                ShowResult("Gia tri x", x);
                ShowResult("Gia tri y", y);
            } else
            {
                Console.WriteLine("Vui long nhap k != 0.");
            }
        }

        /// <summary>
        /// Phương thức hiển thị kết quả lên màn hình.
        /// </summary>
        /// <param name="msg">Thông điệp cần hiển thị.</param>
        /// <param name="result">Giá trị kết quả.</param>
        static void ShowResult(in string msg, in float result)
        {
            Console.WriteLine(msg + ": " + result);
        }

        /// <summary>
        /// Phương thức tìm giá trị lớn nhất nhỏ hơn n chia hết cho k.
        /// Trong đó k khác 0.
        /// </summary>
        /// <param name="n">Giá trị mốc.</param>
        /// <param name="k">Số chia, khác 0.</param>
        /// <param name="x">Giá trị cần tìm.</param>
        static void MaxX(int n, int k, out int x)
        {
            while(true)
            {
                n--;
                if(n % k == 0)
                {
                    break;
                }
            }
            x = n;
        }

        /// <summary>
        /// Phương thức tìm giá trị nhỏ nhất lớn hơn n chia hết cho k.
        /// </summary>
        /// <param name="n">Giá trị mốc.</param>
        /// <param name="k">Số chia khác 0.</param>
        /// <param name="y">Giá trị cần tìm.</param>
        static void MinY(int n, int k, out int y)
        {
            while (true)
            {
                n++;
                if (n % k == 0)
                {
                    break;
                }
            }
            y = n;
        }
    }
}
