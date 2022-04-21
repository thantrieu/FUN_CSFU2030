///<summary>
///<author>Branium Academy</author>
///<version>2022.04.20</version>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson101
{
    class Exercises4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] integers = new int[] { 1, 2, 3, 5, 8, 9, 7, 0, 4 };
            double[] gpas = new double[] { 2.3, 3.47, 1.75, 2.65, 3.78, 3.12, 3.54, 3.16 };
            Sort(gpas);
            Sort(integers);
            Console.WriteLine("Mảng số nguyên sau khi sắp xếp: ");
            ShowElements(integers);
            Console.WriteLine("Mảng số thực sau sắp xếp: ");
            ShowElements(gpas);
        }

        // phương thức sắp xếp tăng dần các phần tử trong mảng
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
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
