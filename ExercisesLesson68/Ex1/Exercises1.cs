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
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Console.WriteLine("==> Cảm ơn quý khách đã sử dụng dịch vụ! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 9);
        }
    }

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
