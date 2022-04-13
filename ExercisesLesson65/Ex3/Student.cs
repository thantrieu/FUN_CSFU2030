namespace ExercisesLesson65
{
    /// <summary>
    /// Lớp mô tả thông tin và hành động của sinh viên.
    /// </summary>
    partial class Student
    {
        // các trường dữ liệu để access modifier là private
        private static int AutoId { get; set; } = 1000;
        private string id; // trường dữ liệu mô tả mã sinh viên

        // các thuộc tính public
        public string Id // thuộc tính mô tả thông tin mã sinh viên
        {
            get => id;
            set
            {
                if (value == null)
                {
                    id = $"ST{AutoId++}";
                }
                else
                {
                    id = value;
                }
            }
        }
        public string FirstName { get; set; } // tên
        public string LastName { get; set; } // họ
        public string MidName { get; set; } // đệm
        public string FullName { get => $"{LastName} {MidName} {FirstName}"; }
        public string Address { get; set; } // địa chỉ
        public float Gpa { get; set; } // điểm TB
        public string Major { get; set; } // chuyên ngành

        // các phương thức khởi tạo
        public Student()
        {

        }

        public Student(string id, string first, string last,
            string mid, string address, float gpa, string major)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            MidName = mid;
            Gpa = gpa;
            Address = address;
            Major = major;
        }
    }
}
