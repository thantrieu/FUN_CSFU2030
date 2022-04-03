///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises8
    {
        struct Increment
        {
            public int length; // độ dài dãy tăng
            public int startPos; // vị trí bắt đầu của dãy trong mảng gốc
            public int[] elements; // các phần tử của dãy

            public Increment(int length, int startPos, int[] elements)
            {
                this.length = length;
                this.startPos = startPos;
                this.elements = elements;
            }
        }

        // phương thức tìm tất cả các dãy tăng trong mảng đầu vào
        static Increment[] FindIncrement(int[] arr)
        {
            Increment[] result = new Increment[arr.Length];
            int resultSize = 0;
            int countElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                countElement++;
                if (i + 1 < arr.Length && arr[i + 1] < arr[i] ||
                    (i == arr.Length - 1 &&
                    (arr.Length == countElement || result[resultSize - 1].startPos != i)))
                {
                    result[resultSize].length = countElement;
                    result[resultSize].startPos = i + 1 - countElement;
                    result[resultSize].elements = new int[countElement];
                    int index = 0;
                    for (int j = i + 1 - countElement; j <= i; j++)
                    {
                        result[resultSize].elements[index++] = arr[j];
                    }
                    resultSize++;
                    countElement = 0;
                }
            }
            return result;
        }

        // phương thức tìm độ dài lớn nhất trong các dãy tăng
        static int FindMaxLength(Increment[] increments)
        {
            int maxLength = 0;
            foreach (var item in increments)
            {
                if (item.length > maxLength)
                {
                    maxLength = item.length;
                }
            }
            return maxLength;
        }

        // phương thức hiển thị các dãy tăng dài nhất
        static void ShowIncrement(Increment[] increments, int maxLength)
        {
            foreach (var item in increments)
            {
                if (item.length == 0)
                {
                    break;
                } else if (item.length == maxLength)
                {
                    for (int j = 0; j < item.length; j++)
                    {
                        Console.Write(item.elements[j] + " ");
                    };
                    Console.WriteLine();
                }
            }
        }

        static void Main()
        {
            var elements = Console.ReadLine().Split(' ');
            var arr = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                arr[i] = int.Parse(elements[i]);
            }
            var increments = FindIncrement(arr);
            var maxLength = FindMaxLength(increments);
            Console.WriteLine(maxLength);
            ShowIncrement(increments, maxLength);
        }
    }
}
