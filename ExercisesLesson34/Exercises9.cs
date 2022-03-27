using System;

namespace ExercisesLesson34
{
    class Exercises9
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            float c = float.Parse(data[2]);

            var result = ((a * a + b * b) == c * c ||
                (a * a + c * c) == b * b ||
                a * a == (b * b + c * c)) ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}
