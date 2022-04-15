/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises26
    {
        // phương thức kiểm tra xem liệu từ w có trong danh sách các từ không
        static bool Contains(string[] data, string x)
        {
            foreach (var item in data)
            {
                if (item.CompareTo(x) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var w = Console.ReadLine();
                Console.WriteLine($"Test {test}: {(Contains(str, w) ? "YES" : "NO")}");
            }
        }
    }
}
