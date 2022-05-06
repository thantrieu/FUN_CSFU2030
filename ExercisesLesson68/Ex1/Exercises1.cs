/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.04</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>


using System;
using System.Text;

namespace ExercisesLesson68
{
    class Exercises1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Employee[] employees = new Employee[100];
            int numOfEmployee = 0; // số lượng nhân viên
            int choice;
            do
            {
                Console.WriteLine("================== CÁC CHỨC NĂNG ==================");
                Console.WriteLine("1. Thêm mới nhân viên vào danh sách.");
                Console.WriteLine("2. Hiển thị danh sách nhân viên ra màn hình.");
                Console.WriteLine("3. Tính lương các nhân viên trong danh sách.");
                Console.WriteLine("4. Sắp xếp danh sách nhân viên theo lương thực lĩnh.");
                Console.WriteLine("5. Sắp xếp danh sách nhân viên theo số ngày đi làm.");
                Console.WriteLine("6. Tìm và hiển thị thông tin nhân viên theo mã NV.");
                Console.WriteLine("7. Cập nhật lương cho nhân viên theo mã cho trước.");
                Console.WriteLine("8. Xóa bỏ nhân viên khi biết mã NV cho trước.");
                Console.WriteLine("9. Thoát chương trình.");
                Console.WriteLine("==> Xin mời bạn chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var emp = CreateEmployee();
                        if (emp != null)
                        {
                            employees[numOfEmployee++] = emp;
                        }
                        break;
                    case 2:
                        if (numOfEmployee > 0)
                        {
                            ShowEmployee(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 3:
                        if (numOfEmployee > 0)
                        {
                            CalculateSalary(employees);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 4:
                        if (numOfEmployee > 0)
                        {
                            int comparer(Employee a, Employee b)
                            {
                                if (a == null && b == null)
                                {
                                    return 0;
                                }
                                else if (a == null && b != null)
                                {
                                    return -1;
                                }
                                else if (a != null && b == null)
                                {
                                    return 1;
                                }
                                return (int)(b.ReceivedSalary - a.ReceivedSalary);
                            };
                            Array.Sort(employees, comparer);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfEmployee > 0)
                        {
                            int comparer(Employee a, Employee b)
                            {
                                if (a == null && b == null)
                                {
                                    return 0;
                                }
                                else if (a == null && b != null)
                                {
                                    return -1;
                                }
                                else if (a != null && b == null)
                                {
                                    return 1;
                                }
                                return (b.WorkingDay > a.WorkingDay) ? 1 : (b.WorkingDay == a.WorkingDay) ? 0 : -1;
                            };
                            Array.Sort(employees, comparer);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfEmployee > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần tìm: ");
                            var id = Console.ReadLine();
                            var result = FindById(employees, id);
                            if (result != null)
                            {
                                Console.WriteLine("==> Thông tin nhân viên cần tìm: <==");
                                ShowEmployee(new Employee[] { result });
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfEmployee > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần cập nhật lương: ");
                            var id = Console.ReadLine();
                            Console.WriteLine("Nhập mức lương mới: ");
                            var salary = long.Parse(Console.ReadLine());
                            var result = UpdateSalary(employees, id, salary);
                            if (result)
                            {
                                Console.WriteLine("==> Cập nhật thành công! <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Cập nhật thất bại. Nhân viên cần update không tồn tại. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfEmployee > 0)
                        {
                            Console.WriteLine("Nhập mã nhân viên cần xóa: ");
                            var id = Console.ReadLine();
                            var result = RemoveById(employees, id);
                            if (result)
                            {
                                Console.WriteLine("==> Xóa thành công! <==");
                                numOfEmployee--;
                            }
                            else
                            {
                                Console.WriteLine("==> Xóa thất bại. Nhân viên cần xóa không tồn tại. <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách nhân viên rỗng <==");
                        }
                        break;
                    case 9:
                        Console.WriteLine("==> Cảm ơn quý khách đã sử dụng dịch vụ! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 9);
        }

        private static bool RemoveById(Employee[] employees, string id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null && employees[i].EmpId.CompareTo(id) == 0)
                {
                    // chuyển các nhân viên phía phải của nhân viên bị xóa sang trái 1 vị trí
                    // để danh sách nhân viên liền mạch không null
                    for (int j = i; j < employees.Length - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    return true;
                }
            }
            return false;
        }

        // phương thức cập nhật lương cho nhân viên và trả về kết quả cập nhật
        private static bool UpdateSalary(Employee[] employees, string id, long salary)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null && employees[i].EmpId.CompareTo(id) == 0)
                {
                    employees[i].Salary = salary;
                    return true;
                }
            }
            return false;
        }

        // tìm nhân viên theo mã nhân viên cho trước và trả về kết quả tìm kiếm
        // vì mỗi nhân viên chỉ có một mã nên kết quả trả về là 1 đối tượng đơn hoặc null
        // nếu không tìm thấy
        private static Employee FindById(Employee[] employees, string id)
        {
            foreach (var item in employees)
            {
                if (item != null && item.EmpId.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        // phương thức tính lương nhân viên
        private static void CalculateSalary(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    employees[i].CalculateSalary();
                }
            }
        }

        // phương thức tạo thông tin nhân viên
        private static Employee CreateEmployee()
        {
            Console.WriteLine("==> Chọn loại nhân viên cần thêm: ");
            Console.WriteLine("1. Nhân viên thông thường.");
            Console.WriteLine("2. Nhân viên quản lý.");
            Console.WriteLine("3. Giám đốc.");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                return CreateEmpInfo();
            }
            else if (option == 2)
            {
                return CreateLeaderInfo();
            }
            else if (option == 3)
            {
                return CreateDirectorInfo();
            }
            return null; // nếu không chọn cụ thể thì trả về null
        }

        private static Employee CreateDirectorInfo()
        {
            var emp = CreateEmpInfo();
            Console.WriteLine("Chức vụ: ");
            var role = Console.ReadLine();
            Console.WriteLine("Ngày nhận chức(vd 22/10/2025): ");
            var date = Console.ReadLine();
            var startDate = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            Console.WriteLine("Hệ số tiền thưởng(% lương): ");
            var bonusRate = float.Parse(Console.ReadLine()) / 100;
            return new Director(emp.EmpId, emp.FullName,
                emp.PhoneNumber, emp.Salary, emp.WorkingDay, bonusRate, role, startDate);
        }

        private static Employee CreateLeaderInfo()
        {
            var emp = CreateEmpInfo();
            Console.WriteLine("Chức vụ: ");
            var role = Console.ReadLine();
            Console.WriteLine("Hệ số tiền thưởng(% lương): ");
            var bonusRate = float.Parse(Console.ReadLine()) / 100;
            return new Manager(emp.EmpId, emp.FullName,
                emp.PhoneNumber, emp.Salary, emp.WorkingDay, bonusRate, role);
        }

        private static Employee CreateEmpInfo()
        {
            Employee employee = new Employee();
            Console.WriteLine("Họ và tên: ");
            employee.FullName = Console.ReadLine();
            Console.WriteLine("Số điện thoại: ");
            employee.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Mức lương: ");
            employee.Salary = long.Parse(Console.ReadLine());
            Console.WriteLine("Số ngày làm việc trong tháng: ");
            employee.WorkingDay = float.Parse(Console.ReadLine());
            return employee;
        }

        // phương thức hiển thị thông tin nhân viên
        private static void ShowEmployee(Employee[] employees)
        {
            var titleId = "Mã NV";
            var titleName = "Họ và tên";
            var titlePhone = "Số điện thoại";
            var titleSalary = "Mức lương";
            var titleWorkingDay = "Số ngày làm việc";
            var titleReceivedSalary = "Lương thực lĩnh";
            Console.WriteLine($"{titleId,-10:d}{titleName,-25:d}" +
                $"{titlePhone,-15:d}{titleSalary,-15:d}{titleWorkingDay,-20:d}" +
                $"{titleReceivedSalary,-20:d}");
            foreach (var item in employees)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.EmpId,-10:d}{item.FullName,-25:d}" +
                        $"{item.PhoneNumber,-15:d}{item.Salary,-15:d}{item.WorkingDay + "",-20:d}" +
                        $"{item.ReceivedSalary,-20:d}");
                }
            }
        }
    }

    // lớp mô tả thông tin nhân viên
    class Employee
    {
        private static int autoId = 1000;

        public string EmpId { get; set; }           // mã nhân viên
        public string FullName { get; set; }        // họ và tên
        public string PhoneNumber { get; set; }     // số điện thoại
        public long Salary { get; set; }            // mức lương
        public float WorkingDay { get; set; }       // số ngày làm việc trong tháng
        public long ReceivedSalary { get; set; }    // lương thực lĩnh

        // các constructor
        public Employee()
        {
            EmpId = $"EMP{autoId++}";
        }

        public Employee(string id, string fullName, string phone, long salary, float workingDay = 0)
        {
            EmpId = string.IsNullOrEmpty(id) ? $"EMP{autoId++}" : id;
            FullName = fullName;
            PhoneNumber = phone;
            Salary = salary;
            WorkingDay = workingDay;
        }

        public void CheckIn(string time)
        {
            Console.WriteLine($"Nhân viên {FullName} checkin lúc {time}.");
        }

        public void CheckOut(string time)
        {
            Console.WriteLine($"Nhân viên {FullName} checkout lúc {time}.");
        }

        public virtual long CalculateSalary(long profit = 0)
        {
            var calculatedSalary = (long)WorkingDay * Salary / 22;
            var bonus = (long)(WorkingDay >= 22 ? calculatedSalary * 0.2 : 0);
            ReceivedSalary = calculatedSalary + bonus;
            return ReceivedSalary;
        }
    }

    class Manager : Employee
    {
        public float BonusRate { get; set; } // phần trăm tiền thưởng
        public string Role { get; set; }     // chức vụ

        public Manager()
        {

        }

        public Manager(string id, string fullName, string phone,
            long salary, float workingDay, float bonus, string role) :
            base(id, fullName, phone, salary, workingDay)
        {
            BonusRate = bonus;
            Role = role;
        }

        public override long CalculateSalary(long profit = 0)
        {
            var baseSalary = base.CalculateSalary();
            ReceivedSalary = baseSalary + (long)(baseSalary * BonusRate);
            return ReceivedSalary;
        }
    }

    class Director : Employee
    {
        public string Role { get; set; }            // chức vụ
        public DateTime ReceivedDate { get; set; } // ngày nhận chức
        public float BonusRate { get; set; } // phần trăm tiền thưởng
        public long ResponsibilityAmount { get; set; } // tiền trách nhiệm

        public Director()
        {

        }

        public Director(string id, string fullName, string phone,
            long salary, float workingDay, float bonus, string role, DateTime startDate) :
            base(id, fullName, phone, salary, workingDay)
        {
            ReceivedDate = startDate;
            Role = role;
            BonusRate = bonus;
        }

        public override long CalculateSalary(long profit = 0)
        {
            var baseSalary = base.CalculateSalary();
            ReceivedSalary = baseSalary + (long)(profit * BonusRate + 0.15 * Salary);
            return ReceivedSalary;
        }
    }
}
