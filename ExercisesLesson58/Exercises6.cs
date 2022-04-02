///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises6
    {
        struct Address
        {
            public string ward;
            public string district;
            public string city;

            public Address(string ward, string district, string city)
            {
                this.ward = ward;
                this.district = district;
                this.city = city;
            }

            public override string ToString()
            {
                return $"{ward}-{district}-{city}";
            }
        }

        struct FullName
        {
            public string first;
            public string last;
            public string mid;

            public FullName(string first, string last, string mid)
            {
                this.first = first;
                this.last = last;
                this.mid = mid;
            }

            public override string ToString()
            {
                return $"{last} {mid} {first}";
            }
        }

        struct Mark
        {
            public float math;
            public float english;
            public float programming;

            public Mark(float math, float eng, float prog)
            {
                this.math = math;
                english = eng;
                programming = prog;
            }

            public override string ToString()
            {
                return $"{math} {english} {programming}";
            }
        }

        struct Student
        {
            public string id;
            public FullName fullName;
            public Address address;
            public Mark mark;
            public string major;

            public Student(string id, FullName fullName, Address address, Mark mark, string major)
            {
                this.id = id;
                this.fullName = fullName;
                this.address = address;
                this.mark = mark;
                this.major = major;
            }

            public override string ToString()
            {
                return $"{id} {fullName} {address} {mark} {major}";
            }
        }

        static Student CreateStudent()
        {
            Student student = new Student();
            Console.WriteLine("Ma sinh vien: ");
            student.id = Console.ReadLine();
            student.fullName = CreateFullName();
            student.address = CreateAddress();
            student.mark = CreateMark();
            Console.WriteLine("Chuyen nganh: ");
            student.major = Console.ReadLine();
            return student;
        }

        static Mark CreateMark()
        {
            Console.WriteLine("Diem Toan: ");
            var math = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem Tieng Anh: ");
            var eng = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem Lap Trinh: ");
            var prog = float.Parse(Console.ReadLine());
            return new Mark(math, eng, prog);
        }

        static Address CreateAddress()
        {
            string ward, district, city;
            Console.WriteLine("Xa(phuong): ");
            ward = Console.ReadLine();
            Console.WriteLine("Quan(huyen): ");
            district = Console.ReadLine();
            Console.WriteLine("Thanh pho(tinh): ");
            city = Console.ReadLine();
            return new Address(ward, district, city);
        }

        static FullName CreateFullName()
        {
            Console.WriteLine("Ho va ten: ");
            var name = Console.ReadLine().Split(' ');
            var first = name[name.Length - 1];
            var last = name[0];
            var mid = "";
            for (int i = 1; i < name.Length - 1; i++)
            {
                mid += name[i] + " ";
            }
            return new FullName(first, last, mid.TrimEnd());
        }
        // hiển thị thông tin sinh viên dạng bảng gồm các hàng cột
        static void ShowStudentInfo(Student[] students)
        {
            var fullName = "Ho Va Ten";
            var address = "Dia Chi";
            var id = "Ma SV";
            var major = "Chuyen Nganh";
            var math = "Toan";
            var eng = "T.Anh";
            var prog = "L.Trinh";
            // {id,-k:d} là định dạng dành k vị trí(kí tự) để biểu diễn thông tin trong id
            // dấu trừ để căn lề trái, mặc định chương trình sẽ căn lề phải.
            Console.WriteLine($"{id,-10:d}{fullName,-20:d}{address,-30:d}" +
                $"{math,-10:d}{eng,-10:d}{prog,-10:d}{major,-15:d}");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].id == null)
                {
                    return; // kết thúc việc in ra kết quả
                }
                var student = students[i];
                Console.WriteLine($"{student.id,-10:d}{student.fullName,-20:d}{student.address,-30:d}" +
                    $"{student.mark.math,-10:d}{student.mark.english,-10:d}{student.mark.programming,-10:d}" +
                    $"{student.major,-15:d}");
            }
        }
        // sắp xếp theo tổng điểm giảm dần
        static void Sort(Student[] students, int size)
        {
            Func<Student, float> sum = (s) =>
            {
                return s.mark.english + s.mark.programming + s.mark.math;
            };
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j >= 0; j++)
                {
                    if (sum(students[j]) > sum(students[j - 1]))
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }
        // sắp xếp theo tên a-z
        static void SortByName(Student[] students, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j >= 0; j++)
                {
                    if (students[j].fullName.first.CompareTo(students[j - 1].fullName.first) < 0)
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }
        // sắp xếp theo tổng điểm, tên, họ
        static void SortByNameAndMark(Student[] students, int size)
        {
            Func<Student, float> sum = (s) =>
            {
                return s.mark.english + s.mark.programming + s.mark.math;
            };
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = size - 1; j >= 0; j++)
                {
                    var s1 = sum(students[j]);
                    var s2 = sum(students[j - 1]);
                    var nameCompare = students[j].fullName.first.CompareTo(students[j - 1].fullName.first);
                    var lastNameCompare = students[j].fullName.last.CompareTo(students[j - 1].fullName.last);
                    if (s1 > s2 || (s1 == s2 && nameCompare < 0) ||
                        (s1 == s2 && nameCompare == 0 && lastNameCompare < 0))
                    {
                        var tmp = students[j];
                        students[j] = students[j - 1];
                        students[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức tìm sinh viên theo tên
        static Student[] FindByName(Student[] students, int size, string name)
        {
            int resultCount = 0;
            Student[] result = new Student[students.Length];
            for (int i = 0; i < size; i++)
            {
                if (students[i].fullName.first.ToLower().CompareTo(name.ToLower()) == 0)
                {
                    result[resultCount++] = students[i];
                }
            }
            return result;
        }
        // tìm sinh viên theo tỉnh
        static Student[] FindByCity(Student[] students, string city)
        {
            int resultCount = 0;
            Student[] result = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].address.city.ToLower().CompareTo(city.ToLower()) == 0)
                {
                    result[resultCount++] = students[i];
                }
            }
            return result;
        }
        // xóa sinh viên có mã cho trước khỏi danh sách
        static bool Remove(Student[] students, ref int size, string id)
        {
            for (int i = 0; i < size; i++)
            {
                if (students[i].id.CompareTo(id) == 0)
                {
                    for (int j = i; j < size; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    size--;
                    return true;
                }
            }
            return false;
        }

        public struct Pair
        {
            public string city;
            public float englishMark;
            public int amount;
        }
        // sắp xếp danh sách thống kê theo từng tỉnh
        static void SortStatisticByCity(Pair[] statistic, int size)
        {
            for (int i = 0; i < statistic.Length - 1; i++)
            {
                for (int j = statistic.Length - 1; j > i; j--)
                {
                    if (statistic[j].amount > statistic[j - 1].amount)
                    {
                        var tmp = statistic[j];
                        statistic[j] = statistic[j - 1];
                        statistic[j - 1] = tmp;
                    }
                }
            }
        }

        // sắp xếp danh sách thống kê theo đầu điểm tiếng anh giảm dần
        static void SortStatisticByEnglishLevel(Pair[] statistic, int size)
        {
            for (int i = 0; i < statistic.Length - 1; i++)
            {
                for (int j = statistic.Length - 1; j > i; j--)
                {
                    if (statistic[j].englishMark > statistic[j - 1].englishMark)
                    {
                        var tmp = statistic[j];
                        statistic[j] = statistic[j - 1];
                        statistic[j - 1] = tmp;
                    }
                }
            }
        }

        static int ContainCity(Pair[] pairs, int size, string city)
        {
            for (int i = 0; i < size; i++)
            {
                if (pairs[i].city.CompareTo(city) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        static int ContainMark(Pair[] pairs, int size, float mark)
        {
            for (int i = 0; i < size; i++)
            {
                if (pairs[i].englishMark == mark)
                {
                    return i;
                }
            }
            return -1;
        }

        static void StatByCity(Student[] students, int size)
        {
            Pair[] statistic = new Pair[size];
            int statSize = 0;
            for (int i = 0; i < size; i++)
            {
                var statIndex = ContainCity(statistic, statSize, students[i].address.city);
                if (statIndex != -1)
                {
                    statistic[statIndex].amount++;
                    break;
                }
                else
                {
                    statistic[statSize++].city = students[i].address.city;
                }
            }
            // sắp xếp
            SortStatisticByCity(statistic, statSize);
            // hien ket qua
            Console.WriteLine("==> Ket qua thong ke theo tinh: <==");
            for (int i = 0; i < statSize; i++)
            {
                Console.WriteLine($"{statistic[i].city}: {statistic[i].amount}");
            }
        }

        static void StatByEnglishLevel(Student[] students, int size)
        {
            Pair[] statistic = new Pair[size];
            int statSize = 0;
            for (int i = 0; i < size; i++)
            {
                var statIndex = ContainMark(statistic, statSize, students[i].mark.english);
                if (statIndex != -1)
                {
                    statistic[statIndex].amount++;
                    break;
                }
                else
                {
                    statistic[statSize++].englishMark = students[i].mark.english;
                }
            }
            // sắp xếp
            SortStatisticByEnglishLevel(statistic, statSize);
            // hien ket qua
            Console.WriteLine("==> Ket qua thong ke theo dau diem tieng Anh <==");
            for (int i = 0; i < statSize; i++)
            {
                Console.WriteLine($"{statistic[i].englishMark}: {statistic[i].amount}");
            }
        }

        static bool EditMark(Student[] students, int size, string id)
        {
            for (int i = 0; i < size; i++)
            {
                if (students[i].id.CompareTo(id) == 0)
                {
                    Console.WriteLine("Nhap diem thay the: ");
                    var newMark = float.Parse(Console.ReadLine());
                    students[i].mark.programming = newMark;
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
            Student[] students = new Student[100];
            int numOfStudent = 0;
            int choice;
            do
            {
                Console.WriteLine("========================= MENU =========================");
                Console.WriteLine("1. Them moi sinh vien vao danh sach.");
                Console.WriteLine("2. Hien thi danh sach sinh vien.");
                Console.WriteLine("3. Sap xep danh sach sinh vien theo tong diem giam dan.");
                Console.WriteLine("4. Sap xep danh sach sinh vien theo ten tang dan.");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var studdent = CreateStudent();
                        students[numOfStudent++] = studdent;
                        break;
                    case 2:
                        if (numOfStudent > 0)
                        {
                            Console.WriteLine("==> Cac sinh vien trong danh sach <==");
                            ShowStudentInfo(students);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 3:
                        if (numOfStudent > 0)
                        {
                            Sort(students, numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 4:
                        if (numOfStudent > 0)
                        {
                            SortByName(students, numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 5:
                        if (numOfStudent > 0)
                        {
                            SortByNameAndMark(students, numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 6:
                        if (numOfStudent > 0)
                        {
                            Console.WriteLine("Nhap ten sinh vien can tim: ");
                            string name = Console.ReadLine();
                            var result = FindByName(students, numOfStudent, name);
                            if (result[0].id == null)
                            {
                                Console.WriteLine("==> Khong co ket qua phu hop <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Danh sach sinh vien can tim <==");
                                ShowStudentInfo(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 7:
                        if (numOfStudent > 0)
                        {
                            Console.WriteLine("Nhap ten tinh can tim: ");
                            string city = Console.ReadLine();
                            var result = FindByCity(students, city);
                            if (result[0].id == null)
                            {
                                Console.WriteLine("==> Khong co ket qua phu hop <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Danh sach sinh vien can tim <==");
                                ShowStudentInfo(result);
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 8:
                        if (numOfStudent > 0)
                        {
                            Console.WriteLine("Nhap ma sinh vien can xoa: ");
                            var id = Console.ReadLine();
                            var result = Remove(students, ref numOfStudent, id);
                            if (result)
                            {
                                Console.WriteLine("==> Xoa thanh cong <==");
                            }
                            else
                            {
                                Console.WriteLine("==> Xoa that bai <==");
                            }
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 9:
                        if (numOfStudent > 0)
                        {
                            StatByCity(students, numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 10:
                        if (numOfStudent > 0)
                        {
                            StatByEnglishLevel(students, numOfStudent);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 11:
                        if (numOfStudent > 0)
                        {
                            Console.WriteLine("Nhap ma sinh vien can sua diem: ");
                            var id = Console.ReadLine();
                            EditMark(students, numOfStudent, id);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach rong <==");
                        }
                        break;
                    case 12:
                        Console.WriteLine("==> Cam on quy vi da su dung dich vu! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chuc nang. Vui long chon 1-12. <==");
                        break;
                }
            } while (choice != 0);
        }
    }
}
