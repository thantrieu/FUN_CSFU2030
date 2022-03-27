using System;

namespace ExercisesLesson32
{
    class Exercises8
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            float c = float.Parse(data[2]);

            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
