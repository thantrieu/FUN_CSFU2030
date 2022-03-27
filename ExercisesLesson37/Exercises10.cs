using System;

namespace ExercisesLesson37
{
    class Exercises10
    {
        static void Main()
        {
            int width = 7;
            int height = 6;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if ((i == 1 && j != 1 && j != 4 && j != 7) ||
                        i == 2 || i == 3 || (i == 4 && j != 1 && j != 7) ||
                        (i == 5 && 3 <= j && j <= 5) ||
                        (i == 6 && j == 4))
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
