using System;

namespace ExercisesLesson34
{
    internal class Exercises12
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            var result = a < 0 || b < 0 ? "INVALID INPUT"
                : $"{2 * (a + b)} {a * b}";
            Console.WriteLine(result);
        }
    }
}
