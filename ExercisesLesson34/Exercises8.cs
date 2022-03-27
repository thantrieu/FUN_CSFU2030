using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLesson34
{
    class Exercises8
    {
        static void Main()
        {
            var data = Console.ReadLine().Split(' ');
            float a = float.Parse(data[0]);
            float b = float.Parse(data[1]);
            float c = float.Parse(data[2]);

            var result = (a + b > c && b + c > a && c + a > b) ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}
