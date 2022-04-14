/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises11
    {
        // phương thức kiểm tra tính đối xứng của mảng
        static bool IsSymmetry(int[] arr)
        {
            int mid = arr.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            var inputFileName = "input11.txt";
            var outputFileName = "output11.txt";
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
                            int n = int.Parse(reader.ReadLine());
                            var elements = reader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                int[] arr = new int[n];
                                for (int i = 0; i < n; i++)
                                {
                                    arr[i] = int.Parse(elements[i]);
                                }
                                writer.WriteLine($"Test {test}:\n{(IsSymmetry(arr) ? "YES" : "NO")}");
                            }
                            else
                            {
                                writer.WriteLine($"Test {test}:\nN INVALID");
                            }
                        }
                    }
                }
            }
        }
    }
}
