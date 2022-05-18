/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.18</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Text;

namespace ExercisesLesson68
{
    class Exercises3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] students = new Student[100];
            int numOfAccount = 0; // số lượng sinh viên
            int choice;
            do
            {
                Console.WriteLine("================== CÁC CHỨC NĂNG ==================");
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
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 3:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 4:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 9:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 10:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 11:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 12:
                        Console.WriteLine("==> Cảm ơn quý khách đã sử dụng dịch vụ! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 9);
        }
    }

    class Student
    {
        private static int autoId = 1000;

        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public string Address { get; set; }
        public float Gpa { get; set; }
        public string Major { get; set; }

        public Student() { }

        public Student(string id)
        {
            if (id == null)
            {
                StudentId = $"ST{autoId++}";
            }
            else
            {
                StudentId = id;
            }
        }

        public Student(string id, string name, string address, float gpa, string major) : this(id)
        {
            SetName(name);
            Address = address;
            Gpa = gpa;
            Major = major;
        }

        private void SetName(string name)
        {
            if (name == null) { return; }
            var words = name.Split(' ');
            LastName = words[0];
            FirstName = words[words.Length - 1];
            var midName = "";
            for (int i = 1; i < words.Length - 1; i++)
            {
                midName += words[i] + " ";
            }
            MidName = midName.TrimEnd();
        }
    }

    class GraduatedStudent : Student
    {
        public long Salary { get; set; } // mức lương
        public int GraduatedYear { get; set; } // năm tốt nghiệp
        public string Level { get; set; } // xếp loại tốt nghiệp

        public GraduatedStudent()
        {

        }

        public GraduatedStudent(string id) : base(id) { }
        public GraduatedStudent(string id, string name, string address,
            float gpa, string major, long salary, int year, string level) :
            base(id, name, address, gpa, major)
        {
            Salary = salary;
            GraduatedYear = year;
            Level = level;
        }
    }

    class UnderGraduatedStudent : Student
    {
        public int CreditFee { get; set; } // học phí mỗi tín chỉ
        public int NumOfCompletedCredit { get; set; } // số tín chỉ đã hoàn thành
        public int NumOfDebtCredit { get; set; } // số tín chỉ còn nợ

        public UnderGraduatedStudent() { }
        public UnderGraduatedStudent(string id) : base(id) { }
        public UnderGraduatedStudent(string id, string name, string address,
            float gpa, string major, int fee, int completed, int debt) :
            base(id, name, address, gpa, major)
        {
            CreditFee = fee;
            NumOfCompletedCredit = completed;
            NumOfDebtCredit = debt;
        }
    }
}
