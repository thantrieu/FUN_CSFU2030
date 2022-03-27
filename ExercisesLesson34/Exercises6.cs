using System;

namespace ExercisesLesson34
{
    class Exercises6
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            var result = (a == 0 && b == 0) ? "COUNTERLESS SOLUTION"
                : (a == 0 && b != 0) ? "NO SOLUTION"
                : $"{-b / a}";
            Console.WriteLine(result);
        }
    }
}
