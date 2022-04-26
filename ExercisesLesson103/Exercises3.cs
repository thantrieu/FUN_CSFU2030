///<summary>
///<author>Branium Academy</author>
///<seealso cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.04.26</version>
///</summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesLesson103
{
    class Exercises3
    {
        // delegate tìm kiếm giá trị min hoặc max trong list kiểu T
        delegate T FindMinMax<T>(List<T> list) where T : IComparable<T>;

        // phương thức generic tìm giá trị min trong danh sách kiểu T
        static T FindMinValue<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("List truyền vào rỗng");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        static void ShowResult<T>(List<T> data, FindMinMax<T> del) where T : IComparable<T>
        {
            var result = del.Invoke(data);
            Console.WriteLine("Giá trị nhỏ nhất tìm được: " + result);
        }

        static void Main()
        {
            // cho phép hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // mảng các số nguyên
            int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7, 20, 35, 68, 100, 10, 17, 29, 9 };
            var listOfAge = new List<int>(ages);
            // mảng các số thực
            double[] gpas = new double[] { 1.58, 3.65, 2.54, 3.17, 3.12, 3.28, 3.98, 3.51, 2.39, 3.48 };
            var listOfGpa = new List<double>(gpas);
            FindMinMax<int> findMinValueOfInt = FindMinValue;
            FindMinMax<double> findMinValueOfDouble = FindMinValue;
            Console.WriteLine("==> Xét danh sách các phần tử kiểu int: ");
            ShowResult(listOfAge, findMinValueOfInt);
            Console.WriteLine("==> Xét danh sách các phần tử kiểu double: ");
            ShowResult(listOfGpa, findMinValueOfDouble);
        }
    }
}
