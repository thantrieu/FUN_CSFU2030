using System;

namespace ExercisesLesson36
{
    class Exercises13
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("Nhap so khac 0 de tiep tuc.");
                Console.WriteLine("Nhap 0 de thoat: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Cam on quy vi da su dung dich vu");
                    break;
                }
                Console.WriteLine("Nhap ngay sinh, thang sinh: ");
                var data = Console.ReadLine().Split(' ');
                var day = int.Parse(data[0]);
                var month = int.Parse(data[1]);
                var invalidDay = "Ngay khong hop le.";
                string result;
                switch (month)
                {
                    case 1: // xét tháng trước
                        if (1 <= day && day <= 19) // sau đó xét ngày
                        {
                            result = "Ma Ket";
                        }
                        else if (20 <= day && day <= 31)
                        {
                            result = "Bao Binh";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 2:
                        if (1 <= day && day <= 18)
                        {
                            result = "Bao Binh";
                        }
                        else if (19 <= day && day <= 29)
                        {
                            result = "Song Ngu";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 3:
                        if (1 <= day && day <= 20)
                        {
                            result = "Song Ngu";
                        }
                        else if (21 <= day && day <= 31)
                        {
                            result = "Bach Duong";

                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 4:
                        if (1 <= day && day <= 20)
                        {
                            result = "Bach Duong";
                        }

                        else if (21 <= day && day <= 30)
                        {
                            result = "Kim Nguu";
                        }

                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 5:
                        if (1 <= day && day <= 20)
                        {
                            result = "Kim Nguu";
                        }

                        else if (21 <= day && day <= 31)
                        {
                            result = "Song Tu";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 6:
                        if (1 <= day && day <= 21)
                        {
                            result = "Song Tu";
                        }
                        else if (22 <= day && day <= 30)
                        {
                            result = "Cu Giai";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 7:
                        if (1 <= day && day <= 22)
                        {
                            result = "Cu Giai";
                        }

                        else if (23 <= day && day <= 31)
                        {
                            result = "Su Tu";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 8:
                        if (1 <= day && day <= 22)
                        {
                            result = "Su Tu";
                        }
                        else if (23 <= day && day <= 31)
                        {
                            result = "Xu Nu";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 9:
                        if (1 <= day && day <= 22)
                        {
                            result = "Xu Nu";

                        }
                        else if (23 <= day && day <= 30)
                        {
                            result = "Thien Binh";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 10:
                        if (1 <= day && day <= 23)
                        {
                            result = "Thien Binh";
                        }
                        else if (24 <= day && day <= 31)
                        {
                            result = "Bo Cap";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 11:
                        if (1 <= day && day <= 22)
                        {
                            result = "Bo Cap";
                        }
                        else if (23 <= day && day <= 30)
                        {
                            result = "Nhan Ma";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    case 12:
                        if (1 <= day && day <= 21)
                        {
                            result = "Nhan Ma";
                        }
                        else if (22 <= day && day <= 31)
                        {
                            result = "Ma Ket";
                        }
                        else
                        {
                            result = invalidDay;
                        }
                        break;
                    default:
                        result = "Thang khong hop le. Vui long nhap thang 1-12";
                        break;
                }
                Console.WriteLine(result);
            } while (choice != 0);
        }
    }
}
