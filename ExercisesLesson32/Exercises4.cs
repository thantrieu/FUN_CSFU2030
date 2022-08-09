using System;

namespace ExercisesLesson32
{
    class Exercises4
    {
        static void Main()
        {
            // nhập 3 số liên tiếp cách nhau bởi dấu cách vào từ bàn phím và tách các số tại vị trí có dấu cách
            // ví dụ gõ: 100 200 300 sau đó nhấn enter
            // do hàm đọc dữ liệu vào từ bàn phím trả về giá trị string "100 200 300"
            // nên ta dùng hàm Split(' ') để tách các thành phần trong string tại vị trí có dấu cách
            var data = Console.ReadLine().Split(' '); // tách thành 3 string "100", "200", "300"
            int a = int.Parse(data[0]); // chuyển string sang int
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            
            // so sánh và hiển thị kết quả
            if(a == b && b == c)
            {
                Console.WriteLine("NO RESULT");
            } else
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
                Console.WriteLine(max);
            }
        }
    }
}
