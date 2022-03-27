using System;

namespace ExercisesLesson36
{
    class Exercises7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if(n < 0)
            {
                Console.WriteLine("INVALID");
            } else if(n > 27)
            {
                Console.WriteLine("OVERFLOW");
            }
            else
            {
                decimal factorial = 1;
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
        }
    }
    // 403291461126605635584000000
    // 10888869450418352160768000000
}
