///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.06</version>
///</resultmary>

using System;

namespace ExercisesLesson61
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int num, int den)
        {
            Denominator = den;
            Numerator = num;
        }
        // cộng hai phân số
        public Fraction Add(Fraction other)
        {
            Fraction result = new Fraction(0, 1);
            if (Denominator != other.Denominator)
            {
                result.Denominator = Denominator * other.Denominator;
                result.Numerator = Numerator * other.Denominator + Denominator * other.Numerator;
            }
            else
            {
                result.Numerator = Numerator + other.Numerator;
                result.Denominator = Denominator;
            }
            result.Simplify();
            return result;
        }
        // trừ
        public Fraction Sub(Fraction other)
        {
            Fraction result = new Fraction(0, 1);
            if (Denominator != other.Denominator)
            {
                result.Denominator = Denominator * other.Denominator;
                result.Numerator = Numerator * other.Denominator - Denominator * other.Numerator;
            }
            else
            {
                result.Numerator = Numerator - other.Numerator;
                result.Denominator = Denominator;
            }
            result.Simplify();
            return result;
        }
        // nhân
        public Fraction Mul(Fraction other)
        {
            Fraction result = new Fraction(0, 1);
            result.Denominator = Denominator * other.Denominator;
            result.Numerator = Numerator * other.Numerator;
            result.Simplify();
            return result;
        }
        // chia
        public Fraction Div(Fraction other)
        {
            Fraction result = new Fraction(0, 1);
            result.Denominator = Denominator * other.Numerator;
            result.Numerator = Numerator * other.Denominator;
            result.Simplify();
            return result;
        }
        // rút gọn phân số
        public void Simplify()
        {
            if (Numerator == 0)
            {
                return; // nếu tử số bằng 0 thì kết thúc
            }
            Func<int, int, int> gcd = (a, b) =>
            {
                if (a < 0)
                {
                    a = -a;
                }
                if (b < 0)
                {
                    b = -b;
                }
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                return a;
            };
            int gcdValue = gcd(Numerator, Denominator);
            Denominator /= gcdValue;
            Numerator /= gcdValue;
        }

        public void CreateFraction(string serial)
        {
            Console.WriteLine($"Nhap phan so thu {serial}(vi du 2/3): ");
            var data = Console.ReadLine().Split('/');
            var num = int.Parse(data[0]);
            var den = int.Parse(data[1]);
            Numerator = num;
            Denominator = den;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(this);
        }
    }
    class Exercises3
    {
        static void Main()
        {
            Fraction f1 = new Fraction(0, 1);
            f1.CreateFraction("nhat");
            Fraction f2 = new Fraction(0, 1);
            f2.CreateFraction("hai");
            // rút gọn hai phân số
            f1.Simplify();
            f2.Simplify();
            // hiện kết quả
            Console.WriteLine($"Phan so f1 sau khi rut gon: {f1}");
            Console.WriteLine($"Phan so f2 sau khi rut gon: {f2}");
            Console.WriteLine($"{f1} + {f2} = {f1.Add(f2)}");
            Console.WriteLine($"{f1} - {f2} = {f1.Sub(f2)}");
            Console.WriteLine($"{f1} * {f2} = {f1.Mul(f2)}");
            Console.WriteLine($"{f1} / {f2} = {f1.Div(f2)}");
        }
    }
}
