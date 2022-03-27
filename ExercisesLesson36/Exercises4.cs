using System;

namespace ExercisesLesson36
{
    class Exercises4
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                int k = 2;
                while (n > 1)
                {
                    if (n % k == 0)
                    {
                        Console.Write(k + (n != k ? "x" : ""));
                        n /= k; // giảm n đi k lần
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
