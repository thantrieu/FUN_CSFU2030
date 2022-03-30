/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson53
{
    class Exercises3
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                QuickSort(elements, 0, elements.Length - 1);
                Console.WriteLine($"Test {i}: ");
                ShowArray(elements);
            }
        }

        // thuật toán quicksort
        static void QuickSort(string[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int p = Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, p - 1);
                QuickSort(arr, p + 1, rightIndex);
            }
        }

        // phương thức sắp xếp và phân mảnh mảng
        static int Partition(string[] arr, int leftIndex, int rightIndex)
        {
            string pivot = arr[rightIndex];
            int i = leftIndex;
            for (int j = leftIndex; j <= rightIndex; j++)
            {
                if (arr[j].CompareTo(pivot) < 0)
                {
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[rightIndex]);
            return i;
        }

        static void Swap(ref string a, ref string b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
