using System;
using System.Collections.Generic;

namespace ExercisesLesson101
{
    internal class Exercises10
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("==> Nhập vào xâu kí tự: ");
            var str = Console.ReadLine();
            var data = str.Split(' ');
            var result = CountWords(data);
            ShowResult(result);
        }

        private static void ShowResult(List<Pair<string, int>> result)
        {
            Console.WriteLine("==> Danh sach cac tu va so lan xuat hien cua no: ");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        private static List<Pair<string, int>> CountWords(string[] data)
        {
            List<Pair<string, int>> result = new List<Pair<string, int>>();
            foreach (var word in data)
            {
                var index = FindWord(result, word);
                if (index == -1)
                {
                    result.Add(new Pair<string, int>(word, 1));
                }
                else
                {
                    result[index].Value++;
                }
            }
            return result;
        }

        // kiểm tra xem từ cần tìm đã có trong danh sách các từ chưa
        private static int FindWord(List<Pair<string, int>> data, string word)
        {
            for (var index = 0; index < data.Count; index++)
            {
                var item = data[index];
                if (item.Key.CompareTo(word) == 0)
                {
                    return index;
                }
            }
            return -1;
        }
    }

    internal class Pair<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public Pair() { }

        public Pair(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
