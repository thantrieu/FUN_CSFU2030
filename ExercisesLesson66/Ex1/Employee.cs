using System;

namespace ExercisesLesson66
{
    /// <summary>
    /// Lớp mô tả thông tin nhân viên.
    /// Phần thứ nhất chứa các thuộc tính, trường dữ liệu, constructors
    /// và các khai báo nguyên mẫu của các phương thức.
    /// </summary>
    partial class Employee
    {
        // các trường dữ liệu để access modifier là private
        private static int AutoId { get; set; } = 1000;
        private string id; // mã nhân viên
        private FullName fullName; // họ và tên

        public string Id
        {
            get => id;
            set
            {
                if (value == null)
                {
                    id = "EMP" + AutoId++;
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get => $"{fullName.LastName} {fullName.MidName} {fullName.FirstName}";
            set
            {
                fullName = new FullName();
                var data = value.Split(' ');
                fullName.LastName = data[0];
                var midName = "";
                for (int i = 1; i < data.Length - 1; i++)
                {
                    midName += data[i] + " ";
                }
                fullName.MidName = midName.TrimEnd();
                fullName.FirstName = data[data.Length - 1];
            }
        } // họ và tên
        public string[] PhoneNumber = new string[6]; // số điện thoại
        public string Role { get; set; } // chức vụ
        public float Salary { get; set; } // mức lương
        public int WorkingDay { get; set; } // số ngày làm việc trong tháng
        public float ReceivedSalary { get; set; } // lương thực lĩnh

        // phương thức khởi tạo
        public Employee() { }

        public Employee(string id, string fullName, string phoneNumber,
            string role, float salary, int workingDay)
        {
            Id = id;
            Name = fullName;
            PhoneNumber[0] = phoneNumber;
            Role = role;
            Salary = salary;
            WorkingDay = workingDay;
        }

        // các khai báo phương thức
        public partial void Checkin(string time);
        public partial void Checkout(string time);
        public partial void DoWork(string task);
        public partial float CalculateSalary();
    }

    /// <summary>
    /// Lớp mô tả thông tin nhân viên.
    /// Phần 2 chứa định nghĩa chi tiết triển khai của các phương thức.
    /// </summary>
    partial class Employee
    {
        internal class FullName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MidName { get; set; }

            public FullName()
            {

            }

            public FullName(string first, string last, string mid)
            {
                FirstName = first;
                LastName = last;
                MidName = mid;
            }
        }
        // phương thức thể hiện hành động checkin
        public partial void Checkin(string time)
        {
            Console.WriteLine($"Nhân viên {Name} checkin lúc {time}.");
        }

        // phương thức thể hiện hành động checkout
        public partial void Checkout(string time)
        {
            Console.WriteLine($"Nhân viên {Name} checkout lúc {time}.");
        }

        // phương thức thể hiện hành động làm việc của nhân viên
        public partial void DoWork(string task)
        {
            Console.WriteLine($"Nhân viên {Name} đang làm nhiệm vụ {task}.");
        }

        // phương thức thể hiện hành động tính lương thực lĩnh của nhân viên
        public partial float CalculateSalary()
        {
            float bonus = (WorkingDay >= 22) ? 0.2f * Salary : 0; // tiền thưởng
            ReceivedSalary = Salary * WorkingDay / 22 + bonus; // lương thực lĩnh
            return ReceivedSalary;
        }
    }
}
