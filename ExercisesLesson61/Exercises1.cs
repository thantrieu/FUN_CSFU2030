///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.06</version>
///</summary>

using System;

namespace ExercisesLesson61
{
    /// <summary>
    /// Lớp mô tả thông tin nhân viên.
    /// </summary>
    class Employee
    {
        public string Id { get; set; } // mã nhân viên
        public string FullName { get; set; } // họ và tên
        public string PhoneNumber { get; set; } // số điện thoại
        public string Role { get; set; } // chức vụ
        public float Salary { get; set; } // mức lương

        // phương thức khởi tạo
        public Employee(string id, string fullName, string phoneNumber, string role, float salary)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Role = role;
            Salary = salary;
        }
        // phương thức thể hiện hành động checkin
        public void Checkin(string time)
        {
            Console.WriteLine($"Nhan vien {FullName} checkin luc {time}.");
        }
        // phương thức thể hiện hành động checkout
        public void Checkout(string time)
        {
            Console.WriteLine($"Nhan vien {FullName} checkout luc {time}.");
        }
        // phương thức thể hiện hành động làm việc của nhân viên
        public void DoWork(string task)
        {
            Console.WriteLine($"Nhan vien {FullName} dang lam nhiem vu {task}.");
        }
        // phương thức thể hiện hành động tính lương thực lĩnh của nhân viên
        public float CalculateSalary(int workingDay)
        {
            float bonus = (workingDay >= 22) ? 0.2f * Salary : 0; // tiền thưởng
            return Salary * workingDay / 22 + bonus; // lương thực lĩnh
        }
    }

    class Exercises1
    {
        static void Main()
        {
            Employee emp = new Employee("EMP1001", "Le Thanh Cong", "0978213214", "Dev", 17850000);
            emp.Checkin("8:30");
            emp.Checkout("18:00");
            Console.WriteLine($"So ngay di lam thang truoc cua {emp.FullName}: 23 ngay.");
            Console.WriteLine($"Luong thang cua nhan vien {emp.FullName}: {emp.CalculateSalary(23),2:f}d");
            Console.WriteLine("=====================================");
        }
    }
}
