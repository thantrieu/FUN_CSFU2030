using System;

namespace ExercisesLesson36
{
    class Exercises8
    {
        static void Main()
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
                Console.WriteLine(a == 1 ? "YES" : "NO");
            }
        }
    }
}
