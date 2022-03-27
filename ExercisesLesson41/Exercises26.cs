using System;

namespace ExercisesLesson41
{
    class Exercises26
    {
        static void Main()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {Sub(a, b)}");
            Console.WriteLine($"{a} * {b} = {Mul(a, b)}");
            Console.WriteLine($"{a} / {b} = {Div(a, b)}");
            Console.WriteLine($"{a} % {b} = {Mod(a, b)}");
            Console.WriteLine($"{a} ^ {b} = {Pow(a, b)}");
        }

        /// <summary>
        /// Phương thức cộng hai số thực.
        /// </summary>
        /// <param name="a">Số thứ nhất.</param>
        /// <param name="b">Số thứ hai.</param>
        /// <returns>Kết quả tổng tìm được.</returns>
        static float Add(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        /// Phương thức tính hiệu số a trừ b.
        /// </summary>
        /// <param name="a">Số bị trừ.</param>
        /// <param name="b">Số trừ.</param>
        /// <returns></returns>
        static float Sub(float a, float b)
        {
            return a - b;
        }

        /// <summary>
        /// Phương thức tính tích hai số.
        /// </summary>
        /// <param name="a">Số thứ nhất.</param>
        /// <param name="b">Số thứ hai.</param>
        /// <returns>Tích a nhân b.</returns>
        static float Mul(float a, float b)
        {
            return a * b;
        }

        /// <summary>
        /// Phương thức tính thương a/b. b khác 0.
        /// </summary>
        /// <param name="a">Tử số.</param>
        /// <param name="b">Mẫu số.</param>
        /// <returns>Thương số a chia b.</returns>
        static float Div(float a, float b)
        {
            return a / b;
        }

        /// <summary>
        /// Chia lấy dư a cho b. b khác 0.
        /// </summary>
        /// <param name="a">Số bị chia.</param>
        /// <param name="b">Số chia.</param>
        /// <returns>Phần dư chia a cho b.</returns>
        static float Mod(float a, float b)
        {
            return a % b;
        }

        /// <summary>
        /// Phương thức tính a mũ b.
        /// </summary>
        /// <param name="a">Hệ số.</param>
        /// <param name="b">Số mũ.</param>
        /// <returns>Kết quả a^b.</returns>
        static double Pow(float a, float b)
        {
            return Math.Pow(a, b);
        }
    }
}
