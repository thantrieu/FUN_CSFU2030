using System;

namespace ExercisesLesson44
{
    class Exercises1
    {
        static void Main()
        {
            string id = "SV1001";
            string name = "Le Hoang Anh";
            string address = "Ha Noi";
            int age = 20;
            float gpa = 3.65f;
            string major = "Cong nghe thong tin";
            // gọi phương thức với các bộ đối số khác nhau:
            Console.WriteLine("===========================");
            ShowStudentInfo(id, name);
            Console.WriteLine("===========================");
            ShowStudentInfo(id, name, address);
            Console.WriteLine("===========================");
            ShowStudentInfo(id, name, address, age);
            Console.WriteLine("===========================");
            ShowStudentInfo(id, name, address, age, gpa);
            Console.WriteLine("===========================");
            ShowStudentInfo(id, name, address, age, gpa, major);
        }

        static void ShowStudentInfo(string id, string fullName, string address = "",
            int age = 0, float gpa = 0, string major = "")
        {
            Console.WriteLine("Ma sinh vien: " + id);
            Console.WriteLine("Ho va ten: " + fullName);
            Console.WriteLine("Dia chi: " + address);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Diem TB: " + gpa);
            Console.WriteLine("Chuyen nganh: " + major);
        }
    }
}
