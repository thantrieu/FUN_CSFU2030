using System;

namespace ExercisesLesson44
{
    class Exercises2
    {
        static void Main()
        {
            Console.WriteLine("Nhap 3 so nguyen cach nhau boi dau cach: ");
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            // thực hiện lời gọi tới phương thức
            Console.WriteLine($"Add() = {Add()}"); // 0 đối số
            Console.WriteLine($"Add({a}) = {Add(a)}"); // 1 đối số
            Console.WriteLine($"Add({a}, {b}) = {Add(a, b)}"); // 2 đối số
            Console.WriteLine($"Add({a}, {b}, {c}) = {Add(a, b, c)}"); // 3 đối số
        }

        static int Add(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }
    }
}
