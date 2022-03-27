using System;

namespace ExercisesLesson34
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
                var result = (b == 0 && c == 0) ? "COUNTERLESS SOLUTION"
                : (b == 0 && c != 0) ? "NO SOLUTION"
                : $"{-c / b}";
                Console.WriteLine(result);
            }
            else
            {
                var delta = b * b - 4 * a * c;
                var result = (delta < 0) ? "NO SOLUTION" 
                    : (delta == 0) ? $"{-b / (2 * a)}" 
                    : $"{(-b - Math.Sqrt(delta)) / (2 * a)} {(-b + Math.Sqrt(delta)) / (2 * a)}";
                Console.WriteLine(result);
            }
        }
    }
}
