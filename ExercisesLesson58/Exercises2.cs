///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises2
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

        // struct mô tả hình chữ nhật
        struct Rectangle
        {
            public Point center; // tâm
            public double width; // rộng
            public double height; // cao

            public Rectangle(Point center, double width, double height)
            {
                this.center = center;
                this.width = width;
                this.height = height;
            }

            public override string ToString()
            {
                return $"Rectangle[Center={center}, Width={width}, Height={height}]";
            }
        }

        // phương thức nhập dữ liệu đầu vào
        static Rectangle GetRectangleInfo()
        {
            int x, y;
            Console.WriteLine("Toa do x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Toa do y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Chieu rong: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Chieu cao: ");
            int height = int.Parse(Console.ReadLine());
            return new Rectangle(new Point(x, y), width, height);
        }

        // tính chu vi hình chữ nhật
        static double Perimeter(Rectangle rect)
        {
            return 2 * (rect.width + rect.height);
        }

        // tính diện tích hình chữ nhật
        static double Area(Rectangle rect)
        {
            return rect.width * rect.height;
        }

        static void Main()
        {
            var rect = GetRectangleInfo();
            Console.WriteLine("=============================");
            Console.WriteLine(rect);
            Console.WriteLine("Chu vi: " + Perimeter(rect));
            Console.WriteLine("Dien tich: " + Area(rect));
        }
    }
}
