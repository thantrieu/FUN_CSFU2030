///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.06</version>
///</resultmary>

using System;

namespace ExercisesLesson61
{
    class Student
    {
        public string Id { get; set; } // mã sinh viên
        public string FirstName { get; set; } // tên
        public string LastName { get; set; } // họ
        public string MidName { get; set; } // đệm
        public string Address { get; set; } // địa chỉ
        public float Gpa { get; set; } // điểm TB
        public string Major { get; set; } // chuyên ngành

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
    class Exercises5
    {
    }
}
