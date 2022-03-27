using System;

namespace ExercisesLesson36
{
    class Exercises6
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("NO");
            }
            else
            {
                bool isPrime = true;
                int bound = (int)Math.Sqrt(n);
                int index = 2;
                while (index <= bound) // nếu n có ước khác 1 và n thì n không nguyên tố
                {
                    if(n % index == 0)
                    {
                        isPrime = false;
                    }
                    index++;
                }
                Console.WriteLine(isPrime ? "YES" : "NO");
            }
        }
    }
}
