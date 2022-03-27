using System;

namespace ExercisesLesson41
{
    class Exercises21
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            DrawTriangle(h);
        }

        static void DrawTriangle(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < 2 * h; j++)
                {
                    if (h - i + 1 <= j && j <= h + i - 1)
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
