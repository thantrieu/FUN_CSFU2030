using System;

namespace ExercisesLesson67
{
    class Exercises3
    {
        static void Main()
        {
            Employee[] employees = new Employee[100];
            int size = 0;
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
                        employees[size++] = employee;
                        break;
                    case 2:
                        if (size > 0)
                        {
                            ShowEmployees(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            Console.WriteLine("==> Danh sách nhân viên sau khi sắp xếp theo lương giảm dần <==");
                            SortBySalary(employees, size);
                            ShowEmployees(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            Console.WriteLine("==> Danh sách nhân viên sau khi sắp xếp theo mức phạt giảm dần <==");
                            SortByFine(employees, size);
                            ShowEmployees(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            Console.WriteLine("==> Danh sách nhân viên sau khi sắp xếp theo lương thực lĩnh giảm dần <==");
                            SortByReceivedSalary(employees, size);
                            ShowEmployees(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần tìm: ");
                            var id = Console.ReadLine();
                            var result = FindById(employees, id!);
                            if (result == null)
                            {
                                Console.WriteLine("==> Không có kết quả tìm kiếm <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Kết quả tìm kiếm: <==");
                                ShowEmployees(new Employee[] { result });
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng. <==");
                        }
                        break;
                    case 7:
                        if (size > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần xóa: ");
                            var id = Console.ReadLine();
                            var result = Remove(employees, id);
                            if (result)
                            {
                                Console.WriteLine("==> Xóa thành công. <==");
                                size--;
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
                    case 8:
                        Console.WriteLine("==> Chương trình kết thúc. <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 8);
        }
        // phương thức tìm record theo mã nhân viên
        static Employee FindById(Employee[] employees, string id)
        {
            foreach (var item in employees)
            {
                if (item != null && item.Id.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        // phương thức xóa record theo mã nhân viên
        static bool Remove(Employee[] employees, string id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    break;
                }
                // nếu tìm thấy nhân viên với mã cần xóa, tiến hành
                // dồn tất cả các phần tử bên tay phải vị trí i sang trái 1 vị trí
                if (employees[i].Id.CompareTo(id) == 0)
                {
                    for (int j = i; j < employees.Length - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    return true; // xóa thành công
                }
            }
            return false;
        }

        // phương thức sắp xếp danh sách các record theo lương giảm dần
        static void SortBySalary(Employee[] employees, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (employees[j].Salary > employees[j - 1].Salary)
                    {
                        var tmp = employees[j];
                        employees[j] = employees[j - 1];
                        employees[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức sắp xếp danh sách các record theo mức phạt giảm dần
        static void SortByFine(Employee[] employees, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (employees[j].Fine > employees[j - 1].Fine)
                    {
                        var tmp = employees[j];
                        employees[j] = employees[j - 1];
                        employees[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức sắp xếp danh sách các record theo tổng lương giảm dần
        static void SortByReceivedSalary(Employee[] employees, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (employees[j].RealSalary > employees[j - 1].RealSalary)
                    {
                        var tmp = employees[j];
                        employees[j] = employees[j - 1];
                        employees[j - 1] = tmp;
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
        static void ShowEmployees(Employee[] employees)
        {
            var titleId = "Mã NV";
            var titleName = "Họ và tên";
            var titleWorkingDay = "Số ngày LV";
            var titleSalary = "Lương";
            var titleLate = "Đi làm muộn";
            var titleFine = "Tiền phạt";
            var titleReSalary = "Lương thực lĩnh";

            Console.WriteLine($"{titleId,-12:d}{titleName,-25:d}{titleWorkingDay,-12:d}" +
                $"{titleSalary,-12:d}{titleLate,-15:d}{titleFine,-12:d}{titleReSalary,-12:d}");
            foreach (var item in employees)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-12:d}{item.FullName,-25:d}" +
                        $"{Math.Round(item.WorkingDay, 2) + "",-12:d}" +
                        $"{Math.Round(item.Salary, 2) + "",-12:d}{item.LateDay,-15:d}" +
                        $"{Math.Round(item.Fine, 2) + "",-12:d}{Math.Round(item.RealSalary, 2) + "",-12:d}");
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
