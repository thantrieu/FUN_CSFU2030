using System;

namespace ExercisesLesson34
{
    class Exercises3
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            var result = (a == b) ? "EQUAL" : $"DIFFERENT {Math.Abs(a - b)}";
            Console.WriteLine(result);
        }
    }
}
