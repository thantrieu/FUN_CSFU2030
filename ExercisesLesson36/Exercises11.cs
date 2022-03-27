using System;

namespace ExercisesLesson36
{
    class Exercises11
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("Nhap ngay(1-7).");
                Console.WriteLine("Nhap 0 de thoat: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Xin chao va hen gap lai");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Gia tri khong hop le. Vui long chon lai!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
