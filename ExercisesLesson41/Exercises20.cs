using System;

namespace ExercisesLesson41
{
    class Exercises20
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
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
