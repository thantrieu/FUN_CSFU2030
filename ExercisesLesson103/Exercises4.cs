///<summary>
///<author>Branium Academy</author>
///<seealso cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.06.08</version>
///</summary>

using System;
using System.Text;

namespace ExercisesLesson103
{
    internal class Exercises4
    {
        public delegate T AddElementsDelegate<T>(T[] data);

        static string ConcatStrings(string[] words)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                builder.Append(words[i]);
            }
            return builder.ToString();
        }

        static double SumDoubleElements(double[] arr)
        {
            double sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static long SumLongElements(long[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var longElements = new long[] { 100, 500, 300, 700, 900, 500};
            var doubleElements = new double[] { 5.23, 3.24, 1.57, 9.64, 5.58, 4.39};
            var strings = new string[] { "xin", "chao", "cac", "ban", "nha" };
            AddElementsDelegate<double> doubleDelegate = SumDoubleElements;
            AddElementsDelegate<string> stringDelegate = ConcatStrings;
            AddElementsDelegate<long> longDelegate = SumLongElements;

            Console.WriteLine($"Tổng các số nguyên long: {longDelegate(longElements)}");
            Console.WriteLine($"Tổng các số thực double: {doubleDelegate(doubleElements)}");
            Console.WriteLine($"Các từ sau khi nối: {stringDelegate(strings)}");
        }
    }
}
