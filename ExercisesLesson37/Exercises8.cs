using System;

namespace ExercisesLesson37
{
    class Exercises8
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < 2 * h; j++)
                {
                    if (h - i + 1 <= j && j <= h + i - 1)
                    {
                        Console.Write($" {i - Math.Abs(h - j)} ");
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
