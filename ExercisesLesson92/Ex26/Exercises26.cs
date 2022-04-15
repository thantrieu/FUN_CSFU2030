/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.15
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
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
            var inputFileName = "input26.txt";
            var outputFileName = "output26.txt";
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
                            var str = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            var w = reader.ReadLine();
                            writer.WriteLine($"Test {test}: \n{(Contains(str, w) ? "YES" : "NO")}");
                        }
                    }
                }
            }
        }
    }
}
