using System;

namespace ExercisesLesson34
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = n % 2 == 0 ? "EVEN" : "ODD";
            Console.WriteLine(result);
        }
    }
}
