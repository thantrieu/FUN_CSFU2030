using System;

namespace ExercisesLesson42
{
    class Exercises9
    {
        static void Main()
        {
            GetData(out string id, out string fullName, out string dob, 
                out string email, out float gpa);
            Console.WriteLine("========================");
            ShowStudentInfo(id, fullName, dob, email, gpa);
            reachSholarship(gpa, out bool result);
            Console.WriteLine($"Sinh vien {(result ? "dat" : "khong dat")} hoc bong");
        }

        /// <summary>
        /// Phương thức hiển thị thông tin sinh viên
        /// </summary>
        /// <param name="id">Mã sinh viên</param>
        /// <param name="fullName">Họ tên</param>
        /// <param name="birdthDate">Ngày sinh</param>
        /// <param name="email">Email</param>
        /// <param name="gpa">Điểm trung bình</param>
        static void ShowStudentInfo(in string id, in string fullName, in string birdthDate,
            in string email, in float gpa)
        {
            Console.WriteLine("Ma sinh vien: " + id);
            Console.WriteLine("Ho va ten: " + fullName);
            Console.WriteLine("Ngay sinh: " + birdthDate);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Diem TB: " + gpa);
        }

        /// <summary>
        /// Phương thức kiểm tra xem sinh viên có đạt học bổng hay không
        /// </summary>
        /// <param name="gpa">Điểm TB</param>
        /// <param name="result">Kết quả</param>
        static void reachSholarship(in float gpa, out bool result)
        {
            if(gpa >= 3.35f)
            {
                result = true;
            } else
            {
                result = false;
            }
        }

        /// <summary>
        /// Phương thức nhập thông tin sinh viên
        /// </summary>
        /// <param name="id">Mã sinh viên</param>
        /// <param name="fullName">Họ và tên</param>
        /// <param name="birdthDate">Ngày sinh</param>
        /// <param name="email">Email</param>
        /// <param name="gpa">Điểm TB</param>
        static void GetData(out string id, out string fullName, out string birdthDate,
            out string email, out float gpa)
        {
            Console.Write("Ma sinh vien: ");
            id = Console.ReadLine();
            Console.Write("Ho va ten: ");
            fullName = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            birdthDate = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Gpa: ");
            gpa = float.Parse(Console.ReadLine());
        }

    }
}
