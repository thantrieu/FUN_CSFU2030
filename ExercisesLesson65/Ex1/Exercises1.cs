///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.04.12</version>
///</summary>

using System;

namespace ExercisesLesson65
{
    static class EmployeeUtils
    {
        public static Employee CreateEmployee()
        {
            Console.WriteLine("Họ và tên: ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Số điện thoại: ");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("Chức vụ: ");
            var role = Console.ReadLine();
            Console.WriteLine("Mức lương: ");
            var salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Số ngày làm việc trong tháng: ");
            var workDay = int.Parse(Console.ReadLine());
            return new Employee(null, fullName, phoneNumber, role, salary, workDay);
        }

        // phương thức hiển thị thông tin nhân viên trong danh sách
        public static void DisplayEmployees(Employee[] employees)
        {
            var titleEmpId = "Mã NV";
            var titleFullName = "Họ tên";
            var titlePhoneNumber = "Số ĐT";
            var titleRole = "Chức vụ";
            var titleSalary = "Mức Lương";
            var titleWorkingDay = "Số ngày LV";
            var titleRealSalary = "Lương thực tế";
            Console.WriteLine($"{titleEmpId,-15:d}{titleFullName,-25:d}{titlePhoneNumber,-15:d}" +
                        $"{titleRole,-15:d}{titleSalary,-15:d}{titleWorkingDay,-15:d}" +
                        $"{titleRealSalary,-20:d}");
            foreach (var item in employees)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-15:d}{item.FullName,-25:d}{item.PhoneNumber,-15:d}" +
                        $"{item.Role,-15:d}{Math.Round(item.Salary, 2) + "",-15:d}{item.WorkingDay,-15:d}" +
                        $"{Math.Round(item.ReceivedSalary, 2) + "",-20:d}");
                }
                else
                {
                    break;
                }
            }
        }

        // tính lương các nhân viên trong danh sách
        public static void CalculateSalary(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    employee.CalculateSalary();
                }
            }
        }

        // sắp xếp danh sách nhân viên theo mức lương giảm dần
        public static void SortBySalary(Employee[] employees, int size)
        {
            for (int i = 0; i < size - 1; i++)
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

        // sắp xếp danh sách nhân viên theo số ngày đi làm giảm dần
        public static void SortByWorkingDay(Employee[] employees, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (employees[j].WorkingDay > employees[j - 1].WorkingDay)
                    {
                        var tmp = employees[j];
                        employees[j] = employees[j - 1];
                        employees[j - 1] = tmp;
                    }
                }
            }
        }

        // tìm nhân viên theo mã nhân viên cho trước
        public static Employee FindById(Employee[] employees, string id)
        {
            foreach (var item in employees)
            {
                if (item != null)
                {
                    if (item.Id.CompareTo(id) == 0)
                    {
                        return item;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        // cập nhật mức lương theo mã nhân viên
        public static bool UpdateSalary(Employee[] employees, string id, float salaryToUpdate)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    break; // nếu phần tử thứ i chưa update mà đã null thì thoát vòng lặp
                } // lúc này không có nhân viên nào trùng với mã cho trước để update lương
                if (employees[i].Id.CompareTo(id) == 0)
                {
                    employees[i].Salary = salaryToUpdate;
                    return true;
                }
            }
            return false; // cập nhật thất bại
        }

        // xóa nhân viên theo mã cho trước
        public static bool RemoveById(Employee[] employees, string id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    break;
                }
                if (employees[i].Id.CompareTo(id) == 0)
                {
                    // dồn các nhân viên bên phải nhân viên bị xóa sang trái 1 vị trí
                    for (int j = i; j < employees.Length - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    return true;
                }
            }
            return false;
        }
    }

    class Exercises1
    {
        static void Main()
        {
            // cho phép hiển thị tiếng Việt trên màn hình output
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // lưu ý màn hình console không hỗ trợ nhập liệu bằng tiếng Việt

            int choice;
            Employee[] employees = new Employee[100];
            int size = 0;
            do
            {
                Console.WriteLine("======================== CÁC CHỨC NĂNG =========================");
                Console.WriteLine("= 1. Thêm mới 1 nhân viên vào danh sách.                       =");
                Console.WriteLine("= 2. Hiển thị danh sách nhân viên ra màn hình.                 =");
                Console.WriteLine("= 3. Tính lương cho các nhân viên trong danh sách.             =");
                Console.WriteLine("= 4. Sắp xếp danh sách nhân viên theo lương giảm dần.          =");
                Console.WriteLine("= 5. Sắp xếp danh sách nhân viên theo số ngày đi làm giảm dần. =");
                Console.WriteLine("= 6. Tìm và hiển thị thông tin nhân viên theo mã nhân viên.    =");
                Console.WriteLine("= 7. Cập nhật mức lương cho nhân viên theo mã nhân viên.       =");
                Console.WriteLine("= 8. Xóa bỏ nhân viên theo mã nhân viên.                       =");
                Console.WriteLine("= 9. Kết thúc chương trình.                                    =");
                Console.WriteLine("================================================================");
                Console.WriteLine("Xin mời bạn chọn 1 chức năng(nhập số 1-9): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var acc = EmployeeUtils.CreateEmployee();
                        employees[size++] = acc;
                        break;
                    case 2:
                        if (size > 0)
                        {
                            Console.WriteLine("==> Danh sách nhân viên hiện có: <==");
                            EmployeeUtils.DisplayEmployees(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            EmployeeUtils.CalculateSalary(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            EmployeeUtils.SortBySalary(employees, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            EmployeeUtils.SortByWorkingDay(employees, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần tìm: ");
                            string id = Console.ReadLine();
                            var result = EmployeeUtils.FindById(employees, id);
                            if (result != null)
                            {
                                Console.WriteLine("==> Tìm thấy! Thông tin nhân viên: <==");
                                var resultArr = new Employee[] { result };
                                EmployeeUtils.DisplayEmployees(resultArr);
                            }
                            else
                            {
                                Console.WriteLine("==> Không có kết quả nào phù hợp! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 7:
                        if (size > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần cập nhật lương: ");
                            string id = Console.ReadLine();
                            Console.WriteLine("Nhập mức lương mới: ");
                            var newSalary = float.Parse(Console.ReadLine());
                            var result = EmployeeUtils.UpdateSalary(employees, id, newSalary);
                            if (result)
                            {
                                Console.WriteLine("==> Cập nhật lương thành công! <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Cập nhật lương thất bại! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 8:
                        if (size > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần xóa: ");
                            string id = Console.ReadLine();
                            var result = EmployeeUtils.RemoveById(employees, id);
                            if (result)
                            {
                                Console.WriteLine("==> Xóa thành công! <==");
                                size--;
                            }
                            else
                            {
                                Console.WriteLine("==> Xóa thất bại! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 9:
                        Console.WriteLine("==> Chương trình kết thúc. <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại!");
                        break;
                }
            } while (choice != 9);
        }
    }
}
