using System;
namespace Lesson82
{
    public class Exercises3
    {
        public static void Main()
        {
            float[] arr = new float[] { 1.23f, 5.6f, 9.98f, 2.23f, 7.53f, 2.53f };
            Console.WriteLine("==> Test 1: ");
            Test(arr, 0, 3);
            Console.WriteLine("==> Test 2: ");
            Test(arr, -8, 2);
            Console.WriteLine("==> Test 3: ");
            Test(arr, 2, 45);
            Console.WriteLine("==> Test 4: ");
            Test(null, 0, 1);
        }

        static void Test(float[] arr, int firstIndex, int secondIndex)
        {
            try
            {
                var a = arr[firstIndex];
                var b = arr[secondIndex];
                Console.WriteLine($"{a} + {b} = {Sum(a, b)}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }

        static float Sum(float a, float b)
        {
            return a + b;
        }
    }
}
