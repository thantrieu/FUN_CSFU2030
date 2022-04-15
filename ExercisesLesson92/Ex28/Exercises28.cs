/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises28
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

        // phương thức trả về các từ không có chung trong cả hai mảng
        static string[] ComplementPart(string[] data1, string[] data2)
        {
            string[] result = new string[data1.Length + data2.Length];
            int index = 0;
            foreach (var item in data1)
            {
                if (!Contains(data2, item))
                {
                    result[index++] = item;
                }
            }
            foreach (var item in data2)
            {
                if (!Contains(data1, item))
                {
                    result[index++] = item;
                }
            }
            return result;
        }

        static void ShowElements(string[] result, StreamWriter writer)
        {
            foreach (var item in result)
            {
                writer.Write(item + " ");
            }
            writer.WriteLine();
        }

        static void Main()
        {
            var inputFileName = "input28.txt";
            var outputFileName = "output28.txt";
            FileInfo fileReader = new FileInfo(inputFileName);
            FileInfo fileWriter = new FileInfo(outputFileName);
            using (var stream = fileWriter.OpenWrite())
            {
                using (var writer = new StreamWriter(stream))
                {
                    using (var reader = fileReader.OpenText())
                    {
                        int t = int.Parse(reader.ReadLine());
                        for (int test = 1; test <= t; test++)
                        {
                            var str1 = reader.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            var str2 = reader.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            writer.WriteLine($"Test {test}:");
                            var result = ComplementPart(str1, str2);
                            ShowElements(result, writer);
                        }
                    }
                }
            }
        }
    }
}
