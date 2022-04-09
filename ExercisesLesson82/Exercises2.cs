using System;
namespace Lesson82
{
    public class Exercises2
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("==> Test 1: ");
            Test(arr, 1);
            Console.WriteLine("==> Test 2: ");
            Test(arr, -1);
            Console.WriteLine("==> Test 3: ");
            Test(arr, 199);
            Console.WriteLine("==> Test 3: ");
            Test(null, 199);
        }

        static void Test(int[] arr, int pos)
        {
            try
            {
                var value = GetElementAt(arr, pos);
                Console.WriteLine($"Gia tri phan tu tai vi tri {pos}: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
        }

        static int GetElementAt(int[] arr, int pos)
        {
            try
            {
                return arr[pos];
            }
            catch (IndexOutOfRangeException) when (pos < 0)
            {
                throw new IndexOutOfRangeException("Chi so phan tu mang < 0: " + pos);
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Chi so phan tu > so phan tu mang: " + pos);
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }

    }
}
