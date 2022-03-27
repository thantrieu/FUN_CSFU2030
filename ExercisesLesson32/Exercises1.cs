using System;

namespace ExercisesLesson32
{
    internal class Exercises1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine("EVEN");
            } else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}
