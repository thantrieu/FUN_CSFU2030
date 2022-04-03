///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.03</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises10
    {
        struct EquationQuadratic
        {
            public float a;
            public float b;
            public float c;
            public float delta;
            public string numOfResult;
            public float x1;
            public float x2;
        }

        static EquationQuadratic CreateEquation()
        {
            EquationQuadratic equation = new EquationQuadratic();
            Console.WriteLine("He so a: ");
            equation.a = float.Parse(Console.ReadLine());
            Console.WriteLine("He so b: ");
            equation.b = float.Parse(Console.ReadLine());
            Console.WriteLine("He so c: ");
            equation.c = float.Parse(Console.ReadLine());
            return equation;
        }

        static void Solve(EquationQuadratic equation)
        {
            equation.delta = equation.b * equation.b - 4 * equation.a * equation.c;
            if (equation.delta < 0)
            {
                equation.numOfResult = "Phuong trinh vo nghiem";
                Console.WriteLine(equation.numOfResult);
            }
            else if (equation.delta == 0)
            {
                equation.numOfResult = "Phuong trinh co nghiem kep";
                equation.x1 = -equation.b / (2 * equation.a);
                equation.x2 = equation.x1;
                Console.WriteLine(equation.numOfResult);
                Console.WriteLine("x1 = x2 = " + equation.x1);
            }
            else
            {
                equation.numOfResult = "Phuong trinh co 2 nghiem phan biet";
                equation.x1 = (float)(-equation.b - Math.Sqrt(equation.delta)) / (2 * equation.a);
                equation.x2 = (float)(-equation.b + Math.Sqrt(equation.delta)) / (2 * equation.a);
                Console.WriteLine(equation.numOfResult);
                Console.WriteLine("x1 = " + equation.x1);
                Console.WriteLine("x2 = " + equation.x2);
            }
        }

        static void Main()
        {
            var equation = CreateEquation();
            Solve(equation);
        }
    }
}
