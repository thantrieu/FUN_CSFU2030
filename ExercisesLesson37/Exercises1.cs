using System;

namespace ExercisesLesson37
{
    class Exercises1
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                if(n < 6)
                {
                    Console.WriteLine($"Test {test}: NO");
                } else
                {
                    int sum = 1;
                    int bound = (int)Math.Sqrt(n);
                    for (int k = 2; k <= bound; k++) // tiến hành cộng tổng ước < n
                    {
                        if (n % k == 0)
                        {
                            if (n / k == k)
                            {
                                sum += k;
                            }
                            else
                            {
                                sum += k;
                                sum += n / k;
                            }
                        }
                    }
                    Console.WriteLine($"Test {test}: {(n == sum ? "YES" : "NO")}");
                }
            }
        }
    }
}
