using System;

namespace Lesson82
{
    class Exercises1
    {
        public static void Main()
        {
            Console.WriteLine("==> Test 1: ");
            Console.WriteLine("Nhap vao chuoi ki tu");
            var str = Console.ReadLine();
            Test(str);
            Console.WriteLine("==> Test 2: ");
            Test(null);
        }

        static void Test(string str)
        {
            try
            {
                var wordCount = CountWord(str);
                Console.WriteLine($"So tu co trong chuoi: {wordCount}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        static int CountWord(string str)
        {
            var words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var count = words.Length;
            return count;
        }
    }
}
