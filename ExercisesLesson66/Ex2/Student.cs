namespace ExercisesLesson66
{
    /// <summary>
    /// Lớp mô tả thông tin và hành động của sinh viên.
    /// </summary>
    partial class Student
    {
        // các trường dữ liệu để access modifier là private
        private static int AutoId { get; set; } = 1000;
        private string id; // trường dữ liệu mô tả mã sinh viên
        public FullName StudentName { get; set; }
        public Address StudentAddress { get; set; }
        public Mark StudentMark { get; set; }

        // các thuộc tính public
        public string StudentId // thuộc tính mô tả thông tin mã sinh viên
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
        
        public string Major { get; set; } // chuyên ngành

        // các phương thức khởi tạo
        public Student() { }

        public Student(string id, FullName fullName,
            Address address, Mark mark, string major)
        {
            StudentId = id;
            StudentAddress = address;
            StudentName = fullName;
            StudentMark = mark;
            Major = major;
        }

        public class FullName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MidName { get; set; }

            public FullName() { }

            public FullName(string first, string last, string mid)
            {
                FirstName = first;
                LastName = last;
                MidName = mid;
            }

            public override string ToString()
            {
                return $"{LastName} {MidName} {FirstName}";
            }
        }

        public class Address
        {
            public string Ward { get; set; }
            public string District { get; set; }
            public string City { get; set; }

            public Address() { }

            public Address(string ward, string district, string city)
            {
                Ward = ward;
                District = district;
                City = city;
            }

            public override string ToString()
            {
                return City;
            }
        }

        public class Mark
        {
            public float Math { get; set; }
            public float English { get; set; }
            public float Programming { get; set; }
            public float Gpa { get; set; }

            public Mark() { }
            public Mark(float math, float eng, float prog)
            {
                Math = math;
                English = eng;
                Programming = prog;
                CalculateGpa();
            }

            public void CalculateGpa()
            {
                Gpa = (Math + English + Programming) / 3;
            }
        }
    }
}
