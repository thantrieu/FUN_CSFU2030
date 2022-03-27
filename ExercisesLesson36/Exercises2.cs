using System;

namespace ExercisesLesson36
{
    class Exercises2
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
                int sum = 0;
                while (n > 0)
                {
                    int k = n % 10;
                    n /= 10;
                    sum += k * k;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
