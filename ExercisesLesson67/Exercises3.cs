using System;

namespace ExercisesLesson67
{
    class Exercises3
    {
        static void Main()
        {
            Employee[] students = new Employee[100];
            int studentSize = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("=================== CÁC CHỨC NĂNG ===================");
                Console.WriteLine("1. Thêm mới một record.");
                Console.WriteLine("2. Hiển thị danh sách record ra màn hình.");
                Console.WriteLine("3. Sắp xếp các record theo lương giảm dần.");
                Console.WriteLine("4. Sắp xếp các record theo mức phạt giảm dần.");
                Console.WriteLine("5. Sắp xếp các record theo lương thực lĩnh giảm dần.");
                Console.WriteLine("6. Tìm record theo mã nhân viên.");
                Console.WriteLine("7. Xóa record khỏi mảng.");
                Console.WriteLine("8. Kết thúc chương trình.");
                Console.WriteLine("Xin mời chọn: ");
                choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        var employee = CreateEmployee();
                        students[studentSize++] = student;
                        break;
                    case 2:
                        if (studentSize > 0)
                        {
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 3:
                        if (studentSize > 0)
                        {
                            Console.WriteLine("==> Danh sách nhân viên sau khi sắp xếp <==");
                            Sort(students, studentSize);
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
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
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 5:
                        if (studentSize > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần xóa: ");
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
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:
                        Console.WriteLine("==> Chương trình kết thúc. <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 8);
        }
        // phương thức tìm record theo chuyên ngành
        static Employee[] FindByMajor(Employee[] students, string major)
        {
            var resultSize = 0;
            var result = new Employee[students.Length];
            foreach (var item in students)
            {
                if (item != null && item.Major.CompareTo(major) == 0)
                {
                    result[resultSize++] = item;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        // phương thức xóa record theo mã nhân viên
        static bool Remove(Employee[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    break;
                }
                // nếu tìm thấy nhân viên với mã cần xóa, tiến hành
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
        static void Sort(Employee[] students, int size)
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

        // phương thức tạo mới record nhân viên
        static Employee CreateEmployee()
        {
            Console.WriteLine("Mã nhân viên: ");
            var id = Console.ReadLine();
            Console.WriteLine("Họ tên: ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Số ngày làm việc thực tế: ");
            var workingDay = float.Parse(Console.ReadLine()!); // dấu ! ở cuối để đảm bảo giá trị trước nó không null
            // tham khao: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
            Console.WriteLine("Mức lương: ");
            var salary = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Số ngày đi làm muộn: ");
            var lateDay = int.Parse(Console.ReadLine()!);
            return new Employee(id!, fullName!, workingDay, salary, lateDay);
        }

        // phương thức hiển thị thông tin nhân viên
        static void ShowStudents(Employee[] students)
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

    public record Employee(string Id, string FullName, float WorkingDay, float Salary, int LateDay)
    {
        public float Fine => 50000 * LateDay; // tiền phạt
        public float TempSalary => Salary * WorkingDay / 22; // lương tạm tính
        public float RealSalary => TempSalary - Fine; // lương thực tế
    }
}
