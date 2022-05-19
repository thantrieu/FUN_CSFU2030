/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.19</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Text;

namespace ExercisesLesson69
{
    class Exercises3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Subject[] subjects = new Subject[100];
            Student[] students = new Student[100];
            Course[] courses = new Course[100];
            int numOfCourse = 0; // số lượng các lớp học
            int numOfStudent = 0; // số lượng các sinh viên
            int numOfSubject = 0; // số lượng các môn học
            CreateFakeStudents(students, ref numOfStudent);
            CreateFakeSubjects(students, ref numOfSubject);
            CreateFakeCourses(students, ref numOfCourse);

            int choice;
            do
            {
                Console.WriteLine("======================= CÁC CHỨC NĂNG =======================");
                Console.WriteLine("01. Thêm mới sinh viên vào danh sách.");
                Console.WriteLine("02. Thêm mới môn học vào danh sách.");
                Console.WriteLine("03. Thêm mới lớp học phần vào danh sách.");
                Console.WriteLine("04. Nhập bảng điểm cho sinh viên trong một lớp.");
                Console.WriteLine("05. Hiển thị danh sách sinh viên ra màn hình.");
                Console.WriteLine("06. Hiển thị danh sách môn học ra màn hình.");
                Console.WriteLine("07. Hiển thị danh sách bảng điểm của từng lớp học phần.");
                Console.WriteLine("08. Sắp xếp danh sách sinh viên theo tên tăng dần.");
                Console.WriteLine("09. Tìm sinh viên theo mã sinh viên cho trước.");
                Console.WriteLine("10. Xóa sinh viên theo mã cho trước khỏi danh sách.");
                Console.WriteLine("11. Sắp xếp danh sách bảng điểm của một lớp học phần.");
                Console.WriteLine("12. Liệt kê số lượng các sinh viên có điểm TB loại giỏi.");
                Console.WriteLine("13. Liệt kê số lượng sinh viên trượt môn trong từng lớp.");
                Console.WriteLine("14. Sửa điểm cho sinh viên theo mã lớp và mã sinh viên.");
                Console.WriteLine("15. Tìm các sinh viên có điểm TB >= x nhập vào từ bàn phím.");
                Console.WriteLine("16. Xóa bảng điểm của sinh viên x trong lớp học phần p nào đó.");
                Console.WriteLine("17. Thoát chương trình.");
                Console.WriteLine("==> Xin mời bạn chọn 1 chức năng: ");
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
                        var subject = CreateSubject();
                        if (subject != null)
                        {
                            subjects[numOfSubject++] = subject;
                        }
                        break;
                    case 3:
                        var course = CreateCourse(subjects);
                        if (course != null)
                        {
                            courses[numOfCourse++] = course;
                        }
                        break;
                    case 4:
                        if (numOfCourse > 0)
                        {
                            FillTranscript(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfCourse > 0)
                        {
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfCourse > 0)
                        {
                            ShowSubjects(subjects);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách môn học rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfCourse > 0)
                        {
                            ShowTranscript(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfCourse > 0)
                        {
                            SortStudentsByName(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 9:
                        if (numOfCourse > 0)
                        {
                            var student = FindStudentById(students);
                            if (student != null)
                            {

                            }
                            else
                            {
                                Console.WriteLine("==> Không tìm thấy sinh viên cần tìm. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 10:
                        if (numOfCourse > 0)
                        {
                            RemoveStudentById(students, ref numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 11:
                        if (numOfCourse > 0)
                        {
                            SortTranscripts(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 12:
                        if (numOfCourse > 0)
                        {
                            GoodStudents(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 13:
                        if (numOfCourse > 0)
                        {
                            FailedStudents(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 14:
                        if (numOfCourse > 0)
                        {
                            UpdateGrade(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 15:
                        if (numOfCourse > 0)
                        {
                            var result = FindStudentByGpa(courses);
                            if (result[0] != null)
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 16:
                        if (numOfCourse > 0)
                        {
                            RemoveTranscript(courses);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách lớp học phần rỗng <==");
                        }
                        break;
                    case 17:
                        Console.WriteLine("==> Cảm ơn quý khách đã sử dụng dịch vụ! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 17);
        }

        private static void FillTranscript(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static void ShowStudents(Student[] students)
        {
            throw new NotImplementedException();
        }

        private static void ShowSubjects(Subject[] subjects)
        {
            throw new NotImplementedException();
        }

        private static void ShowTranscript(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static void SortStudentsByName(Student[] students)
        {
            throw new NotImplementedException();
        }

        private static object FindStudentById(Student[] students)
        {
            throw new NotImplementedException();
        }

        private static void RemoveStudentById(Student[] students, ref int numOfStudent)
        {
            throw new NotImplementedException();
        }

        private static void SortTranscripts(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static void GoodStudents(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static void FailedStudents(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static void UpdateGrade(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static Transcript[] FindStudentByGpa(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static void RemoveTranscript(Course[] courses)
        {
            throw new NotImplementedException();
        }

        private static Student CreateStudent()
        {
            throw new NotImplementedException();
        }

        private static Subject CreateSubject()
        {
            throw new NotImplementedException();
        }

        private static Course CreateCourse(Subject[] subjects)
        {
            throw new NotImplementedException();
        }

        private static void CreateFakeCourses(Student[] students, ref int numOfCourse)
        {
            throw new NotImplementedException();
        }

        private static void CreateFakeSubjects(Student[] students, ref int numOfSubject)
        {
            throw new NotImplementedException();
        }

        private static void CreateFakeStudents(Student[] students, ref int numOfStudent)
        {
            throw new NotImplementedException();
        }
    }

    // lớp mô tả thông tin người
    class Person
    {
        public FullName FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string fullName, string address, int age)
        {
            FullName = new FullName(fullName);
            Address = address;
            Age = age;
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

    // lớp mô tả thông tin sinh viên
    class Student : Person
    {
        private static int autoId = 1000;

        public string StudentId { get; set; }
        public string Major { get; set; }

        public Student() { }
        public Student(string studentId)
        {
            StudentId = studentId == null ? $"ST{autoId++}" : studentId;
        }

        public Student(string fullName, string address, int age, string studentId, string major) : this(studentId)
        {
            FullName = new FullName(fullName);
            Major = major;
            Address = address;
            Age = age;
            Major = major;
        }
    }

    // lớp mô tả thông tin môn học
    class Subject
    {
        private static int autoId = 1000;
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Credit { get; set; }
        public Subject() { }

        public Subject(int id)
        {
            SubjectId = id == 0 ? autoId++ : id;
        }

        public Subject(int id, string name, int credit) : this(id)
        {
            SubjectName = name;
            Credit = credit;
        }
    }

    // lớp mô tả thông tin lớp học phần
    class Course
    {
        private int autoId = 10000;
        public int CourseId { get; set; }
        public Subject Subject { get; set; }
        public string Teacher { get; set; } // người dạy
        public int NumberOfStudent { get; set; }
        public Transcript[] Transcripts { get; set; }

        public Course() { }

        public Course(int id)
        {
            CourseId = id == 0 ? autoId++ : id;
        }

        public Course(int id, Subject subject, string teacher, int numberOfStudent) : this(id)
        {
            Teacher = teacher;
            Subject = subject;
            NumberOfStudent = numberOfStudent;
            Transcripts = new Transcript[numberOfStudent];
        }
    }

    // lớp mô tả thông tin bảng điểm
    class Transcript
    {
        private int autoId = 1000;
        public int TranscriptId { get; set; }
        public Student Student { get; set; }
        public float GradeLevel1 { get; set; }
        public float GradeLevel2 { get; set; }
        public float GradeLevel3 { get; set; }
        public float Gpa { get; set; }

        public Transcript()
        {

        }

        public Transcript(int id)
        {
            TranscriptId = id == 0 ? autoId++ : id;
        }

        public Transcript(int id, Student s, float g1, float g2, float g3, float g4) : this(id)
        {
            Student = s;
            GradeLevel1 = g1;
            GradeLevel2 = g2;
            GradeLevel3 = g3;
            Gpa = g4;
        }

        public void CalculateGpa()
        {
            var gpa = 0.1f * GradeLevel1 + 0.3f * GradeLevel2 + 0.6f * GradeLevel3;
            Gpa = (float)Math.Round(gpa, 2);
        }
    }
}
