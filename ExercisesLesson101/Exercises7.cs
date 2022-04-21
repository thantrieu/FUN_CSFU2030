///<summary>
///<author>Branium Academy</author>
///<version>2022.04.20</version>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson101
{
    class Exercises7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] integers = new int[] { 1, 2, 3, 5, 8, 9, 7, 0, 4 };
            double[] gpas = new double[] { 2.3, 3.47, 1.75, 2.65, 3.78, 3.12, 3.54, 3.16 };
            Console.WriteLine("Giá trị lớn nhất trong mảng integers: " + FindMax(integers));
            Console.WriteLine("Giá trị lớn nhất trong mảng gpas: " + FindMax(gpas));
        }

        // phương thức tìm phần tử lớn nhất trong mảng
        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
