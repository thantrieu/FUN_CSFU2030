///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises7
    {
        struct Word
        {
            public int counter;
            public string value;

            public Word(string value, int counter)
            {
                this.value = value;
                this.counter = counter;
            }

            public override string ToString()
            {
                return $"({value}: {counter})";
            }
        }

        static bool Contains(Word[] words, string value, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (words[i].value.CompareTo(value) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static int CountWord(string[] data, string key)
        {
            int count = 0;
            foreach (var item in data)
            {
                if (item.CompareTo(key) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void CreateListWords(Word[] words, string[] data, ref int size)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (!Contains(words, data[i], size))
                {
                    words[size++] = new Word(data[i], CountWord(data, data[i]));
                }
            }
        }

        static void ShowWords(Word[] words, int size)
        {
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void Main()
        {
            Console.WriteLine("Nhap vao mot xau ki tu: ");
            var data = Console.ReadLine().Split(' ');
            Word[] words = new Word[data.Length];
            int size = 0;
            CreateListWords(words, data, ref size);
            ShowWords(words, size);
        }
    }
}
