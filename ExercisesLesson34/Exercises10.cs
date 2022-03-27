using System;

namespace ExercisesLesson34
{
    class Exercises10
    {
        static void Main()
        {
            float mark = float.Parse(Console.ReadLine());
            string level = "";
            if (0.0 <= mark && mark <= 10.0)
            {
                level = (mark >= 9.0) ? "A"
                : (mark >= 7.0) ? "B"
                : (mark >= 5.0) ? "C"
                : (mark >= 4.0) ? "D"
                : "F";
            }
            Console.WriteLine(level);
        }
    }
}
