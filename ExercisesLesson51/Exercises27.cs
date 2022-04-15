/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises27
    {
        // phương thức kiểm tra xem liệu từ w có trong danh sách các từ không
        static bool Contains(string[] data, string x)
        {
            foreach (var item in data)
            {
                if (item.ToLower().CompareTo(x.ToLower()) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // phương thức trả về các từ có chung trong cả hai mảng
        static string[] IntersectionPart(string[] data1, string[] data2)
        {
            string[] result = new string[data1.Length];
            int index = 0;
            foreach (var item in data1)
            {
                if(Contains(data2, item))
                {
                    result[index++] = item;
                }
            }
            return result;
        }

        static void ShowElements(string[] result)
        {
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var str1 = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var str2 = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"Test {test}:");
                var result = IntersectionPart(str1, str2);
                ShowElements(result);
            }
        }
    }
}
