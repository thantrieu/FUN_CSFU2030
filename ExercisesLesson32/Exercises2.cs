using System;

namespace ExercisesLesson32
{
    class Exercises2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("NEGATIVE");
            }
            else if (n == 0)
            {
                Console.WriteLine("UNSIGNED");
            } else
            {
                Console.WriteLine("POSITIVE");
            }
        }
    }
}
