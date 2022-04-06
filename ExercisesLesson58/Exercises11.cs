///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.03</version>
///</resultmary>

using System;

namespace ExercisesLesson58
{
    class Exercises11
    {
        public struct Fraction
        {
            public int numerator;
            public int denominator;

            public Fraction(int num, int den)
            {
                numerator = num;
                denominator = den;
            }

            public override string ToString()
            {
                return $"{numerator}/{denominator}";
            }
        }
        // phương thức cộng hai phân số
        static Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            if (f1.denominator != f2.denominator)
            {
                result.denominator = f1.denominator * f2.denominator;
                result.numerator = f1.numerator * f2.denominator + f1.denominator * f2.numerator;
            }
            else
            {
                result.numerator = f1.numerator + f2.numerator;
                result.denominator = f1.denominator;
            }
            Simplify(ref result);
            return result;
        }
        // phương thức trừ hai phân số
        static Fraction Sub(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            if (f1.denominator != f2.denominator)
            {
                result.denominator = f1.denominator * f2.denominator;
                result.numerator = f1.numerator * f2.denominator - f1.denominator * f2.numerator;
            }
            else
            {
                result.numerator = f1.numerator - f2.numerator;
                result.denominator = f1.denominator;
            }
            Simplify(ref result);
            return result;
        }
        // phương thức nhân hai phân số
        static Fraction Mul(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.denominator = f1.denominator * f2.denominator;
            result.numerator = f1.numerator * f2.numerator;
            Simplify(ref result);
            return result;
        }
        // phương thức chia hai phân số
        static Fraction Div(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.denominator = f1.denominator * f2.numerator;
            result.numerator = f1.numerator * f2.denominator;
            Simplify(ref result);
            return result;
        }
        // phương thức rút gọn phân số
        static void Simplify(ref Fraction f)
        {
            if(f.numerator == 0)
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
            int gcdValue = gcd(f.numerator, f.denominator);
            f.denominator /= gcdValue;
            f.numerator /= gcdValue;
        }
        // phương thức tạo thông tin phân số
        static Fraction CreateFraction(string serial)
        {
            Console.WriteLine($"Nhap phan so thu {serial}(vi du 2/3): ");
            var data = Console.ReadLine().Split('/');
            var num = int.Parse(data[0]);
            var den = int.Parse(data[1]);
            Fraction f = new Fraction(num, den);
            return f;
        }

        static void Main()
        {
            Fraction f1 = CreateFraction("nhat");
            Fraction f2 = CreateFraction("hai");
            // rút gọn hai phân số
            Simplify(ref f1);
            Simplify(ref f2);
            // hiện kết quả
            Console.WriteLine($"Phan so f1 sau khi rut gon: {f1}");
            Console.WriteLine($"Phan so f2 sau khi rut gon: {f2}");
            Console.WriteLine($"{f1} + {f2} = {Add(f1, f2)}");
            Console.WriteLine($"{f1} - {f2} = {Sub(f1, f2)}");
            Console.WriteLine($"{f1} * {f2} = {Mul(f1, f2)}");
            Console.WriteLine($"{f1} / {f2} = {Div(f1, f2)}");
        }
    }
}
