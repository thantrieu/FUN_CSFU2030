using System;

namespace ExercisesLesson44
{
    class Exercises4
    {
        static void Main()
        {
            Console.WriteLine("Nhap 4 so nguyen cach nhau boi dau cach: ");
            var data = Console.ReadLine().Split(' ');
            long number1 = long.Parse(data[0]);
            long number2 = long.Parse(data[1]);
            long number3 = long.Parse(data[2]);
            long number4 = long.Parse(data[3]);
            // thực hiện lời gọi tới phương thức với các bộ đối số khác nhau
            Console.WriteLine($"Min() = {Min()}");
            Console.WriteLine($"Min({number1}) = {Min(number1)}");
            Console.WriteLine($"Min({number1}, {number2}) = {Min(number1, number2)}");
            Console.WriteLine($"Min({number1}, {number2}, {number3}) = " +
                $"{Min(number1, number2, number3)}");
            Console.WriteLine($"Min({number1}, {number2}, {number3}, {number4}) = " +
                $"{Min(number1, number2, number3, number4)}");
        }

        static long Min(long a = long.MaxValue, long b = long.MaxValue,
            long c = long.MaxValue, long d = long.MaxValue)
        {
            long min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            if (min > d)
            {
                min = d;
            }
            return min;
        }
    }
}
