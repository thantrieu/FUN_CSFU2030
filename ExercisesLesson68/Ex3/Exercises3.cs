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
            int numOfStudent = 0; // số lượng sinh viên
            CreateFakeData(students, ref numOfStudent);
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
                        var student = CreateStudent();
                        if (student != null)
                        {
                            students[numOfStudent++] = student;
                        }
                        break;
                    case 2:
                        if (numOfStudent > 0)
                        {
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 3:
                        if (numOfStudent > 0)
                        {
                            int comparer(Student s1, Student s2)
                            {
                                if (s1 == null && s2 == null)
                                {
                                    return 0;
                                }
                                else if (s1 != null && s2 == null)
                                {
                                    return -1;
                                }
                                else if (s1 == null && s2 != null)
                                {
                                    return 1; // đổi chỗ, đưa s2 ra trước s1
                                }
                                var diff = s1.Gpa - s2.Gpa;
                                if (diff > 0)
                                {
                                    return -1;
                                }
                                else if (diff < 0)
                                {
                                    return 1; // s1 có điểm thấp hơn s2, đổi chỗ s1 với s2
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                            Array.Sort(students, comparer);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 4:
                        if (numOfStudent > 0)
                        {
                            int comparer(Student s1, Student s2)
                            {
                                if (s1 == null && s2 == null)
                                {
                                    return 0;
                                }
                                else if (s1 != null && s2 == null)
                                {
                                    return -1;
                                }
                                else if (s1 == null && s2 != null)
                                {
                                    return 1; // đổi chỗ, đưa s2 ra trước s1
                                }
                                // nếu tên của s1 đứng sau thì kết quả dương => xảy ra đổi chỗ s1 vs s2
                                return s1.FirstName.CompareTo(s2.FirstName);
                            }
                            Array.Sort(students, comparer);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfStudent > 0)
                        {
                            int comparer(Student s1, Student s2)
                            {
                                if (s1 == null && s2 == null)
                                {
                                    return 0;
                                }
                                else if (s1 != null && s2 == null)
                                {
                                    return -1;
                                }
                                else if (s1 == null && s2 != null)
                                {
                                    return 1; // đổi chỗ, đưa s2 ra trước s1
                                }
                                var diff = s1.Gpa - s2.Gpa;
                                if (diff > 0)
                                {
                                    return -1;
                                }
                                else if (diff < 0)
                                {
                                    return 1; // s1 có điểm thấp hơn s2, đổi chỗ s1 với s2
                                }
                                else
                                {
                                    // nếu điểm bằng nhau, xét đến tên hai sinh viên s1, s2
                                    // nếu tên của s1 đứng sau thì kết quả dương => xảy ra đổi chỗ s1 vs s2
                                    var nameCompare = s1.FirstName.CompareTo(s2.FirstName);
                                    if (nameCompare != 0)
                                    {
                                        return nameCompare;
                                    }
                                    else
                                    {
                                        // nếu điểm và tên trùng nhau, xét đến họ của hai sinh viên
                                        // họ đứng trước trong bảng chữ cái sẽ được xếp trước trong danh sách
                                        // ví dụ Lê -> Nguyễn -> Trần -> Trương -> Võ...
                                        return s1.LastName.CompareTo(s2.LastName);
                                    }
                                }

                            }
                            Array.Sort(students, comparer);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfStudent > 0)
                        {
                            var result = FindByName(students);
                            if (result[0] != null)
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: ");
                                ShowStudents(result);
                            }
                            else
                            {
                                Console.WriteLine("==> Không tồn tại sinh viên cần tìm. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfStudent > 0)
                        {
                            var result = FindByAddress(students);
                            if (result[0] != null)
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: ");
                                ShowStudents(result);
                            }
                            else
                            {
                                Console.WriteLine("==> Không tồn tại sinh viên cần tìm. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfStudent > 0)
                        {
                            var result = RemoveStudent(students, ref numOfStudent);
                            if (result)
                            {
                                Console.WriteLine("==> Xóa thành công. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Xóa thất bại. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 9:
                        if (numOfStudent > 0)
                        {
                            StatisticByCity(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 10:
                        if (numOfStudent > 0)
                        {
                            StatisticByGpa(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng <==");
                        }
                        break;
                    case 11:
                        if (numOfStudent > 0)
                        {
                            UpdateGpa(students);
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
            } while (choice != 12);
        }

        // tạo danh sách sinh viên fake để test các chức năng trong chương trình
        private static void CreateFakeData(Student[] students, ref int numOfStudent)
        {
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Tran Van Nam", "Ha Noi", 3.25f, "CNTT", 450, 50, 4);
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Le Van Nam", "Ha Noi", 3.25f, "CNTT", 450, 58, 2);
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Hoang Van Nam", "Ha Noi", 3.25f, "CNTT", 450, 90, 4);
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Ngo Thuy Anh", "Thanh Hoa", 3.65f, "CNTT", 460, 40, 0);
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Mai Duc Trung", "Da Nang", 3.27f, "CNTT", 480, 60, 8);
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Luu Viet Hoang", "Ha Nam", 3.25f, "CNTT", 650, 70, 6);
            students[numOfStudent++] = new UnderGraduatedStudent(null, "Luu Thi Ha", "Thai Nguyen", 3.75f, "CNTT", 680, 74, 5);
            students[numOfStudent++] = new GraduatedStudent(null, "Khuat Tien Lam", "Ca Mau", 3.29f, "CNTT", 18500, 2020, "Gioi");
            students[numOfStudent++] = new GraduatedStudent(null, "Nguyen The Tung", "Da Nang", 3.75f, "CNTT", 21620, 2021, "Xuat Sac");
            students[numOfStudent++] = new GraduatedStudent(null, "Nguyen Thi Loan", "Da Nang", 3.35f, "CNTT", 24600, 2021, "Gioi");
            students[numOfStudent++] = new GraduatedStudent(null, "Le Kim Tuan", "Binh Duong", 3.15f, "CNTT", 25600, 2022, "Kha");
            students[numOfStudent++] = new GraduatedStudent(null, "Tran Ngoc Tuan", "Binh Duong", 3.65f, "CNTT", 28600, 2020, "Xuat Sac");
            students[numOfStudent++] = new GraduatedStudent(null, "Nguyen Hoang Tuan", "Binh Duong", 3.85f, "CNTT", 29400, 2020, "Xuat Sac");
        }

        // tìm sinh viên theo mã sinh viên
        private static Student FindStudentById(Student[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].StudentId.CompareTo(id) == 0)
                {
                    return students[i];
                }
            }
            return null;
        }

        // cập nhật điểm trung bình cho sinh viên
        private static void UpdateGpa(Student[] students)
        {
            Console.WriteLine("Nhập mã sinh viên cần sửa điểm: ");
            var id = Console.ReadLine();
            Console.WriteLine("Nhập điểm: ");
            var newGpa = float.Parse(Console.ReadLine());
            var student = FindStudentById(students, id);
            if (student != null)
            {
                student.Gpa = newGpa;
                Console.WriteLine("==> Cập nhật điểm thành công. <==");
            }
            else
            {
                Console.WriteLine("==> Không tìm thấy sinh viên. Cập nhật điểm thất bại. <==");
            }
        }

        // tìm chỉ số một đối tượng theo thành phố
        private static int CityIndex(StudentInCity[] data, string city)
        {
            for (int i = 0; i < data.Length; i++)
            {
                var obj = data[i];
                if (obj.City != null && obj.City.CompareTo(city) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // tìm chỉ số một đối tượng theo điểm TB
        private static int GpaIndex(StudentHaveGpa[] data, float gpa)
        {
            for (int i = 0; i < data.Length; i++)
            {
                var obj = data[i];
                if (obj.Gpa == gpa)
                {
                    return i;
                }
            }
            return -1;
        }

        // thống kê danh sách sinh viên theo tỉnh/thành phố
        private static void StatisticByCity(Student[] students)
        {
            StudentInCity[] statistic = new StudentInCity[students.Length];
            var numOfResult = 0;
            for (var i = 0; i < students.Length; i++)
            {
                var student = students[i];
                if (student == null)
                {
                    break;
                }
                var index = CityIndex(statistic, student.Address);
                if (index > -1) // nếu thành phố cần xét đã tồn tại trong danh sách
                {
                    statistic[index].NumberOfStudent++; // tăng biến đếm số sv tại thành phố đó lên
                }
                else
                {
                    statistic[numOfResult++] = new StudentInCity { City = student.Address, NumberOfStudent = 1 };
                }
            }

            int comparer(StudentInCity s1, StudentInCity s2)
            {
                return s2.NumberOfStudent - s1.NumberOfStudent;
            }
            Array.Sort(statistic, comparer);
            ShowStudentsInCity(statistic);
        }

        // hiển thị danh sách kết quả thống kê theo thành phố
        private static void ShowStudentsInCity(StudentInCity[] result)
        {
            Console.WriteLine("==> Kết quả thống kê số lượng sinh viên theo thành phố: <==");
            foreach (var item in result)
            {
                if (item.NumberOfStudent == 0) // khi không có kết quả thống kê nữa thì dừng in ra
                {
                    break;
                }
                Console.WriteLine($"{item.City} : {item.NumberOfStudent}");
            }
        }

        // hiển thị danh sách kết quả thống kê theo điểm TB
        private static void ShowStudentsHaveGpa(StudentHaveGpa[] result)
        {
            Console.WriteLine("==> Kết quả thống kê số lượng sinh viên theo điểm TB: <==");
            foreach (var item in result)
            {
                if (item.NumberOfStudent == 0) // khi không có kết quả thống kê nữa thì dừng in ra
                {
                    break;
                }
                Console.WriteLine($"{item.Gpa} : {item.NumberOfStudent}");
            }
        }

        // thống kê danh sách sinh viên theo điểm TB
        private static void StatisticByGpa(Student[] students)
        {
            StudentHaveGpa[] result = new StudentHaveGpa[students.Length];
            var numOfResult = 0;
            for (var i = 0; i < students.Length; i++)
            {
                var student = students[i];
                if (student == null)
                {
                    break;
                }
                var index = GpaIndex(result, student.Gpa);
                if (index > -1) // nếu điểm cần xét đã tồn tại trong danh sách
                {
                    result[index].NumberOfStudent++; // tăng biến đếm số sv tại mức điểm TB đó lên
                }
                else
                {
                    result[numOfResult++] = new StudentHaveGpa { Gpa = student.Gpa, NumberOfStudent = 1 };
                }
            }

            int comparer(StudentHaveGpa s1, StudentHaveGpa s2)
            {
                var diff = s2.Gpa - s1.Gpa;
                if (diff > 0)
                {
                    return 1;
                }
                else if (diff < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            Array.Sort(result, comparer);
            ShowStudentsHaveGpa(result);
        }

        // xóa sinh viên theo mã sinh viên
        private static bool RemoveStudent(Student[] students, ref int size)
        {
            Console.WriteLine("Nhập mã sinh viên cần xóa: ");
            var id = Console.ReadLine();
            for (int i = 0; i < size; i++)
            {
                if (students[i] == null)
                {
                    return false;
                }
                if (students[i].StudentId.CompareTo(id) == 0)
                {
                    Console.WriteLine("Bạn có chắc chắn muốn xóa bỏ sinh viên này không(Y/N)?");
                    var ans = Console.ReadLine().ToLower();
                    if (ans[0] == 'y') // đồng ý xóa
                    {
                        for (int j = i; j < size - 1; j++)
                        {
                            students[j] = students[j + 1]; // dồn các sinh viên bên phải sv bị xóa sang trái 1 đơn vị
                        }
                        students[size - 1] = null; // xóa bỏ sinh viên cuối danh sách để tránh trùng lặp
                        size--; // cập nhật số sv hiện có trong danh sách
                        return true; // xóa thành công
                    }
                }
            }
            return false;
        }

        // tìm theo địa chỉ
        private static Student[] FindByAddress(Student[] students)
        {
            Student[] result = new Student[students.Length];
            Console.WriteLine("Nhập tên tỉnh/thành phố cần tìm(không dấu): ");
            var city = Console.ReadLine().ToLower();
            var numOfResult = 0;
            foreach (var item in students)
            {
                if (item != null && item.Address.ToLower().CompareTo(city) == 0)
                {
                    result[numOfResult++] = item;
                }
            }
            return result;
        }

        // tìm sinh viên theo tên
        private static Student[] FindByName(Student[] students)
        {
            Student[] result = new Student[students.Length];
            Console.WriteLine("Nhập tên sinh viên cần tìm(không dấu): ");
            var firstName = Console.ReadLine().ToLower();
            var numOfResult = 0;
            foreach (var item in students)
            {
                if (item != null && item.FirstName.ToLower().CompareTo(firstName) == 0)
                {
                    result[numOfResult++] = item;
                }
            }
            return result;
        }

        // hiển thị danh sách sinh viên
        private static void ShowStudents(Student[] students)
        {
            var id = "Mã SV";
            var name = "Họ và tên";
            var address = "Địa chỉ";
            var gpa = "Điểm TB";
            var major = "Chuyên ngành";
            var salary = "Mức lương";
            var year = "Năm TN";
            var level = "Xếp loại";
            var creditFee = "Học phí";
            var completed = "Số tín xong";
            var incompleted = "Số tín nợ";
            var noData = "_";
            Console.WriteLine($"{id,-10:d}{name,-25:d}" +
                $"{address,-15:d}{gpa,-15:d}{major,-20:d}" +
                $"{salary,-10:d}{year,10:d}{level,15:d}" +
                $"{creditFee,15:d}{completed,15:d}{incompleted,15:d}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    if (item.GetType() == typeof(GraduatedStudent)) // nếu là đối tượng của lớp GraduatedStudent
                    {
                        var student = item as GraduatedStudent;
                        Console.WriteLine($"{student.StudentId,-10:d}{student.FullName,-25:d}" +
                        $"{student.Address,-15:d}{student.Gpa + "",-15:d}{student.Major,-20:d}" +
                        $"{student.Salary,-10:d}{student.GraduatedYear,10:d}{student.Level,15:d}" +
                        $"{noData,15:d}{noData,15:d}{noData,15:d}");
                    }
                    // nếu là đối tượng của lớp UnderGraduatedStudent
                    else if (item.GetType() == typeof(UnderGraduatedStudent))
                    {
                        var student = item as UnderGraduatedStudent;
                        Console.WriteLine($"{student.StudentId,-10:d}{student.FullName,-25:d}" +
                        $"{student.Address,-15:d}{student.Gpa + "",-15:d}{student.Major,-20:d}" +
                        $"{noData,-10:d}{noData,10:d}{noData,15:d}{student.CreditFee,15:d}" +
                        $"{student.NumOfCompletedCredit,15:d}{student.NumOfDebtCredit,15:d}");
                    }

                }
            }
        }

        // tạo đối tượng sinh viên
        private static Student CreateStudent()
        {
            Console.WriteLine("==> Xin mời chọn: ");
            Console.WriteLine("1. Sinh viên chưa tốt nghiệp.");
            Console.WriteLine("2. Sinh viên đã tốt nghiệp.");
            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Họ và tên: ");
            var name = Console.ReadLine();
            Console.WriteLine("Địa chỉ: ");
            var address = Console.ReadLine();
            Console.WriteLine("Điểm: ");
            float gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Chuyên ngành: ");
            var major = Console.ReadLine();
            if (option == 1)
            {
                return CreateUnderGraduatedStudent(null, name, address, gpa, major);
            }
            else if (option == 2)
            {
                return CreateGraduatedStudent(null, name, address, gpa, major);
            }
            return null; // các trường hợp khác trả về kết quả null
        }

        // tạo đối tượng sinh viên chưa tốt nghiệp 
        private static UnderGraduatedStudent CreateUnderGraduatedStudent(
            string id, string name, string address, float gpa, string major)
        {
            Console.WriteLine("Học phí mỗi tín chỉ: ");
            var creditFee = int.Parse(Console.ReadLine());
            Console.WriteLine("Số tín chỉ đã hoàn thành: ");
            var completed = int.Parse(Console.ReadLine());
            Console.WriteLine("Số tín chỉ đang nợ: ");
            var inCompleted = int.Parse(Console.ReadLine());
            var uStudent = new UnderGraduatedStudent(
                id, name, address, gpa, major, creditFee, completed, inCompleted);
            return uStudent;
        }

        // tạo đối tượng sinh viên đã tốt nghiệp
        private static GraduatedStudent CreateGraduatedStudent(
            string id, string name, string address, float gpa, string major)
        {
            Console.WriteLine("Mức lương: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Năm tốt nghiệp: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Xếp loại tốt nghiệp: ");
            string level = Console.ReadLine();
            return new GraduatedStudent(id, name, address, gpa, major, salary, year, level);
        }
    }

    // ghép cặp sinh viên theo thành phố
    struct StudentInCity
    {
        public string City { get; set; }
        public int NumberOfStudent { get; set; }
    }

    // ghép cặp sinh viên với điểm trung bình
    struct StudentHaveGpa
    {
        public float Gpa { get; set; }
        public int NumberOfStudent { get; set; }
    }

    class Student
    {
        private static int autoId = 1000;

        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get => $"{LastName} {MidName} {FirstName}";
            set
            {
                if (value == null) { return; }
                var words = value.Split(' ');
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
            FullName = name;
            Address = address;
            Gpa = gpa;
            Major = major;
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
