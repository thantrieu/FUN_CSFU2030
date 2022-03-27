using System;

namespace ExercisesLesson41
{
    class Exercises10
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                if(n < 0)
                {
                    Console.WriteLine($"Test {test}: \nINVALID");
                } else
                {
                    Console.WriteLine($"Test {test}: \n{SumDigits(n)}");
                }
            }
        }

        static int SumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
