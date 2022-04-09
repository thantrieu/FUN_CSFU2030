///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.09</version>
///</summary>

using System;
using System.Text;

namespace CustomExtension
{
    public static class Extensions
    {
        // phương thức mở rộng dùng để đếm từ có trong chuỗi str
        public static int CountWord(this string str)
        {
            var spliter = new char[] { ' ', ',', '\t', '\n', '.', '?', '!', ':', ';' };
            var data = str.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
            return data.Length;
        }

        // phương thức mở rộng để tách các từ tại vị trí các dấu câu và trả về kết quả
        public static string[] SplitWord(this string str)
        {
            var spliter = new char[] { ' ', ',', '\t', '\n', '.', '?', '!', ':', ';' };
            var data = str.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
            return data;
        }

        // phương thức viết hoa chữ cái đầu các từ của các từ trong câu
        public static string MyCapitalize(this string str)
        {
            var words = str.Split(new char[] { ' ', '.', '!', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == null)
                {
                    break;
                }
                var characters = words[i].ToCharArray();
                characters[0] = (characters[0] >= 'a' && characters[0] < 'z')
                    ? (char)(characters[0] - 32) : characters[0];
                words[i] = new string(characters);
            }
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                builder.Append(word + " ");
            }
            return builder.ToString();
        }
        // phương thức sắp xếp các từ theo thứ tự A-Z
        public static string SortASC(this string str)
        {
            var words = str.Split(new char[] { ' ', '.', '!', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                builder.Append(word + " ");
            }
            return builder.ToString();
        }
        // phương thức  sắp xếp các từ trong danh sách theo độ dài từ
        public static string SortByWordLength(this string str)
        {
            var words = str.Split(new char[] { ' ', '.', '!', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, (s1, s2) => s1.Length - s2.Length);
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                builder.Append(word + " ");
            }
            return builder.ToString();
        }
        // phương thức tìm các từ bắt đầu bởi kí tự k nào đó
        public static string[] FindWordStartWith(this string str, char k)
        {
            var words = str.Split(new char[] { ' ', '.', '!', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var result = new string[words.Length];
            int index = 0;
            foreach (var item in words)
            {
                if (item.StartsWith(k + ""))
                {
                    result[index++] = item;
                }
            }
            return result;
        }
        // phương thức tìm và trả về từ dài nhất trong câu
        public static string FindLongestWord(this string str)
        {
            var words = str.Split(new char[] { ' ', '.', '!', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var result = "";
            int maxLength = 0;
            foreach (var item in words)
            {
                if (item.Length > maxLength)
                {
                    maxLength = item.Length;
                    result = item;
                }
            }
            return result;
        }
        // phương thức tìm và trả về từ ngắn nhất trong câu
        public static string FindShortestWord(this string str)
        {
            var words = str.Split(new char[] { ' ', '.', '!', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var result = words[0];
            int minLength = result.Length;
            foreach (var item in words)
            {
                if (item.Length < minLength)
                {
                    minLength = item.Length;
                    result = item;
                }
            }
            return result;
        }
        // phương thức đảo ngược các từ trong câu cho trước

        // phương thức chuyển đổi số nguyên n sang chuỗi nhị phân

        // phương thức chuyển đổi số nguyên n sang chuỗi kí tự ở hệ 16

        // phương thức chuyển đổi chuỗi nhị phân sang số ở hệ 10

        // phương thức chuyển đổi chuỗi kí tự ở hệ 16 sang số ở hệ 10

    }
}

namespace ExercisesLesson614
{
    using CustomExtension;
    class Exercises1
    {
        static void Main()
        {
            var input = "Welcome to Branium Academy! We're learning C#.";
            // 1
            var words = input.SplitWord();
            ShowElements(words);

            Console.WriteLine("=============================================");
            // 2
            var numOfWord = input.CountWord();
            Console.WriteLine($"So tu co trong xau input: {numOfWord}");

            Console.WriteLine("=============================================");
            // 3
            var capitalString = input.MyCapitalize();
            Console.WriteLine($"Chuoi ki tu sau khi viet hoa: \n{capitalString}");

            Console.WriteLine("=============================================");
            // 4
            Console.WriteLine($"Chuoi sau khi sap xep: \n{input.SortASC()}");

            Console.WriteLine("=============================================");
            // 5
            Console.WriteLine($"Chuoi sau khi sap xep tang dan theo do dai tu: \n" +
                $"{input.SortByWordLength()}");

            Console.WriteLine("=============================================");
            // 6
            Console.WriteLine("Nhap ki tu bat dau cua tu: ");
            char key = char.Parse(Console.ReadLine());
            Console.WriteLine("Danh sach cac tu bat dau voi ki tu '" + key + "'");
            var resultStartByKey = input.FindWordStartWith(key);
            ShowElements(resultStartByKey);
            Console.WriteLine("=============================================");
            // 7
            Console.WriteLine($"Tu dai nhat trong cau: {input.FindLongestWord()}");
            Console.WriteLine("=============================================");
            // 8
            Console.WriteLine($"Tu ngan nhat trong cau: {input.FindShortestWord()}");
        }

        static void ShowElements(string[] data)
        {
            int index = 1;
            foreach (var word in data)
            {
                if(word != null)
                {
                    Console.WriteLine($"{index++}: {word}");
                }
            }
        }
    }
}
