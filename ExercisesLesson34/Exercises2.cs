using System;

namespace ExercisesLesson34
{
    class Exercises2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var result = n < 0 ? "NEGATIVE" : n == 0 ? "UNSIGNED" : "POSITIVE";
            Console.WriteLine(result);
        }
    }
}
