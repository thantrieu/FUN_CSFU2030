using System;

namespace ExercisesLesson32
{
    class Exercises3
    {
        static void Main()
        {
            // nhập hai số liên tiếp. Ví dụ nhập 2 3 rồi nhấn enter.
            var data = Console.ReadLine().Split(' ');   // tách hai số tại vị trí dấu cách thành số "2" và số "3" ở dạng string
            int a = int.Parse(data[0]);                 // chuyển đổi string số thứ nhất thành số kiểu nguyên. Vd "2" -> 3
            int b = int.Parse(data[1]);                 // chuyển đổi string số thứ hai thành số kiểu nguyên. Vd "3" -> 3
            if (a == b)                                 // nếu hai số bằng nhau
            {
                Console.WriteLine("EQUAL");             // hiển thị EQUAL ra màn hình
            }
            else                                        // ngược lại, hai số khác nhau
            {
                var diff  = Math.Abs(a - b);            // biến diff lưu giá trị lệch nhau giữa hai số
                Console.WriteLine($"DIFFERENT {diff}"); // hiển thị độ lệch của hai số trong biến diff ra màn hình
            }
        }
    }
}
