using System;

namespace ExercisesLesson41
{
    class Exercises32
    {
        static void Main()
        {
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine($"So nguyen nho hon {x}: {IntegerNumberLessThanX(x)}");
            Console.WriteLine($"So nguyen lon hon {x}: {IntegerNumberGreaterThanX(x)}");
            Console.WriteLine($"Gia tri tuyet doi cua {x}: {Abs(x)}");
        }

        /// <summary>
        /// Phương thức làm tròn xuống số nguyên gần nhất.
        /// </summary>
        /// <param name="x">Số thực cần làm tròn.</param>
        /// <returns>Số nguyên gần nhất nhỏ hơn x.</returns>
        static int IntegerNumberLessThanX(float x)
        {
            return (int)Math.Floor(x);
        }

        /// <summary>
        /// Phương thức làm tròn lên số nguyên gần nhất.
        /// </summary>
        /// <param name="x">Giá trị mốc.</param>
        /// <returns>Số nguyên nhỏ nhất lớn hơn x.</returns>
        static int IntegerNumberGreaterThanX(float x)
        {
            return (int)Math.Ceiling(x);
        }

        /// <summary>
        /// Phương thức lấy giá trị tuyệt đối của một số thực.
        /// </summary>
        /// <param name="x">Số cần lấy giá trị tuyệt đối.</param>
        /// <returns>Trị tuyệt đối của x.</returns>
        static float Abs(float x)
        {
            return x < 0 ? -x : x;
        }
    }
}
