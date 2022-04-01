///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises1
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"({x}, {y})";
            }
        }

        static void Main()
        {
            Console.WriteLine("Toa do diem A: ");
            Point p1 = GetPoint();
            Console.WriteLine("Toa do diem B: ");
            Point p2 = GetPoint();
            var distance = Distance(p1, p2);
            Console.WriteLine($"Khoang cach giua hai diem {p1}, {p2}: {distance:f2}");
        }

        static double Distance(Point a, Point b)
        {
            return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
        }

        static Point GetPoint()
        {
            Point p = new Point();
            Console.WriteLine("Toa do x: ");
            p.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Toa do y: ");
            p.y = int.Parse(Console.ReadLine());
            return p;
        }
    }
}
