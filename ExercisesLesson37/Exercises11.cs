using System;

namespace ExercisesLesson37
{
    class Exercises11
    {
        static void Main()
        {
            // ta sẽ vẽ các đường viền tại vị trí 2 cạnh là 1 hoặc n và nửa trên của hai đường chéo.
            // nếu n lẻ thì ta làm tròn n/2 lên số nguyên gần nhất để lấy mũi phong bì
            // nếu n chẵn thì ta không vẽ mũi phong bì mà để nó dạng tù, không nhọn.

            int n = int.Parse(Console.ReadLine());
            int middle = (int)Math.Round(n / 2.0);
            if (n % 2 != 0)
            {
                // n lẻ -> làm tròn lên 1 nửa của n để lấy giá trị tròn số. ví dụ n = 11 -> vẽ đến hàng số 6 từ trên xuống
                middle = (int)Math.Round((n + 1) / 2.0);
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n ||
                        ((i == j) && i <= middle) ||
                        (i + j == n + 1 && i <= middle)
                    )
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
