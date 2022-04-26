///<summary>
///<author>Branium Academy</author>
///<seealso cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.04.26</version>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson103
{
    class Exercises2
    {
        // khai báo delegate tìm giá trị lớn nhất trong mảng các số nguyên
        delegate T FindMaxDelegate<T>(T[] arr) where T : IComparable<T>;

        // tìm số nguyên lớn nhất trong mảng
        static int MaxInArrayOfInt(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Mảng truyền vào rỗng");
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // tìm số thực lớn nhất trong mảng
        static double MaxInArrayOfDouble(double[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Mảng truyền vào rỗng");
            }
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // tìm từ đứng cuối bảng chữ cái
        static string MaxWord(string[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Mảng truyền vào rỗng");
            }
            string word = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(word) > 0)
                {
                    word = arr[i];
                }
            }
            return word;
        }

        static void Main()
        {
            // cho phép hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // khai báo các biến delegate
            FindMaxDelegate<int> findMaxInt = MaxInArrayOfInt;
            FindMaxDelegate<double> findMaxDouble = MaxInArrayOfDouble;
            FindMaxDelegate<string> findMaxString = MaxWord;

            // mảng các số nguyên
            int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7, 20, 35, 68, 100, 10, 17, 29, 9 };
            Console.WriteLine($"Giá trị lớn nhất trong mảng các số nguyên: {findMaxInt(ages)}");

            // mảng các số thực
            double[] gpas = new double[] { 1.58, 3.65, 2.54, 3.17, 3.12, 3.28, 3.98, 3.51, 2.39, 3.48 };
            Console.WriteLine($"Giá trị lớn nhất trong các đầu điểm: {findMaxDouble(gpas)}");

            // mảng các từ nhập vào từ bàn phím
            Console.WriteLine("Nhập các từ cách nhau bởi dấu cách: ");
            var words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Từ đứng cuối bảng chữ cái trong câu: {findMaxString(words)}");
        }
    }
}
