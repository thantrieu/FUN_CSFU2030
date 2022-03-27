using System;

namespace ExercisesLesson34
{
    class Exercises4
    {
        static void Main()
        {
            // nhập dữ liệu vào từ bàn phím và tách các số tại vị trí có dấu cách
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]); // chuyển string sang int
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);

            // hiển thị kết quả
            if(a == b && b == c)
            {
                Console.WriteLine("NO RESULT");
            }
            else
            {
                int max = a;
                max = (max < b) ? b : max;
                max = (max < c) ? c : max;
                Console.WriteLine(max);
            }
        }
    }
}
