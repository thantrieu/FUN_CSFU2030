using System;

namespace ExercisesLesson36
{
    class Exercises10
    {
        static void Main()
        {
            Console.WriteLine("Nhap hai so nguyen a, b: ");
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int choice;
            do
            {
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1. Cong hai so");
                Console.WriteLine("2. Tru a cho b");
                Console.WriteLine("3. Nhan a voi b");
                Console.WriteLine("4. Chia a cho b");
                Console.WriteLine("5. Chia lay du a cho b");
                Console.WriteLine("6. Tinh a^b, b > 0");
                Console.WriteLine("0. Thoat");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Cam on quy vi da su dung dich vu!");
                        break;
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"{a} / {b} = {(float)a / b}");
                        break;
                    case 5:
                        Console.WriteLine($"{a} % {b} = {a % b}");
                        break;
                    case 6:
                        Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
                        break;
                    default:
                        Console.WriteLine("Sai chuc nang. Vui long chon so tu 0-6.");
                        break;
                }
            } while (choice != 0);
        }
    }
}
