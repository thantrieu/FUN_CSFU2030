/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson51
{
    class Exercises20
    {
        // phương thức trộn hai mảng str1 và str2 thành str
        static string[] Insert(string[] arr, string str, int k)
        {
            string[] result = new string[arr.Length + 1];
            if(k <= 0) // chèn đầu mảng kết quả
            {
                result[0] = str;
                for (int i = 0; i < arr.Length; i++)
                {
                    result[i + 1] = arr[i];
                }
            } else if(k >= arr.Length) // chèn cuối mảng kết quả
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    result[i] = arr[i];
                }
                result[arr.Length] = str;
            }
            else // chèn vị trí khác đầu, cuối
            {
                // sao chép các phần tử trước vị trí k
                for (int i = 0; i < k; i++)
                {
                    result[i] = arr[i];
                }
                result[k] = str; // gán giá trị cho phần tử tại vị trí k
                // sao chép các phần tử từ vị trí k tới hết mảng gốc
                for (int i = k; i < arr.Length; i++)
                {
                    result[i + 1] = arr[i];
                }
            }
            return result;
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                // đọc vào số n, x và n phần tử mảng
                var str = Console.ReadLine().Split(' ');
                var data = Console.ReadLine().Split(' ');
                var w = data[0];
                var k = int.Parse(data[1]);
                var result = Insert(str, w, k);
                Console.WriteLine($"Test {test}:");
                ShowElements(result);
            }
        }
    }
}
