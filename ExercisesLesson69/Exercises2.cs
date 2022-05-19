/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.19</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Text;

namespace ExercisesLesson69
{
    class Exercises2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] students = new Student[100];
            Subject[] subjects = new Subject[100];
            Register[] registers = new Register[100];
            int numOfStudent = 0; // số lượng sinh viên
            int numOfSubject = 0; // số lượng môn học
            int numOfRegister = 0; // số lượng bản đăng ký
            int choice;

            do
            {
                Console.WriteLine("===================== CÁC CHỨC NĂNG =====================");
                Console.WriteLine("1. Thêm mới sinh viên vào danh sách.");
                Console.WriteLine("2. Hiển thị danh sách sinh viên ra màn hình.");
                Console.WriteLine("3. Sắp xếp danh sách sinh viên theo điểm giảm dần.");
                Console.WriteLine("4. Sắp xếp danh sách sinh viên theo tên tăng dần.");
                Console.WriteLine("5. Sắp xếp danh sách sinh viên theo tên tăng, điểm giảm.");
                Console.WriteLine("6. Tìm sinh viên theo tên.");
                Console.WriteLine("7. Tìm sinh viên theo tỉnh, thành phố.");
                Console.WriteLine("8. Xóa sinh viên theo mã cho trước.");
                Console.WriteLine("9. Liệt kê số sinh viên theo từng tỉnh.");
                Console.WriteLine("10. Liệt kê số sinh viên theo điểm TB giảm dần.");
                Console.WriteLine("11. Sửa điểm TB cho sinh viên theo mã sinh viên.");
                Console.WriteLine("12. Thoát chương trình.");
                Console.WriteLine("==> Xin mời bạn chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        if (numOfStudent > 0 && numOfSubject > 0)
                        {

                        }
                        else
                        {
                            if (numOfStudent == 0)
                            {
                                Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                            }
                            if (numOfSubject == 0)
                            {
                                Console.WriteLine("==> Danh sách môn học rỗng <==");
                            }
                        }
                        break;
                    case 4:
                        if (numOfStudent > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfSubject > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfStudent > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfSubject > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 9:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 10:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 11:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 12:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 13:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 14:
                        if (numOfStudent > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 15:
                        if (numOfSubject > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 16:
                        if (numOfSubject > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 17:
                        if (numOfStudent > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 18:
                        if (numOfRegister > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 19:
                        Console.WriteLine("==> Cảm ơn quý khách đã sử dụng dịch vụ! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 19);
        }
    }

    // lớp mô tả thông tin sinh viên
    class Student
    {
        private static int autoId = 1000;

        public string StudentId { get; set; }
        public FullName FullName { get; set; }
        public string Major { get; set; }

        public Student()
        {

        }

        public Student(string id)
        {
            if (id == null)
            {
                StudentId = $"STU{autoId++}";
            }
            else
            {
                StudentId = id;
            }
        }

        public Student(string id, string fullName, string major) : this(id)
        {
            FullName = new FullName(fullName);
            Major = major;
        }

        public override bool Equals(object obj) // hai sinh viên là 1 nếu trùng mã sinh viên
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }
    }

    // lớp mô tả thông tin họ và tên
    class FullName
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MidName { get; set; } = "";

        public FullName() { }

        public FullName(string fullName)
        {
            var data = fullName.Split(' ');
            LastName = data[0];
            FirstName = data[data.Length - 1];
            var mid = "";
            for (int i = 1; i < data.Length - 1; i++)
            {
                mid += data[i] + " ";
            }
            MidName = mid.Trim();
        }

        public FullName(string firstName, string lastName, string midName)
        {
            FirstName = firstName;
            LastName = lastName;
            MidName = midName;
        }

        public override string ToString()
        {
            return $"{LastName} {MidName} {FirstName}";
        }
    }

    // lớp mô tả thông tin môn học
    class Subject
    {
        private static int autoId = 10000;
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public int NumOfLesson { get; set; }

        public Subject()
        {

        }

        public Subject(int id)
        {
            if (id == 0)
            {
                SubjectId = autoId++;
            }
            else
            {
                SubjectId = id;
            }
        }

        public Subject(int id, string name, int credit, int lesson) : this(id)
        {
            Name = name;
            Credit = credit;
            NumOfLesson = lesson;
        }

        public override bool Equals(object obj)
        {
            return obj is Subject subject &&
                   SubjectId == subject.SubjectId;
        }
    }

    // lớp mô tả thông tin đăng ký
    class Register
    {
        private static int autoId = 10000;
        public int RegisterId { get; set; }
        public DateTime RegisterTime { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }

        public Register()
        {

        }

        public Register(int id)
        {
            if (id == 0)
            {
                RegisterId = autoId++;
            }
            else
            {
                RegisterId = id;
            }
        }

        public Register(int id, Student student, Subject subject) : this(id)
        {
            Student = student;
            Subject = subject;
        }

        public override bool Equals(object obj)
        {
            return obj is Register register &&
                   RegisterId == register.RegisterId;
        }
    }
}
