using System;

namespace ExercisesLesson41
{
    class Exercises19
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            DrawRect(n);
        }

        static void DrawRect(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1 || i == n || j == n
                        || i == j || i + j == n + 1)
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
