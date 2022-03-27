using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLesson36
{
    class Exercises5
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
                int count = 0;
                while (n > 1)
                {
                    if (n % k == 0)
                    {
                        if (count == 0)
                        {
                            Console.Write(k);
                        }
                        count++;
                        n /= k; // giảm n đi k lần
                    }
                    else
                    {
                        k++;
                        if (count > 1)
                        {
                            Console.Write($"^{count}");
                        }
                        if (count >= 1)
                        {
                            count = 0;
                            Console.Write("x");
                        }
                    }
                }
                Console.WriteLine($"{(count > 0 ? "^" + count : "")}");
            }
        }
    }
}
