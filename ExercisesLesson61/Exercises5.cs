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
        public string FullName { get => $"{LastName} {MidName} {FirstName}"; }
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
        static void Main()
        {
            int choice;
            Student[] students = new Student[100];
            int size = 0;
            do
            {
                Console.WriteLine("================== CAC CHUC NANG ==================");
                Console.WriteLine("1. Them moi sinh vien vao danh sach.");
                Console.WriteLine("2. Hien thi danh sach sinh vien.");
                Console.WriteLine("3. Sap xep danh sach sinh vien theo diem giam dan.");
                Console.WriteLine("4. Sap xep danh sach sinh vien theo ten tang dan.");
                Console.WriteLine("5. Sap xep danh sach sinh vien theo diem va ten.");
                Console.WriteLine("6. Tim sinh vien theo ten.");
                Console.WriteLine("7. Tim sinh vien theo tinh.");
                Console.WriteLine("8. Xoa sinh vien cho truoc khi biet ma sinh vien.");
                Console.WriteLine("9. Liet ke so luong sinh vien theo tinh.");
                Console.WriteLine("10. Sua diem TB cho sinh vien theo ma SV.");
                Console.WriteLine("11. Ket thuc chuong trinh.");
                Console.WriteLine("Xin moi ban chon chuc nang: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var student = CreateStudent();
                        students[size++] = student;
                        break;
                    case 2:
                        if (size > 0)
                        {
                            ShowStudents(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            SortByGpa(students, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            SortByName(students, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            SortByNameAndGpa(students, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            Console.WriteLine("Ten can tim: ");
                            var firstName = Console.ReadLine();
                            var result = FindByName(students, firstName);
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Khong co ket qua. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Ket qua tim kiem: ");
                                ShowStudents(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 7:
                        if (size > 0)
                        {
                            Console.WriteLine("Ten thanh pho can tim: ");
                            var city = Console.ReadLine();
                            var result = FindByAddress(students, city);
                            if (result[0] == null)
                            {
                                Console.WriteLine("==> Khong co ket qua. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Ket qua tim kiem: ");
                                ShowStudents(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 8:
                        if (size > 0)
                        {
                            Console.WriteLine("Ma sinh vien can xoa: ");
                            var id = Console.ReadLine();
                            var result = Remove(students, id);
                            if (!result)
                            {
                                Console.WriteLine("==> Xoa that bai! <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Xoa thanh cong! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 9:
                        if (size > 0)
                        {
                            Statistic(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 10:
                        if (size > 0)
                        {
                            Console.WriteLine("Ma sinh vien can sua diem: ");
                            var id = Console.ReadLine();
                            var result = EditGpa(students, id);
                            if (!result)
                            {
                                Console.WriteLine("==> Cap nhat diem that bai. <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Cap nhat diem thanh cong! <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach sinh vien trong <==");
                        }
                        break;
                    case 11:
                        Console.WriteLine("==> Xin cam on va hen gap lai! <==");
                        break;
                    default:
                        break;
                }
            } while (choice != 11);
        }

        class Pair
        {
            public int Occurrent { get; set; }
            public string Address { get; set; }
        }

        // liệt kê số lượng sinh viên từng tỉnh
        static void Statistic(Student[] students)
        {
            bool Existed(string address, int pos)
            {
                for (int i = 0; i < pos; i++)
                {
                    if (students[i].Address.CompareTo(address) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            int CountStudent(string address)
            {
                int count = 0;
                foreach (var item in students)
                {
                    if (item != null && item.Address.CompareTo(address) == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            Pair[] result = new Pair[students.Length];
            var resultSize = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (!Existed(students[i].Address, i))
                    {
                        result[resultSize] = new Pair();
                        result[resultSize].Address = students[i].Address;
                        result[resultSize].Occurrent = CountStudent(students[i].Address);
                        resultSize++;
                    }
                }
            }
            // tạo mảng kết quả sau cùng có vừa đủ các phần tử khác null đã lọc được
            // sau đó chép các phần tử sang
            // mục đích để gọi phương thức sắp xếp của lớp Array cho tiện
            var finalResult = new Pair[resultSize];
            Array.Copy(result, finalResult, resultSize);
            // sắp xếp
            Array.Sort(finalResult, (p1, p2) => p2.Occurrent - p1.Occurrent);
            // hiện kết quả
            for (int i = 0; i < resultSize; i++)
            {
                Console.WriteLine($"{finalResult[i].Address}: {finalResult[i].Occurrent}");
            }
        }

        // sửa điểm cho sinh viên theo mã sinh viên
        static bool EditGpa(Student[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Id.CompareTo(id) == 0)
                {
                    Console.WriteLine("Nhap diem: ");
                    var newGpa = float.Parse(Console.ReadLine());
                    students[i].Gpa = newGpa;
                    return true; // cập nhật thành công
                }
            }
            return false;
        }

        // xóa sinh viên theo mã
        static bool Remove(Student[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Id.CompareTo(id) == 0)
                {
                    students[i] = null;
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    return true; // xóa thành công
                }
            }
            return false; // xóa thất bại
        }

        // tìm sinh viên theo địa chỉ
        static Student[] FindByAddress(Student[] students, string address)
        {
            var result = new Student[students.Length];
            int resultSize = 0;
            foreach (var item in students)
            {
                if (item != null)
                {
                    if (item.Address.ToLower().CompareTo(address.ToLower()) == 0)
                    {
                        result[resultSize++] = item;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        // tìm sinh viên theo tên
        static Student[] FindByName(Student[] students, string name)
        {
            var result = new Student[students.Length];
            int resultSize = 0;
            foreach (var item in students)
            {
                if (item != null)
                {
                    if (item.FirstName.ToLower().CompareTo(name.ToLower()) == 0)
                    {
                        result[resultSize++] = item;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        // sắp xếp theo tên tăng dần và điểm giảm dần
        static void SortByNameAndGpa(Student[] students, int size)
        {
            int Comparer(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s1.Gpa - s2.Gpa != 0)
                {
                    if (s2.Gpa > s1.Gpa)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return s1.FirstName.CompareTo(s2.FirstName);
                }
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Comparer(students[j - 1], students[j]) > 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // sắp xếp theo tên sinh viên tăng dần
        static void SortByName(Student[] students, int size)
        {
            int Comparer(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                return s1.FirstName.CompareTo(s2.FirstName);
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Comparer(students[j - 1], students[j]) > 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // sắp xếp theo điểm TB giảm dần
        static void SortByGpa(Student[] students, int size)
        {
            int Comparer(Student s1, Student s2)
            {
                if (s1 == null || s2 == null)
                {
                    return 0;
                }
                if (s2.Gpa > s1.Gpa)
                {
                    return 1;
                }
                else if (s2.Gpa < s1.Gpa)
                {
                    return -1;
                }
                return 0;
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (Comparer(students[j - 1], students[j]) > 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức hiển thị thông tin sinh viên trong danh sách
        static void ShowStudents(Student[] students)
        {
            var titleId = "Ma SV";
            var titleFullName = "Ho Ten";
            var titleAddress = "Dia Chi";
            var titleGpa = "Diem TB";
            var titleMajor = "Chuyen Nganh";
            Console.WriteLine($"{titleId,-15:d}{titleFullName,-25:d}{titleAddress,-15:d}" +
                        $"{titleGpa,-10:d}{titleMajor,-20:d}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-15:d}{item.FullName,-25:d}" +
                        $"{item.Address,-15:d}{Math.Round(item.Gpa, 2) + "",-10:d}{item.Major,-20:d}");
                }
                else
                {
                    break;
                }
            }
        }

        // phương thức tạo đối tượng sinh viên mới
        static Student CreateStudent()
        {
            Console.WriteLine("Ma sinh vien: ");
            var id = Console.ReadLine();
            Console.WriteLine("Ho va ten: ");
            var fullName = Console.ReadLine().Split(' ');
            Console.WriteLine("Dia chi(tinh, thanh pho):");
            var address = Console.ReadLine();
            Console.WriteLine("Diem TB: ");
            var gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Chuyen nganh: ");
            var major = Console.ReadLine();
            var midName = "";
            for (int i = 1; i < fullName.Length - 1; i++)
            {
                midName += fullName[i] + " ";
            }
            return new Student(id, fullName[fullName.Length - 1],
                fullName[0], midName.Trim(), address, gpa, major);
        }
    }
}
