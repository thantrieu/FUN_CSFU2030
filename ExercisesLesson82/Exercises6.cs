using System;
namespace Lesson82
{
    public class Exercises6

    {
        public static void Main()
        {
            Console.WriteLine("==> Test 1: ");
            Test("Hello");
            Console.WriteLine("==> Test 2: ");
            Test(100);
            Console.WriteLine("==> Test 3: ");
            Test(new object());
        }

        static void Test(object obj)
        {
            string[] arr = new string[10];
            try
            {
                arr[0] = (string)obj;
                Console.WriteLine($"Phan tu vua chen: {obj}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
