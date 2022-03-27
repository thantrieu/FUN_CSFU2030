using System;

namespace ExercisesLesson32
{
    class Exercises3
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            if (a == b)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                var diff  = Math.Abs(a - b);
                Console.WriteLine($"DIFFERENT {diff}");
            }
        }
    }
}
