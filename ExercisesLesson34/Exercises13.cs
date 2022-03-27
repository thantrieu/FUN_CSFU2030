using System;

namespace ExercisesLesson34
{
    class Exercises13
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float h = float.Parse(data[1]);
            var result = a < 0 || h < 0 ? "INVALID INPUT"
                : $"{0.5 * a * h}";
            Console.WriteLine(result);
        }
    }
}
