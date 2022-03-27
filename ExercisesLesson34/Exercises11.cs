using System;

namespace ExercisesLesson34
{
    class Exercises11
    {
        static void Main()
        {
            const float PI = 3.14f;
            float radius = float.Parse(Console.ReadLine());
            var result = radius < 0 ? "ERROR" 
                : $"{2 * PI * radius} {PI * radius * radius}";
            Console.WriteLine(result);
        }
    }
}
