///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.03</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises9
    {
        public struct Occurrent
        {
            public float value;
            public int numOfOccurrent;

            public Occurrent(float value, int occ)
            {
                this.value = value;
                this.numOfOccurrent = occ;
            }
        }

        static int IndexOf(Occurrent[] occurrents, float value)
        {
            for (int i = 0; i < occurrents.Length; i++)
            {
                if(occurrents[i].value == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static Occurrent[] CreateOccurrent(float[] arr)
        {
            Occurrent[] occurrents = new Occurrent[arr.Length];
            int size = 0;
            foreach (var item in arr)
            {
                var index = IndexOf(occurrents, item);
                if (index != -1)
                {
                    occurrents[index].numOfOccurrent++;
                } else
                {
                    occurrents[size].value = item;
                    occurrents[size].numOfOccurrent = 1;
                    size++;
                }
            }
            return occurrents;
        }

        static void ShowResult(Occurrent[] occurrents)
        {
            foreach (var item in occurrents)
            {
                if(item.numOfOccurrent == 0)
                {
                    break;
                } else
                {
                    Console.WriteLine($"{item.value}: {item.numOfOccurrent}");
                }
            }
        }

        static int Comparer(Occurrent o1, Occurrent o2)
        {
            return o2.numOfOccurrent - o1.numOfOccurrent;
        }

        static void Main()
        {
            Console.WriteLine("Nhap cac phan tu cua mang cach nhau boi dau cach: ");
            var elements = Console.ReadLine().Split(' ');
            var arr = new float[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                arr[i] = float.Parse(elements[i]);
            }
            var occurrents = CreateOccurrent(arr);
            Console.WriteLine("So lan xuat hien cua cac phan tu trong mang: ");
            // sắp xếp các phần tử theo thứ tự số lần xuất hiện giảm dần
            Array.Sort(occurrents, Comparer);
            ShowResult(occurrents);
        }
    }
}
