using System;

namespace ExercisesLesson41
{
    class Exercises18
    {
        static void Main()
        {
            var data = Console.ReadLine().Trim().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            DrawRect(m, n); // gọi phương thức vẽ hình chữ nhật rỗng
        }

        static void DrawRect(int m, int n)
        {
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1 || i == m || j == n)
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
