/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.15
/// </summary>

using System;
using System.IO;

namespace ExercisesLesson92
{
    class Exercises25
    {
        static void Main()
        {
            var inputFileName = "input25.txt";
            var outputFileName = "output25.txt";
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
                            writer.WriteLine($"Test {test}: \n{str.Length}");
                        }
                    }
                }
            }
            
        }
    }
}
