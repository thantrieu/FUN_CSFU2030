///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.02</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises5
    {
        struct Zodiac
        {
            public int startDate;
            public int startMonth;
            public int endDate;
            public int endMonth;
            public string name;

            public Zodiac(int startDate, int startMonth, int endDate, int endMonth, string name)
            {
                this.startDate = startDate;
                this.startMonth = startMonth;
                this.endDate = endDate;
                this.endMonth = endMonth;
                this.name = name;
            }
        }

        static Zodiac[] Initialize()
        {
            return new Zodiac[]
            {
                new Zodiac(21, 3, 20, 4, "Bach Duong"),
                new Zodiac(21, 4, 20, 5, "Kim Nguu"),
                new Zodiac(21, 5, 21, 6, "Song Tu"),
                new Zodiac(22, 6, 22, 7, "Cu Giai"),
                new Zodiac(23, 7, 22, 8, "Su Tu"),
                new Zodiac(23, 8, 22, 9, "Xu Nu"),
                new Zodiac(23, 9, 23, 10, "Thien Binh"),
                new Zodiac(24, 10, 22, 11, "Bo Cap"),
                new Zodiac(23, 11, 21, 12, "Nhan Ma"),
                new Zodiac(22, 12, 19, 1, "Ma Ket"),
                new Zodiac(20, 1, 18, 2, "Bao Binh"),
                new Zodiac(19, 2, 20, 3, "Song Ngu"),
            };
        }

        static string FindZodiacName(Zodiac[] zodiacs, int date, int month)
        {
            var maxDateOfMonth = new int[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month < 1 || month > 12)
            {
                return "INVALID MONTH";
            }
            if (date < 1 || date > maxDateOfMonth[month])
            {
                return "INVALID DATE";
            }
            foreach (var item in zodiacs)
            {
                if (date >= item.startDate && month == item.startMonth ||
                    (date <= item.endDate && month == item.endMonth))
                {
                    return item.name;
                }
            }
            return null;
        }

        static void Main()
        {
            int date, month;
            var data = Console.ReadLine().Split(' ');
            date = int.Parse(data[0]);
            month = int.Parse(data[1]);
            var zodiacs = Initialize();
            var result = FindZodiacName(zodiacs, date, month);
            Console.WriteLine(result);
        }
    }
}
