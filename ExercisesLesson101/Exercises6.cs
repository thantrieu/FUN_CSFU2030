///<summary>
///<author>Branium Academy</author>
///<version>2022.04.20</version>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson101
{
    class Exercises6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] integers = new int[] { 1, 2, 3, 5, 8, 9, 7, 0, 4 };
            double[] gpas = new double[] { 2.3, 3.47, 1.75, 2.65, 3.78, 3.12, 3.54, 3.16 };
            // hiển thị các phần tử mảng ra màn hình
            Console.WriteLine("Các phần tử của mảng số nguyên: ");
            ShowElements(integers);
            Console.WriteLine("Các phần tử của mảng số thực: ");
            ShowElements(gpas);
        }

        // phương thức hiển thị các phần tử trong mảng bất kì
        public static void ShowElements<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
