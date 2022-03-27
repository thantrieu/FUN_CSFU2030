using System;

namespace ExercisesLesson41
{
    class Exercises25
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            DrawEnvelope(n);
        }

        /// <summary>
        /// Phương thức vẽ hình phong bì.
        /// </summary>
        /// <param name="n">Độ dài cạnh.</param>
        static void DrawEnvelope(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n ||
                        ((i == j) && i <= (int)Math.Round(n / 2.0)) ||
                        (i + j == n + 1 && i <= (int)Math.Round(n / 2.0)))
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
