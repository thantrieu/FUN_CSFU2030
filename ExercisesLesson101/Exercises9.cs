///<summary>
///<author>Branium Academy</author>
///<version>2022.04.20</version>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson101
{
    class Exercises9
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] integers = new int[] { 1, 2, 3, 5, 8, 9, 7, 0, 4 };
            double[] gpas = new double[] { 2.3, 3.47, 1.75, 2.65, 3.78, 3.12, 3.54, 3.16 };
            Console.WriteLine("Giá trị nhỏ nhất trong mảng integers: " + FindMin(integers));
            Console.WriteLine("Giá trị nhỏ thứ hai trong mảng integers: " + FindSecondMin(integers));
            Console.WriteLine("Giá trị nhỏ nhất trong mảng gpas: " + FindMin(gpas));
            Console.WriteLine("Giá trị nhỏ thứ hai trong mảng gpas: " + FindSecondMin(gpas));
        }

        // phương thức tìm phần tử nhỏ nhất trong mảng
        public static T FindMin<T>(T[] arr) where T : IComparable<T>
        {
            T min = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        // phương thức tìm phần tử nhỏ thứ hai trong mảng
        public static T FindSecondMin<T>(T[] arr) where T : IComparable<T>
        {
            T min = FindMin<T>(arr);
            T min2 = min; // khởi tạo min2 = min
            // tìm giá trị đầu tiên khác min, gán cho min2
            foreach (var item in arr)
            {
                if (item.CompareTo(min) != 0)
                {
                    min2 = item;
                    break;
                }
            }
            // tìm giá trị min2
            foreach (var item in arr)
            {
                // giá trị cần tìm phải khác min, nhỏ hơn min2
                if (item.CompareTo(min) != 0 && item.CompareTo(min2) < 0)
                {
                    min2 = item;
                }
            }
            return min2;
        }
    }
}
