using System;

namespace ExercisesLesson34
{
    class Exercises14
    {
        static void Main()
        {
            int month = int.Parse(Console.ReadLine());
            var result = month < 1 || month > 12 ? "VALUE IS NOT VALID"
                : month == 1 ? "January"
                : month == 2 ? "February"
                : month == 3 ? "March"
                : month == 4 ? "April"
                : month == 5 ? "May"
                : month == 6 ? "June"
                : month == 7 ? "July"
                : month == 8 ? "August"
                : month == 9 ? "September"
                : month == 10 ? "October"
                : month == 11 ? "November"
                : "December";
            Console.WriteLine(result);
        }
    }
}
