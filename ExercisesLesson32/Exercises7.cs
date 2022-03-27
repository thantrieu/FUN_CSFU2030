using System;

namespace ExercisesLesson32
{
    class Exercises7
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            float c = float.Parse(data[2]);
            if (a == 0)
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("COUNTERLESS SOLUTION");
                }
                else if (b == 0 && c != 0)
                {
                    Console.WriteLine("NO SOLUTION");
                }
                else
                {
                    Console.WriteLine(-c / b);
                }
            }
            else
            {
                var delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("NO SOLUTION");
                }
                else if (delta == 0)
                {
                    Console.WriteLine(-b / (2 * a));
                }
                else
                {
                    Console.Write((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine(" " + (-b + Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
    }
}
