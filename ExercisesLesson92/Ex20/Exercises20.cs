/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.15
/// </summary>

using System.IO;

namespace ExercisesLesson92
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
        static void ShowElements(string[] arr, StreamWriter writer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                writer.Write(arr[i] + " ");
            }
            writer.WriteLine();
        }

        static void Main()
        {
            var inputFileName = "input20.txt";
            var outputFileName = "output20.txt";
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
                            var str = reader.ReadLine().Split(' ');
                            var data = reader.ReadLine().Split(' ');
                            var w = data[0];
                            var k = int.Parse(data[1]);
                            var result = Insert(str, w, k);
                            writer.WriteLine($"Test {test}:");
                            ShowElements(result, writer);
                        }
                    }
                }
            }
            
        }
    }
}
