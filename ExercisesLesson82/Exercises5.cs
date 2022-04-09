using System;
namespace Lesson82
{
    public class Exercises5
    {
        public static void Main()
        {
            Console.WriteLine("==> Test 1: ");
            Test("welcome to branium academy!");
            Console.WriteLine("==> Test 2: ");
            Test(null);
        }

        static void Test(string input)
        {
            try
            {
                Console.WriteLine($"Chuoi goc: {input}");
                Console.WriteLine($"Chuoi sau chuyen doi: {input.ToUpper()}");
            } catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
