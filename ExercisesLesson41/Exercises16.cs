using System;

namespace ExercisesLesson41
{
    class Exercises16
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            DrawRect(m, n); // gọi phương thức để vẽ hình
        }

        static void DrawRect(int m, int n)
        {
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($" {j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
