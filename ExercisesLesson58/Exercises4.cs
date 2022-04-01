///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises4
    {
        struct DayOfWeek
        {
            public int day;
            public string dateNameEnglish;
            public string dateNameVietnamese;

            public DayOfWeek(int day, string eng, string vni)
            {
                this.day = day;
                dateNameEnglish = eng;
                dateNameVietnamese = vni;
            }
        }

        static DayOfWeek[] Initialize()
        {
            return new DayOfWeek[]
            {
                new DayOfWeek(1, "Monday", "Thu Hai"),
                new DayOfWeek(2, "Tuesday", "Thu Ba"),
                new DayOfWeek(3, "Wednesday", "Thu Tu"),
                new DayOfWeek(4, "Thursday", "Thu Nam"),
                new DayOfWeek(5, "Friday", "Thu Sau"),
                new DayOfWeek(6, "Saturday", "Thu Bay"),
                new DayOfWeek(7, "Sunday", "Chu Nhat"),
            };
        }

        static string DayName(DayOfWeek[] days, int day)
        {
            foreach (var item in days)
            {
                if (item.day == day)
                {
                    return $"{item.dateNameEnglish}-{item.dateNameVietnamese}";
                }
            }
            return null;
        }

        static void Main()
        {
            DayOfWeek[] dayOfWeeks = Initialize();
            int day;
            do
            {
                Console.WriteLine("Nhap ngay(1-7); ");
                day = int.Parse(Console.ReadLine());
                if (day < 1 || day > 7)
                {
                    Console.WriteLine("Ngay khong hop le. Vui long nhap 1-7");
                }
                else if (day == 0)
                {
                    break;
                }
                else
                {
                    var result = DayName(dayOfWeeks, day);
                    Console.WriteLine(result);
                }
            } while (day != 0);
        }
    }
}
