using System;

namespace ExercisesLesson44
{
    class Exercises3
    {
        static void Main()
        {
            Console.WriteLine("Nhap 4 so nguyen cach nhau boi dau cach: ");
            var data = Console.ReadLine().Split(' ');
            int number1 = int.Parse(data[0]);
            int number2 = int.Parse(data[1]);
            int number3 = int.Parse(data[2]);
            int number4 = int.Parse(data[3]);
            // thực hiện lời gọi tới phương thức với các bộ đối số khác nhau
            Console.WriteLine($"Max() = {Max()}");
            Console.WriteLine($"Max({number1}) = {Max(number1)}");
            Console.WriteLine($"Max({number1}, {number2}) = {Max(number1, number2)}");
            Console.WriteLine($"Max({number1}, {number2}, {number3}) = " +
                $"{Max(number1, number2, number3)}");
            Console.WriteLine($"Max({number1}, {number2}, {number3}, {number4}) = " +
                $"{Max(number1, number2, number3, number4)}");
        }

        static int Max(int a = int.MinValue, int b = int.MinValue,
            int c = int.MinValue, int d = int.MinValue)
        {
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }
            return max;
        }
    }
}
