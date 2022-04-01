///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises3
    {
        // struct mô tả thông tin một điểm trong tọa độ 2 chiều
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

        struct Triangle
        {
            public Point edgeA;
            public Point edgeB;
            public Point edgeC;

            public Triangle(Point a, Point b, Point c)
            {
                edgeA = a;
                edgeB = b;
                edgeC = c;
            }

            public override string ToString()
            {
                return $"Rectangle[A{edgeA}, B{edgeB}, C{edgeC}]";
            }
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

        static Triangle GetTriangle()
        {
            Console.WriteLine("==== Toa do dinh A ====");
            Point a = GetPoint();
            Console.WriteLine("==== Toa do dinh B ====");
            Point b = GetPoint();
            Console.WriteLine("==== Toa do dinh C ====");
            Point c = GetPoint();
            return new Triangle(a, b, c);
        }

        static double Perimeter(Triangle triangle)
        {
            double ab = Distance(triangle.edgeA, triangle.edgeB);
            double bc = Distance(triangle.edgeB, triangle.edgeC);
            double ac = Distance(triangle.edgeA, triangle.edgeC);
            return ab + bc + ac;
        }

        static double Area(Triangle triangle)
        {
            double ab = Distance(triangle.edgeA, triangle.edgeB);
            double bc = Distance(triangle.edgeB, triangle.edgeC);
            double ac = Distance(triangle.edgeA, triangle.edgeC);
            double p = 0.5 * (ab + bc + ac);
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        static void Main()
        {
            var triangle = GetTriangle();
            Console.WriteLine("=======================");
            Console.WriteLine(triangle);
            Console.WriteLine("Chu vi: " + Perimeter(triangle));
            Console.WriteLine("Dien tich: " + Area(triangle));
        }
    }
}
