using System;

namespace ExercisesLesson32
{
    class Exercises6
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            if (a == 0 && b == 0)
            {
                Console.WriteLine("COUNTERLESS SOLUTION");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("NO SOLUTION");
            }
            else
            {
                Console.WriteLine(-b / a);
            }
        }
    }
}
