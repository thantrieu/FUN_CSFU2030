using System;

namespace ExercisesLesson36
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                int prod = a * b;
                // tìm ước chung
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                Console.WriteLine($"{a} {prod / a}");
            }
        }
    }
}
