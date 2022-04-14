/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises15
    {
        // phương thức đếm số lần xuất hiện của x trong mảng
        static int CountX(int[] arr, int x)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == x)
                {
                    counter++;
                }
            }
            return counter;
        }

        // phương thức kiểm tra xem phần tử giá trị x đã tồn tại trước vị trí pos chưa
        static bool IsExisted(int[] arr, int x, int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                if (arr[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(int[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!IsExisted(arr, arr[i], i))
                {
                    writer.WriteLine(arr[i] + ": " + CountX(arr, arr[i]));
                }
            }
        }

        static void Main()
        {
            var inputFileName = "input15.txt";
            var outputFileName = "output15.txt";
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
                            var elements = reader.ReadLine().Split(' ');
                            var n = elements.Length;
                            int[] arr = new int[n];
                            for (int i = 0; i < n; i++)
                            {
                                arr[i] = int.Parse(elements[i]);
                            }
                            writer.WriteLine($"Test {test}:");
                            ShowElements(arr, writer);
                        }
                    }
                }
            }
        }
    }
}
