using System;
namespace Lesson82
{
    public class Exercises4
    {
        public static void Main()
        {
            Console.WriteLine("==> Test 1: ");
            Test(4, 2);
            Console.WriteLine("==> Test 2: ");
            Test(4, 0);
            Console.WriteLine("==> Test 3: ");
            Test(0, 0);
        }

        static void Test(int a, int b)
        {
            try
            {
                var result = Div(a, b);
                Console.WriteLine($"{a} / {b} = {result}");
            } catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }

        static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
