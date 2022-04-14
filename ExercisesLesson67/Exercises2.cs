///
///<author>Branium Academy</author>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.04.13</version>
///
using System;

namespace ExercisesLesson67
{
    public class Exercises2
    {
        static void Main()
        {
            Student[] students = new Student[100];
            int studentSize = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("=============== CÁC CHỨC NĂNG ===============");
                Console.WriteLine("1. Thêm mới một record.");
                Console.WriteLine("2. Hiển thị danh sách record ra màn hình.");
                Console.WriteLine("3. Sắp xếp các record theo điểm giảm dần.");
                Console.WriteLine("4. Tìm record theo chuyên ngành.");
                Console.WriteLine("5. Xóa record khỏi mảng.");
                Console.WriteLine("6. Kết thúc chương trình.");
                Console.WriteLine("Xin mời chọn: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var student = CreateStudent();
                        students[studentSize++] = student;
                        break;
                    case 2:
                        if (studentSize > 0)
                        {
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng. <==");
                        }
                        break;
                    case 3:
                        if (studentSize > 0)
                        {
                            Console.WriteLine("==> Danh sách sinh viên sau khi sắp xếp <==");
                            Sort(students, studentSize);
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng. <==");
                        }
                        break;
                    case 4:
                        if (studentSize > 0)
                        {
                            Console.WriteLine("Nhập chuyên ngành cần tìm: ");
                            var major = Console.ReadLine();
                            var result = FindByMajor(students, major);
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Không có kết quả tìm kiếm <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: <==");
                                ShowStudents(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng. <==");
                        }
                        break;
                    case 5:
                        if (studentSize > 0)
                        {
                            Console.WriteLine("Nhập mã sinh viên cần xóa: ");
                            var id = Console.ReadLine();
                            var result = Remove(students, id);
                            if (result)
                            {
                                Console.WriteLine("==> Xóa thành công. <==");
                                studentSize--;
                            }
                            else
                            {
                                Console.WriteLine("==> Xóa thất bại. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách sinh viên rỗng. <==");
                        }
                        break;
                    case 6:
                        Console.WriteLine("==> Chương trình kết thúc. <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 6);
        }

        // phương thức tìm record theo chuyên ngành
        static Student[] FindByMajor(Student[] students, string major)
        {
            var resultSize = 0;
            var result = new Student[students.Length];
            foreach (var item in students)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Major.CompareTo(major) == 0)
                {
                    result[resultSize++] = item;
                }
            }
            return result;
        }

        // phương thức xóa record theo mã sinh viên
        static bool Remove(Student[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    break;
                }
                // nếu tìm thấy sinh viên với mã cần xóa, tiến hành
                // dồn tất cả các phần tử bên tay phải vị trí i sang trái 1 vị trí
                if (students[i].Id.CompareTo(id) == 0)
                {
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    return true; // xóa thành công
                }
            }
            return false;
        }

        // phương thức sắp xếp danh sách các record theo điểm giảm dần
        static void Sort(Student[] students, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (students[j].Gpa > students[j - 1].Gpa)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức tạo mới record sinh viên
        static Student CreateStudent()
        {
            Console.WriteLine("Mã sinh viên: ");
            var id = Console.ReadLine();
            Console.WriteLine("Họ tên: ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Điểm TB: ");
            var gpa = float.Parse(Console.ReadLine()!); // dấu ! ở cuối để đảm bảo giá trị không null
            // tham khao: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
            Console.WriteLine("Chuyên ngành: ");
            var major = Console.ReadLine();
            return new Student() { Id = id!, FullName = fullName!, Gpa = gpa, Major = major! };
        }

        // phương thức hiển thị thông tin sinh viên
        static void ShowStudents(Student[] students)
        {
            var titleId = "Mã SV";
            var titleName = "Họ và tên";
            var titleGpa = "Điểm TB";
            var titleMajor = "Chuyên ngành";
            Console.WriteLine($"{titleId,-15:d}{titleName,-25:d}{titleGpa,-12:d}{titleMajor,-25:d}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-15:d}{item.FullName,-25:d}" +
                        $"{Math.Round(item.Gpa, 2) + "",-12:d}{item.Major,-25:d}");
                }
            }
        }
    }

    public record Student
    {
        public string Id { get; init; } = default!;
        public string FullName { get; init; } = default!;
        public float Gpa { get; init; } = default;
        public string Major { get; init; } = default!;
    };
}
