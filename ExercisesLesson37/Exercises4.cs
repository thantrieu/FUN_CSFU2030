using System;

namespace ExercisesLesson37
{
    class Exercises4
    {
        static void Main()
        {
            var data = Console.ReadLine().Trim().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(i == 1 || j == 1 || i == m || j == n)
                    {
                        Console.Write(" * ");
                    } else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
