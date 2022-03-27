using System;

namespace ExercisesLesson36
{
    class Exercises9
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                float sum = 0;
                int i = 1;
                while (i <= n)
                {
                    sum += 1.0f / (i * i * i);
                    i++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
