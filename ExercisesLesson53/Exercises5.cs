/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson53
{
    class Exercises5
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                int n = elements.Length;
                double[] arr = new double[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = double.Parse(elements[index]);
                }
                QuickSort(arr, 0, (n - 1) / 2);
                QuickSort(arr, (n - 1) / 2 + 1, n - 1, true);
                Console.WriteLine($"Test {i}: ");
                ShowArray(arr);
            }
        }

        // thuật toán quicksort
        static void QuickSort(double[] arr, int leftIndex, int rightIndex, bool reverse = false)
        {
            if (leftIndex < rightIndex)
            {
                int p = reverse ? Partition2(arr, leftIndex, rightIndex) : 
                    Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, p - 1, reverse);
                QuickSort(arr, p + 1, rightIndex, reverse);
            }
        }

        // phương thức sắp xếp và phân mảnh mảng
        static int Partition(double[] arr, int leftIndex, int rightIndex)
        {
            double pivot = arr[rightIndex];
            int i = leftIndex;
            for (int j = leftIndex; j <= rightIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    double tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[rightIndex]);
            return i;
        }

        // phương thức sắp xếp và phân mảnh mảng
        static int Partition2(double[] arr, int leftIndex, int rightIndex)
        {
            double pivot = arr[rightIndex];
            int i = leftIndex;
            for (int j = leftIndex; j <= rightIndex; j++)
            {
                if (arr[j] > pivot)
                {
                    double tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[rightIndex]);
            return i;
        }

        static void Swap(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(double[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
