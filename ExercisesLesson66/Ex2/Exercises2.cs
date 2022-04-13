///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.04.13</version>
///</resultmary>

using System;

namespace ExercisesLesson66
{
    static class StudentUtils
    {
        class Pair
        {
            public int Occurrent { get; set; }
            public string StudentAddress { get; set; }
        }

        // liệt kê số lượng sinh viên từng tỉnh
        public static void Statistic(Student[] students)
        {
            bool Existed(string city, int pos)
            {
                for (int i = 0; i < pos; i++)
                {
                    if (students[i].StudentAddress.City.CompareTo(city) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            int CountStudent(string city)
            {
                int count = 0;
                foreach (var item in students)
                {
                    if (item != null && item.StudentAddress.City.CompareTo(city) == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            Pair[] result = new Pair[students.Length];
            var resultSize = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (!Existed(students[i].StudentAddress.City, i))
                    {
                        result[resultSize] = new Pair();
                        result[resultSize].StudentAddress = students[i].StudentAddress.City;
                        result[resultSize].Occurrent = CountStudent(students[i].StudentAddress.City);
                        resultSize++;
                    }
                }
            }
            // tạo mảng kết quả sau cùng có vừa đủ các phần tử khác null đã lọc được
            // sau đó chép các phần tử sang
            // mục đích để gọi phương thức sắp xếp của lớp Array cho tiện
            var finalResult = new Pair[resultSize];
            Array.Copy(result, finalResult, resultSize);
            // sắp xếp
            Array.Sort(finalResult, (p1, p2) => p2.Occurrent - p1.Occurrent);
            // hiện kết quả
            for (int i = 0; i < resultSize; i++)
            {
                Console.WriteLine($"{finalResult[i].StudentAddress}: {finalResult[i].Occurrent}");
            }
        }

        // sửa điểm môn lập trình cho sinh viên theo mã sinh viên
        public static bool EditGpa(Student[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].StudentId.CompareTo(id) == 0)
                {
                    Console.WriteLine("Nhập điểm: ");
                    var newMark = float.Parse(Console.ReadLine());
                    students[i].StudentMark.Programming = newMark;
                    return true; // cập nhật thành công
                }
            }
            return false;
        }

        // xóa sinh viên theo mã sinh viên
        public static bool Remove(Student[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].StudentId.CompareTo(id) == 0)
                {
                    students[i] = null;
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    return true; // xóa thành công
                }
            }
            return false; // xóa thất bại
        }

        // tìm sinh viên theo địa chỉ
        public static Student[] FindByAddress(Student[] students, string city)
        {
            var result = new Student[students.Length];
            int resultSize = 0;
            foreach (var item in students)
            {
                if (item != null)
                {
                    if (item.StudentAddress.City.ToLower().CompareTo(city.ToLower()) == 0)
                    {
                        result[resultSize++] = item;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        // tìm sinh viên theo tên
        public static Student[] FindByName(Student[] students, string name)
        {
            var result = new Student[students.Length];
            int resultSize = 0;
            foreach (var item in students)
            {
                if (item != null)
                {
                    if (item.StudentName.FirstName.ToLower().CompareTo(name.ToLower()) == 0)
                    {
                        result[resultSize++] = item;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        // sắp xếp theo tên tăng dần và điểm giảm dần
        public static void SortByNameAndGpa(Student[] students, int size)
        {
            int Comparer(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.StudentMark.Gpa - s2.StudentMark.Gpa != 0)
                {
                    if (s2.StudentMark.Gpa > s1.StudentMark.Gpa)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return s1.StudentName.FirstName.CompareTo(s2.StudentName.FirstName);
                }
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Comparer(students[j - 1], students[j]) > 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // sắp xếp theo tên sinh viên tăng dần
        public static void SortByName(Student[] students, int size)
        {
            int Comparer(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                return s1.StudentName.FirstName.CompareTo(s2.StudentName.FirstName);
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Comparer(students[j - 1], students[j]) > 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // sắp xếp theo điểm TB giảm dần
        public static void SortByGpa(Student[] students, int size)
        {
            int Comparer(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s2.StudentMark.Gpa > s1.StudentMark.Gpa)
                {
                    return 1;
                }
                else if (s2.StudentMark.Gpa < s1.StudentMark.Gpa)
                {
                    return -1;
                }
                return 0;
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Comparer(students[j - 1], students[j]) > 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức hiển thị thông tin sinh viên trong danh sách
        public static void ShowStudents(Student[] students)
        {
            var titleId = "Mã SV";
            var titleFullName = "Họ Tên";
            var titleAddress = "Địa Chỉ";
            var titleGpa = "Điểm TB";
            var titleMajor = "Chuyên Ngành";
            Console.WriteLine($"{titleId,-15:d}{titleFullName,-25:d}{titleAddress,-15:d}" +
                        $"{titleGpa,-10:d}{titleMajor,-20:d}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.StudentId,-15:d}{item.StudentName,-25:d}" +
                        $"{item.StudentAddress,-15:d}{Math.Round(item.StudentMark.Gpa, 2) + "",-10:d}" +
                        $"{item.Major,-20:d}");
                }
                else
                {
                    break;
                }
            }
        }

        // phương thức tạo đối tượng sinh viên mới
        public static Student CreateStudent()
        {
            Console.WriteLine("Họ và tên: ");
            var fullName = Console.ReadLine().Split(' ');
            Console.WriteLine("Địa chỉ(tỉnh, thành phố):");
            var city = Console.ReadLine();
            var address = new Student.Address(null, null, city);
            // nhập điểm
            Console.WriteLine("Điểm Toán: ");
            var math = float.Parse(Console.ReadLine());
            Console.WriteLine("Điểm Tiếng Anh: ");
            var english = float.Parse(Console.ReadLine());
            Console.WriteLine("Điểm Lập Trình: ");
            var programming = float.Parse(Console.ReadLine());
            var mark = new Student.Mark(math, english, programming);
            // nhập chuyên ngành
            Console.WriteLine("Chuyên ngành: ");
            var major = Console.ReadLine();
            var midName = "";
            for (int i = 1; i < fullName.Length - 1; i++)
            {
                midName += fullName[i] + " ";
            }
            var name = new Student.FullName(fullName[fullName.Length - 1],
                fullName[0], midName.Trim());
            return new Student(null, name, address, mark, major);
        }
    }
    class Exercises2
    {
        static void Main()
        {
            // cho phép hiển thị tiếng Việt trên màn hình output
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // lưu ý màn hình console không hỗ trợ nhập liệu bằng tiếng Việt

            int choice;
            Student[] students = new Student[100];
            int size = 0;
            do
            {
                Console.WriteLine("++++++++++++++++++++ CÁC CHỨC NĂNG ++++++++++++++++++++");
                Console.WriteLine("| 01. Thêm mới sinh viên vào danh sách.               |");
                Console.WriteLine("| 02. Hiển thị danh sách sinh viên.                   |");
                Console.WriteLine("| 03. Sắp xếp danh sách sinh viên theo điểm giảm dần. |");
                Console.WriteLine("| 04. Sắp xếp danh sách sinh viên theo tên tăng dần.  |");
                Console.WriteLine("| 05. Sắp xếp danh sách sinh viên theo điểm và tên.   |");
                Console.WriteLine("| 06. Tìm sinh viên theo tên.                         |");
                Console.WriteLine("| 07. Tìm sinh viên theo tỉnh.                        |");
                Console.WriteLine("| 08. Xóa sinh viên cho trước khi biết mã sinh viên.  |");
                Console.WriteLine("| 09. Liệt kê số lượng sinh viên theo tỉnh.           |");
                Console.WriteLine("| 10. Sửa điểm lập trình cho sinh viên theo mã SV.    |");
                Console.WriteLine("| 11. Kết thúc chương trình.                          |");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Xin mời bạn chọn chức năng(1-11): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var student = StudentUtils.CreateStudent();
                        students[size++] = student;
                        break;
                    case 2:
                        if (size > 0)
                        {
                            StudentUtils.ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            StudentUtils.SortByGpa(students, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            StudentUtils.SortByName(students, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            StudentUtils.SortByNameAndGpa(students, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            Console.WriteLine("Tên cần tìm: ");
                            var firstName = Console.ReadLine();
                            var result = StudentUtils.FindByName(students, firstName);
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Không có kết quả. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: ");
                                StudentUtils.ShowStudents(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 7:
                        if (size > 0)
                        {
                            Console.WriteLine("Tên thành phố cần tìm: ");
                            var city = Console.ReadLine();
                            var result = StudentUtils.FindByAddress(students, city);
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Không có kết quả. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: ");
                                StudentUtils.ShowStudents(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 8:
                        if (size > 0)
                        {
                            Console.WriteLine("Mã sinh viên cần xóa: ");
                            var id = Console.ReadLine();
                            var result = StudentUtils.Remove(students, id);
                            if (!result)
                            {
                                Console.WriteLine("==> Xóa thất bại! <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Xóa thành công! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 9:
                        if (size > 0)
                        {
                            StudentUtils.Statistic(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 10:
                        if (size > 0)
                        {
                            Console.WriteLine("Mã sinh viên cần sửa điểm: ");
                            var id = Console.ReadLine();
                            var result = StudentUtils.EditGpa(students, id);
                            if (!result)
                            {
                                Console.WriteLine("==> Cập nhật điểm thất bại. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Cập nhật điểm thành công! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên trống <==");
                        }
                        break;
                    case 11:
                        Console.WriteLine("==> Xin cảm ơn và hẹn gặp lại! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại!");
                        break;
                }
            } while (choice != 11);
        }
    }
}
