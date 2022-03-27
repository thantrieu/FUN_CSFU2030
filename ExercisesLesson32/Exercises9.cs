using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLesson32
{
    class Exercises9
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            float c = float.Parse(data[2]);

            if ((a * a + b * b) == c * c || (a * a + c * c) == b * b || 
                a * a == (b * b + c * c))
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
