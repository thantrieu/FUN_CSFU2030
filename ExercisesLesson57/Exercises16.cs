/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>


using System;

namespace ExercisesLesson56
{
    class Exercises16
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var str1 = Console.ReadLine().Split(' ');
                var str2 = Console.ReadLine().Split(' ');
                Console.WriteLine($"Test {test}:");
                ShowResult(str1, str2);
            }
        }

        // phương thức hiển thị kết quả
        static void ShowResult(string[] str1, string[] str2)
        {
            // chọn danh sách ngắn hơn để duyệt cho lẹ
            var str = str1.Length < str2.Length ? str1 : str2;
            for (int i = 0; i < str.Length; i++)
            {
                if (Contains(str1, str[i]) && Contains(str2, str[i]))
                {
                    Console.Write($"{str[i]} ");
                }
            }
            Console.WriteLine();
        }

        static bool Contains(string[] arr, string x)
        {
            Func<bool> contains = () =>
            {
                foreach (var item in arr)
                {
                    if (item.ToLower().CompareTo(x.ToLower()) == 0)
                    {
                        return true;
                    }
                }
                return false;
            };
            return contains();
        }
    }
}
