﻿/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.19</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Collections.Generic;
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
            CreateFakeStudents(students, ref numOfStudent);
            CreateFakeSubjects(subjects, ref numOfSubject);
            CreateFakeRegisters(registers, ref numOfRegister, students, subjects);
            int choice;

            do
            {
                Console.WriteLine("===================== CÁC CHỨC NĂNG =====================");
                Console.WriteLine("1. Thêm mới sinh viên vào danh sách sinh viên.");
                Console.WriteLine("2. Thêm mới môn học vào danh sách môn học.");
                Console.WriteLine("3. Thêm mới bản đăng ký môn học vào danh sách đăng ký.");
                Console.WriteLine("4. Hiển thị danh sách sinh viên ra màn hình.");
                Console.WriteLine("5. Hiển thị danh sách môn học ra màn hình.");
                Console.WriteLine("6. Hiển thị danh sách đăng ký ra màn hình.");
                Console.WriteLine("7. Sắp xếp danh sách sinh viên theo tên a-z.");
                Console.WriteLine("8. Sắp xếp danh sách môn học theo số tín chỉ giảm dần.");
                Console.WriteLine("9. Sắp xếp danh sách đăng ký theo thời gian đăng ký.");
                Console.WriteLine("10. Sắp xếp danh sách đăng ký theo mã sinh viên.");
                Console.WriteLine("11. Sắp xếp danh sách đăng ký theo mã môn học.");
                Console.WriteLine("12. Tìm danh sách đăng ký theo mã môn học.");
                Console.WriteLine("13. Tìm danh sách đăng ký theo mã sinh viên.");
                Console.WriteLine("14. Sửa tên sinh viên theo mã sinh viên cho trước.");
                Console.WriteLine("15. Sửa số tiết học theo mã môn học cho trước.");
                Console.WriteLine("16. Xóa môn học khỏi danh sách môn học.");
                Console.WriteLine("17. Xóa sinh viên khỏi danh sách sinh viên.");
                Console.WriteLine("18. Xóa bản đăng ký theo mã đăng ký.");
                Console.WriteLine("19. Thoát chương trình.");
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
                            if (newRegister != null && newRegister.Subject != null && newRegister.Student != null)
                            {
                                if (!Contains(registers, newRegister))
                                {
                                    registers[numOfRegister++] = newRegister;
                                    Console.WriteLine($"==> Sinh viên \"{newRegister.Student.StudentId}\" " +
                                        $"đăng ký thành công môn học \"{newRegister.Subject.SubjectId}\". <==");
                                }
                                else
                                {
                                    Console.WriteLine($"==> Lỗi. Sinh viên \"{newRegister.Student.StudentId}\" " +
                                        $"đã đăng ký môn học \"{newRegister.Subject.SubjectId}\" trước đó. <==");
                                }
                            }
                            else if (newRegister.Subject == null)
                            {
                                Console.WriteLine("==> Môn học cần đăng ký không tồn tại. <==");
                            }
                            else if (newRegister.Student == null)
                            {
                                Console.WriteLine("==> Sinh viên cần đăng ký không tồn tại. <==");
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
                            SortRegistersBySubjectId(registers);
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
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Không có kết quả tìm kiếm. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm theo mã môn học: <==");
                                ShowRegisters(result);
                            }
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
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Không có kết quả tìm kiếm. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm theo mã sinh viên: <==");
                                ShowRegisters(result);
                            }
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

        private static void CreateFakeRegisters(Register[] registers,
            ref int numOfRegister, Student[] students, Subject[] subjects)
        {
            registers[numOfRegister++] = new Register(0, students[0], subjects[0], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[1], subjects[0], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[2], subjects[0], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[3], subjects[0], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[4], subjects[0], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[0], subjects[5], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[1], subjects[2], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[2], subjects[1], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[3], subjects[3], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[4], subjects[4], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[1], subjects[1], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[1], subjects[5], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[0], subjects[1], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[0], subjects[2], DateTime.Now);
            registers[numOfRegister++] = new Register(0, students[0], subjects[3], DateTime.Now);
        }

        // kiểm tra xem một bản đăng ký đã tồn tại trước đó chưa
        private static bool Contains(Register[] registers, Register newRegister)
        {
            foreach (var item in registers)
            {
                if (item != null && item.Equals(newRegister))
                {
                    return true;
                }
            }
            return false;
        }

        private static void CreateFakeSubjects(Subject[] subjects, ref int numOfSubject)
        {
            subjects[numOfSubject++] = new Subject(0, "C++", 3, 36);
            subjects[numOfSubject++] = new Subject(0, "C", 3, 36);
            subjects[numOfSubject++] = new Subject(0, "C#", 4, 48);
            subjects[numOfSubject++] = new Subject(0, "Java", 4, 46);
            subjects[numOfSubject++] = new Subject(0, "Kotlin", 3, 36);
            subjects[numOfSubject++] = new Subject(0, "Android", 5, 60);
            subjects[numOfSubject++] = new Subject(0, "SQL", 3, 36);
            subjects[numOfSubject++] = new Subject(0, "Python", 4, 48);
            subjects[numOfSubject++] = new Subject(0, "JavaScript", 3, 36);
            subjects[numOfSubject++] = new Subject(0, "Web design", 2, 25);
        }

        private static void CreateFakeStudents(Student[] students, ref int numOfStudent)
        {
            students[numOfStudent++] = new Student(null, "Trần Văn Nam", "CNTT");
            students[numOfStudent++] = new Student(null, "Ngô Văn Tài", "CNTT");
            students[numOfStudent++] = new Student(null, "Hồ Hoàng Yến", "CNTT");
            students[numOfStudent++] = new Student(null, "Võ Hoàng Yến", "CNTT");
            students[numOfStudent++] = new Student(null, "Vy Thị Yến", "CNTT");
            students[numOfStudent++] = new Student(null, "Mai Văn Dũng", "CNTT");
            students[numOfStudent++] = new Student(null, "Lê Thanh Thảo", "CNTT");
            students[numOfStudent++] = new Student(null, "Ngô Nhật Phong", "CNTT");
            students[numOfStudent++] = new Student(null, "Ma Thanh Thức", "CNTT");
            students[numOfStudent++] = new Student(null, "Khúc Thị Lệ Quyên", "CNTT");
            students[numOfStudent++] = new Student(null, "Trương Trọng Anh", "CNTT");
            students[numOfStudent++] = new Student(null, "Nguyễn Quỳnh Anh", "CNTT");
            students[numOfStudent++] = new Student(null, "Thân Văn Huấn", "CNTT");
        }

        // tìm bản đăng ký theo mã môn học
        private static Register[] FindRegisterBySubjectId(Register[] registers)
        {
            var result = new Register[registers.Length];
            int numOfResult = 0;
            Console.WriteLine("Mã môn học cần tìm: ");
            var subjectId = int.Parse(Console.ReadLine());
            foreach (var item in registers)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Subject.SubjectId == subjectId)
                {
                    result[numOfResult++] = item;
                }
            }
            return result;
        }

        // tạo mới bản đăng ký
        private static Register CreateRegister(Student[] students, Subject[] subjects)
        {
            Console.WriteLine("Mã sinh viên đăng ký: ");
            var studentId = Console.ReadLine().ToUpper();
            Console.WriteLine("Mã môn học được chọn: ");
            var subjectId = int.Parse(Console.ReadLine());
            var registerTime = DateTime.Now;
            var studentIndex = FindStudentIndexById(students, studentId, students.Length);
            var subjectIndex = FindSubjectIndexById(subjects, subjectId, subjects.Length);
            var subject = subjectIndex == -1 ? null : subjects[subjectIndex];
            var student = studentIndex == -1 ? null : students[studentIndex];
            return new Register(0, student, subject, registerTime);
        }

        // tạo mới môn học
        private static Subject CreateSubject()
        {
            Console.WriteLine("Tên môn học: ");
            var name = Console.ReadLine();
            Console.WriteLine("Số tín chỉ: ");
            var credit = int.Parse(Console.ReadLine());
            Console.WriteLine("Số tiết học: ");
            var lesson = int.Parse(Console.ReadLine());
            return new Subject(0, name, credit, lesson);
        }

        // tạo mới sinh viên
        private static Student CreateStudent()
        {
            Console.WriteLine("Họ và tên: ");
            var name = Console.ReadLine();
            Console.WriteLine("Chuyên ngành: ");
            var major = Console.ReadLine();
            return new Student(null, name, major);
        }

        // hiển thị danh sách sinh viên
        private static void ShowStudents(Student[] students)
        {
            var id = "Mã sinh viên";
            var name = "Họ và tên";
            var major = "Chuyên ngành";
            Console.WriteLine($"{id,-15:d}{name,-25:d}{major,-15:d}");
            foreach (var student in students)
            {
                if (student == null)
                {
                    break;
                }
                Console.WriteLine($"{student.StudentId,-15:d}" +
                    $"{student.FullName,-25:d}{student.Major,-15:d}");
            }
        }

        // hiển thị danh sách đăng ký
        private static void ShowRegisters(Register[] registers)
        {
            var id = "Mã đăng ký";
            var stId = "Mã sinh viên";
            var stName = "Tên sinh viên";
            var suId = "Mã môn học";
            var suName = "Tên môn học";
            var regTime = "Thời gian đăng ký";
            Console.WriteLine($"{id,-15:d}{stId,-15:d}{stName,-25:d}{suId,-15:d}{suName,-25:d}{regTime,-15:d}");
            foreach (var reg in registers)
            {
                if (reg == null)
                {
                    break;
                }
                Console.WriteLine($"{reg.RegisterId,-15:d}{reg.Student.StudentId,-15:d}" +
                    $"{reg.Student.FullName,-25:d}{reg.Subject.SubjectId,-15:d}" +
                    $"{reg.Subject.Name,-25:d}{reg.RegisterTime.ToString("dd/MM/yyyy HH:mm:ss"),-15:d}");
            }
        }

        // hiển thị danh sách môn học
        private static void ShowSubjects(Subject[] subjects)
        {
            var id = "Mã môn học";
            var name = "Tên môn học";
            var credit = "Số tín chỉ";
            var lesson = "Số tiết học";
            Console.WriteLine($"{id,-15:d}{name,-25:d}{credit,-15:d}{lesson,-15:d}");
            foreach (var subject in subjects)
            {
                if (subject == null)
                {
                    break;
                }
                Console.WriteLine($"{subject.SubjectId,-15:d}{subject.Name,-25:d}" +
                    $"{subject.Credit,-15:d}{subject.NumOfLesson,-15:d}");
            }
        }

        // sắp xếp danh sách sinh viên theo tên, nếu trùng tên thì sắp xếp theo họ a-z
        private static void SortStudentByName(Student[] students)
        {
            int comparer(Student s1, Student s2)
            {
                if (s1 == null && s2 == null)
                {
                    return 0;
                }
                else if (s1 == null && s2 != null)
                {
                    return 1;
                }
                else if (s1 != null && s2 == null)
                {
                    return -1;
                }
                else
                {
                    int nameCompare = s1.FullName.FirstName.CompareTo(s2.FullName.FirstName);
                    if (nameCompare != 0)
                    {
                        return nameCompare;
                    }
                    else
                    {
                        return s1.FullName.LastName.CompareTo(s2.FullName.LastName);
                    }
                }
            }
            Array.Sort(students, comparer);
        }

        // sắp xếp danh sách môn học theo số tín chỉ
        private static void SortSubjectByCredit(Subject[] subjects)
        {
            int comparer(Subject s1, Subject s2)
            {
                if (s1 == null && s2 == null)
                {
                    return 0;
                }
                else if (s1 == null && s2 != null)
                {
                    return 1;
                }
                else if (s1 != null && s2 == null)
                {
                    return -1;
                }
                else
                {
                    return s2.Credit - s1.Credit;
                }
            }
            Array.Sort(subjects, comparer);
        }

        // sắp xếp danh sách đăng ký theo thời gian đăng ký
        private static void SortRegistersByRegTime(Register[] registers)
        {
            int comparer(Register r1, Register r2)
            {
                if (r1 == null && r2 == null)
                {
                    return 0;
                }
                else if (r1 == null && r2 != null)
                {
                    return 1;
                }
                else if (r1 != null && r2 == null)
                {
                    return -1;
                }
                else
                {
                    return r1.RegisterTime < r2.RegisterTime ? -1 :
                        r1.RegisterTime > r2.RegisterTime ? 1 : 0;
                }
            }
            Array.Sort(registers, comparer);
        }

        // sắp xếp danh sách đăng ký theo mã sinh viên
        private static void SortRegistersByStudentId(Register[] registers)
        {
            int comparer(Register r1, Register r2)
            {
                if (r1 == null && r2 == null)
                {
                    return 0;
                }
                else if (r1 == null && r2 != null)
                {
                    return 1;
                }
                else if (r1 != null && r2 == null)
                {
                    return -1;
                }
                else
                {
                    return r1.Student.StudentId.CompareTo(r2.Student.StudentId);
                }
            }
            Array.Sort(registers, comparer);
        }

        // sắp xếp danh sách đăng ký theo mã môn học
        private static void SortRegistersBySubjectId(Register[] registers)
        {
            int comparer(Register r1, Register r2)
            {
                if (r1 == null && r2 == null)
                {
                    return 0;
                }
                else if (r1 == null && r2 != null)
                {
                    return 1;
                }
                else if (r1 != null && r2 == null)
                {
                    return -1;
                }
                else
                {
                    return r1.Subject.SubjectId.CompareTo(r2.Subject.SubjectId);
                }
            }
            Array.Sort(registers, comparer);
        }

        // tìm bản đăng ký theo mã sinh viên
        private static Register[] FindRegisterByStudentId(Register[] registers)
        {
            var result = new Register[registers.Length];
            int numOfResult = 0;
            Console.WriteLine("Mã sinh viên cần tìm: ");
            var studentId = Console.ReadLine().ToUpper();
            foreach (var item in registers)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Student.StudentId.CompareTo(studentId) == 0)
                {
                    result[numOfResult++] = item;
                }
            }
            return result;
        }

        // cập nhật số tiết học của một môn học
        private static void UpdateSubjectLesson(Subject[] subjects)
        {
            Console.WriteLine("Nhập mã môn học: ");
            var subjectId = int.Parse(Console.ReadLine());
            var subjectIndex = FindSubjectIndexById(subjects, subjectId, subjects.Length);
            if (subjectIndex == -1)
            {
                Console.WriteLine("==> Không tồn tại môn học cần cập nhật. <==");
            }
            else
            {
                Console.WriteLine("==> Bạn có chắc chắn muốn cập nhật?(Y/N) ");
                var ans = Console.ReadLine()[0];
                if (ans == 'Y' || ans == 'y')
                {
                    Console.WriteLine("Số tiết học: ");
                    var lesson = int.Parse(Console.ReadLine());
                    subjects[subjectIndex].NumOfLesson = lesson;
                    Console.WriteLine("==> Cập nhật thành công. <==");
                }
                else
                {
                    Console.WriteLine("==> Cập nhật bị hủy. <==");
                }
            }
        }

        // cập nhật thông tin sinh viên khi biết mã sinh viên
        private static void UpdateStudentInfo(Student[] students)
        {
            Console.WriteLine("Nhập mã sinh viên: ");
            var studentId = Console.ReadLine().ToUpper(); // viết hoa mã sinh viên
            var index = FindStudentIndexById(students, studentId, students.Length);
            if (index == -1)
            {
                Console.WriteLine("==> Không tồn tại sinh viên cần cập nhật. <==");
            }
            else
            {
                Console.WriteLine("==> Bạn có chắc chắn muốn cập nhật?(Y/N) ");
                var ans = Console.ReadLine()[0];
                if (ans == 'Y' || ans == 'y')
                {
                    Console.WriteLine("Họ và tên: ");
                    var name = Console.ReadLine();
                    students[index].FullName = new FullName(name);
                    Console.WriteLine("==> Cập nhật thành công. <==");
                }
                else
                {
                    Console.WriteLine("==> Cập nhật bị hủy. <==");
                }
            }
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
                    Console.WriteLine($"==> Môn học mã \"{idToRemove}\" đã được xóa khỏi danh sách. <==");
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
                    Console.WriteLine($"==> Sinh viên mã \"{idToRemove}\" đã được xóa khỏi danh sách. <==");
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
                    Console.WriteLine($"==> Bản ghi mã \"{idToRemove}\" đã được xóa khỏi danh sách. <==");
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

        public override int GetHashCode()
        {
            return 610864741 + EqualityComparer<string>.Default.GetHashCode(StudentId);
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
            SetFullName(fullName);
        }

        public FullName(string firstName, string lastName, string midName)
        {
            FirstName = firstName;
            LastName = lastName;
            MidName = midName;
        }

        public void SetFullName(string fullName)
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
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

        public Register(int id, Student student, Subject subject, DateTime registerTime) : this(id)
        {
            Student = student;
            Subject = subject;
            RegisterTime = registerTime;
        }

        public override bool Equals(object obj)
        {
            return obj is Register register &&
                   EqualityComparer<Student>.Default.Equals(Student, register.Student) &&
                   EqualityComparer<Subject>.Default.Equals(Subject, register.Subject);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
