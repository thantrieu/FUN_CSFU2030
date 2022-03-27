using System;

namespace ExercisesLesson43
{
    class Exercises5
    {
        static void Main()
        {
            GetStudentData(out string last, out string mid, out string first, 
                out int age, out string address, out float gpa, out string major);
            ShowStudentInfo(first, last, mid, age, address, gpa, major);
        }

        /// <summary>
        /// Phương thức nhập thông tin cho sinh viên.
        /// </summary>
        /// <param name="last">Họ.</param>
        /// <param name="mid">Đệm.</param>
        /// <param name="first">Tên.</param>
        static void GetStudentData(out string last, out string mid, out string first)
        {
            Console.Write("Ho: ");
            last = Console.ReadLine();
            Console.Write("Ten dem: ");
            mid = Console.ReadLine();
            Console.Write("Ten: ");
            first = Console.ReadLine();
        }

        /// <summary>
        /// Phương thức nạp chồng nhập thông tin cho sinh viên.
        /// </summary>
        /// <param name="last">Họ.</param>
        /// <param name="mid">Đệm.</param>
        /// <param name="first">Tên.</param>
        /// <param name="age">Tuổi.</param>
        static void GetStudentData(out string last, out string mid,
            out string first, out int age)
        {
            GetStudentData(out last, out mid, out first);
            Console.Write("Tuoi: ");
            age = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Phương thức nạp chồng nhập thông tin cho sinh viên.
        /// </summary>
        /// <param name="last">Họ.</param>
        /// <param name="mid">Đệm.</param>
        /// <param name="first">Tên.</param>
        /// <param name="address">Địa chỉ, tỉnh hoặc thành phố.</param>
        static void GetStudentData(out string last, out string mid,
            out string first, out int age, out string address)
        {
            GetStudentData(out last, out mid, out first, out age);
            Console.Write("Dia chi: ");
            address = Console.ReadLine();
        }

        /// <summary>
        /// Phương thức nạp chồng nhập thông tin cho sinh viên.
        /// </summary>
        /// <param name="last">Họ.</param>
        /// <param name="mid">Đệm.</param>
        /// <param name="first">Tên.</param>
        /// <param name="address">Địa chỉ, tỉnh hoặc thành phố.</param>
        /// <param name="gpa">Điểm TB.</param>
        static void GetStudentData(out string last, out string mid,
            out string first, out int age, out string address, out float gpa)
        {
            GetStudentData(out last, out mid, out first, out age, out address);
            Console.Write("Diem TB: ");
            gpa = float.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Phương thức nạp chồng nhập thông tin cho sinh viên.
        /// </summary>
        /// <param name="last">Họ.</param>
        /// <param name="mid">Đệm.</param>
        /// <param name="first">Tên.</param>
        /// <param name="address">Địa chỉ, tỉnh hoặc thành phố.</param>
        /// <param name="gpa">Điểm TB.</param>
        /// <param name="major">Chuyên ngành.</param>
        static void GetStudentData(out string last, out string mid, out string first,
            out int age, out string address, out float gpa, out string major)
        {
            GetStudentData(out last, out mid, out first, out age, out address, out gpa);
            Console.Write("Chuyen nganh: ");
            major = Console.ReadLine();
        }

        /// <summary>
        /// Phương thức hiển thị thông tin sinh viên.
        /// </summary>
        /// <param name="first">Tên.</param>
        /// <param name="last">Họ.</param>
        /// <param name="mid">Đệm.</param>
        /// <param name="age">Tuổi.</param>
        /// <param name="address">Địa chỉ.</param>
        /// <param name="gpa">Điểm TB.</param>
        /// <param name="major">Chuyên ngành.</param>
        static void ShowStudentInfo(in string first, in string last, in string mid,
            in int age, in string address, in float gpa, in string major)
        {
            Console.WriteLine("First name: " + first);
            Console.WriteLine("Last name: " + last);
            Console.WriteLine("Middle name: " + mid);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("Major: " + major);
        }
    }
}
