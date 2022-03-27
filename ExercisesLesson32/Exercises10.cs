using System;

namespace ExercisesLesson32
{
    class Exercises10
    {
        static void Main()
        {
            float mark = float.Parse(Console.ReadLine());
            string level = "";
            if (0.0 <= mark && mark <= 10.0)
            {
                if (mark >= 9.0)
                {
                    level = "A";
                }
                else if (mark >= 7.0)
                {
                    level = "B";
                }
                else if (mark >= 5.0)
                {
                    level = "C";
                }
                else if (mark >= 4.0)
                {
                    level = "D";
                }
                else
                {
                    level = "F";
                }
            }
            Console.WriteLine(level);
        }
    }
}
