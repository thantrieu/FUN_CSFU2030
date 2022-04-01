/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.01
/// </summary>

using System;

namespace ExercisesLesson57
{
    class Exercises6
    {
        static void Main()
        {
            // nhập dữ liệu đầu vào
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                var arr = Console.ReadLine().ToCharArray();
                Console.WriteLine($"Test {test}: ");
                ShowElements(arr);

            }
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(char[] arr)
        {
            // câu lệnh lambda đếm số lần xuất hiện của kí tự x trong mảng char
            Func<char[], char, int> countX = (data, x) =>
            {
                int count = 0;
                foreach (var item in data)
                {
                    if (item == x)
                    {
                        count++;
                    }
                }
                return count;
            };
            // câu lệnh lambda kiểm tra xem kí tự x đã tồn tại trước vị trí pos chưa
            Func<char[], char, int, bool> existedX = (data, x, pos) =>
            {
                for (int i = 0; i < pos; i++)
                {
                    if (arr[i] == x)
                    {
                        return true;
                    }
                }
                return false;
            };

            for (int i = 0; i < arr.Length; i++)
            {
                if (!existedX(arr, arr[i], i))
                {
                    Console.WriteLine($"'{arr[i]}' {countX(arr, arr[i])}");
                }
            }
        }
    }
}
