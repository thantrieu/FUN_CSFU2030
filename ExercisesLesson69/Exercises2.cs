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
                        var newStudent = CreateStudent();
                        if (newStudent != null)
                        {
                            students[numOfStudent++] = newStudent;
                        }
                        break;
                    case 2:
                        var newSubject = CreateSubject();
                        if (newSubject != null)
                        {
                            subjects[numOfSubject++] = newSubject;
                        }
                        break;
                    case 3:
                        if (numOfStudent > 0 && numOfSubject > 0)
                        {
                            var newRegister = CreateRegister(students, subjects);
                            if (newRegister != null)
                            {
                                registers[numOfRegister++] = newRegister;
                            }
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
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfSubject > 0)
                        {
                            ShowSubjects(subjects);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfRegister > 0)
                        {
                            ShowRegisters(registers);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfStudent > 0)
                        {
                            SortStudentByName(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfSubject > 0)
                        {
                            SortSubjectByCredit(subjects);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 9:
                        if (numOfRegister > 0)
                        {
                            SortRegistersByRegTime(registers);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 10:
                        if (numOfRegister > 0)
                        {
                            SortRegistersByStudentId(registers);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 11:
                        if (numOfRegister > 0)
                        {
                            SortRegistersByStudentId(registers);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 12:
                        if (numOfRegister > 0)
                        {
                            var result = FindRegisterBySubjectId(registers);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 13:
                        if (numOfRegister > 0)
                        {
                            var result = FindRegisterByStudentId(registers);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên đăng ký rỗng <==");
                        }
                        break;
                    case 14:
                        if (numOfStudent > 0)
                        {
                            UpdateStudentInfo(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 15:
                        if (numOfSubject > 0)
                        {
                            UpdateSubjectLesson(subjects);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 16:
                        if (numOfSubject > 0)
                        {
                            RemoveSubject(subjects, ref numOfSubject);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 17:
                        if (numOfStudent > 0)
                        {
                            RemoveStudent(students, ref numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 18:
                        if (numOfRegister > 0)
                        {
                            RemoveRegister(registers, ref numOfRegister);
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

        // tạo mới bản đăng ký
        private static Register CreateRegister(Student[] students, Subject[] subjects)
        {
            throw new NotImplementedException();
        }

        // tạo mới môn học
        private static Subject CreateSubject()
        {
            throw new NotImplementedException();
        }

        // tạo mới sinh viên
        private static Student CreateStudent()
        {
            throw new NotImplementedException();
        }

        // hiển thị danh sách sinh viên
        private static void ShowStudents(Student[] students)
        {
            throw new NotImplementedException();
        }

        // hiển thị danh sách đăng ký
        private static void ShowRegisters(Register[] registers)
        {
            throw new NotImplementedException();
        }

        // hiển thị danh sách môn học
        private static void ShowSubjects(Subject[] subjects)
        {
            throw new NotImplementedException();
        }

        // sắp xếp danh sách sinh viên theo tên
        private static void SortStudentByName(Student[] students)
        {
            throw new NotImplementedException();
        }

        // sắp xếp danh sách môn học theo số tín chỉ
        private static void SortSubjectByCredit(Subject[] subjects)
        {
            throw new NotImplementedException();
        }

        // sắp xếp danh sách đăng ký theo thời gian đăng ký
        private static void SortRegistersByRegTime(Register[] registers)
        {
            throw new NotImplementedException();
        }

        // sắp xếp danh sách đăng ký theo mã sinh viên
        private static void SortRegistersByStudentId(Register[] registers)
        {
            throw new NotImplementedException();
        }

        // sắp xếp danh sách đăng ký theo mã môn học
        private static object FindRegisterBySubjectId(Register[] registers)
        {
            throw new NotImplementedException();
        }

        // tìm bản đăng ký theo mã sinh viên
        private static object FindRegisterByStudentId(Register[] registers)
        {
            throw new NotImplementedException();
        }

        // cập nhật số tiết học của một môn học
        private static void UpdateSubjectLesson(Subject[] subjects)
        {
            throw new NotImplementedException();
        }

        // cập nhật thông tin sinh viên khi biết mã sinh viên
        private static void UpdateStudentInfo(Student[] students)
        {
            throw new NotImplementedException();
        }

        // xóa môn học theo mã cho trước
        private static void RemoveSubject(Subject[] subjects, ref int size)
        {
            Console.WriteLine("Nhập mã môn học cần xóa: ");
            var idToRemove = int.Parse(Console.ReadLine());
            int index = FindSubjectIndexById(subjects, idToRemove, size);
            if (index == -1)
            {
                Console.WriteLine("==> Không tìm thấy môn học cần xóa. <==");
            }
            else
            {
                Console.WriteLine("==> Bạn có chắc chắn muốn xóa không?(Y/N) ");
                var ans = Console.ReadLine()[0];
                if (ans == 'Y' || ans == 'y')
                {
                    for (int i = index; i < size - 1; i++)
                    {
                        subjects[i] = subjects[i + 1];
                    }
                    size--; // giảm số phần tử trong mảng môn học đi 1 đơn vị
                }
                else
                {
                    Console.WriteLine("==> Hành động xóa môn học bị hủy bỏ. <==");
                }
            }
        }

        // tìm vị trí của bản đăng ký trong mảng khi biết mã đăng ký
        private static int FindSubjectIndexById(Subject[] subjects, int id, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (subjects[i] != null && subjects[i].SubjectId == id)
                {
                    return i;
                }
            }
            return -1; // không tìm thấy
        }

        // xóa sinh viên theo mã cho trước
        private static void RemoveStudent(Student[] students, ref int size)
        {
            Console.WriteLine("Nhập mã sinh viên cần xóa: ");
            var idToRemove = Console.ReadLine().ToUpper();
            int index = FindStudentIndexById(students, idToRemove, size);
            if (index == -1)
            {
                Console.WriteLine("==> Không tìm thấy sinh viên cần xóa. <==");
            }
            else
            {
                Console.WriteLine("==> Bạn có chắc chắn muốn xóa không?(Y/N) ");
                var ans = Console.ReadLine()[0];
                if (ans == 'Y' || ans == 'y')
                {
                    for (int i = index; i < size - 1; i++)
                    {
                        students[i] = students[i + 1];
                    }
                    size--; // giảm số phần tử trong mảng sinh viên đi 1 đơn vị
                }
                else
                {
                    Console.WriteLine("==> Hành động xóa sinh viên bị hủy bỏ. <==");
                }
            }
        }

        // tìm vị trí của sinh viên cần xóa trong mảng
        private static int FindStudentIndexById(Student[] students, string id, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (students[i] != null && students[i].StudentId.CompareTo(id) == 0)
                {
                    return i; // tìm thấy
                }
            }
            return -1; // không tìm thấy
        }

        // xóa bản đăng ký theo mã đăng ký
        private static void RemoveRegister(Register[] registers, ref int size)
        {
            Console.WriteLine("Nhập mã bản đăng ký cần xóa: ");
            var idToRemove = int.Parse(Console.ReadLine());
            int index = FindRegisterIndexById(registers, idToRemove, size);
            if (index == -1)
            {
                Console.WriteLine("==> Không tìm thấy bản đăng ký cần xóa. <==");
            }
            else
            {
                Console.WriteLine("==> Bạn có chắc chắn muốn xóa không?(Y/N) ");
                var ans = Console.ReadLine()[0];
                if (ans == 'Y' || ans == 'y')
                {
                    for (int i = index; i < size - 1; i++)
                    {
                        registers[i] = registers[i + 1];
                    }
                    size--; // giảm số phần tử trong mảng đăng ký đi 1 đơn vị
                }
                else
                {
                    Console.WriteLine("==> Hành động xóa bản đăng ký bị hủy bỏ. <==");
                }
            }
        }

        // tìm vị trí của bản đăng ký trong mảng khi biết mã đăng ký
        private static int FindRegisterIndexById(Register[] registers, int id, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (registers[i] != null && registers[i].RegisterId == id)
                {
                    return i;
                }
            }
            return -1; // không tìm thấy
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
