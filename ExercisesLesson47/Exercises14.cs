/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.29
/// </summary>

using System;

namespace ExercisesLesson47
{
    class Exercises14
    {
        static void Main()
        {
            Console.WriteLine("Nhap so luong dia: ");
            int n = int.Parse(Console.ReadLine());
            TowerOfHaNoi(n, 'A', 'C', 'B');
        }

        /*
         * B1: Nếu n == 1, chuyển n từ cọc A sang cọc C. Kết thúc.
         * B2: gọi đệ quy, chuyển n-1 đĩa từ cọc A sang cọc B.
         * B3: chuyển đĩa dưới cùng sang cọc C.
         * B4: chuyển n-1 đĩa từ cọc B sang cọc C.
         * Sau khi chuyển, đọc ngược giá trị tại cột C từ dưới lên
         * với điều kiện giá trị đọc trước nhỏ hơn giá trị đọc sau
         * sẽ được kết quả xét từ trên xuống(1-n).
         */
        static void TowerOfHaNoi(int n, char from, char to, char tmp)
        {
            if(n == 1)
            {
                Console.WriteLine($"Chuyen {n} tu coc {from} den coc {to}");
                return;
            }
            TowerOfHaNoi(n - 1, from, tmp, to);
            Console.WriteLine($"Chuyen {n} tu coc {from} den coc {to}");
            TowerOfHaNoi(n - 1, tmp, to, from);
        }
    }
}
