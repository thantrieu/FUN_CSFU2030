using System;

namespace ExercisesLesson43
{
    class Exercises4
    {
        static void Main()
        {
            int a = 100;
            int b = 300;
            int c = 200;
            Console.WriteLine("So lon thu 2(int): " + SecondMax(a, b, c)); // 3 số int
            Console.WriteLine("So lon thu 2(long): " + SecondMax(50L, 100L, 10L)); // 3 số long
            Console.WriteLine("So lon thu 2(float): " + SecondMax(1.25f, 3.78f, 2.54f)); // 3 số float
            Console.WriteLine("So lon thu 2(double): " + SecondMax(1.42, 3.5, 1.05)); // 3 số double
            Console.WriteLine("So lon thu 2(decimal): " + SecondMax(5m, 9m, 100m)); // 3 số decimal
        }

        static int Max(int a, int b, int c)
        {
            int max = a;
            if(max < c)
            {
                max = c;
            }
            if(max < b)
            {
                max = b;
            }
            return max;
        }

        static int Min(int a, int b, int c)
        {
            int min = a;    
            if(min > b)
            {
                min = b;    
            }
            if(min > c)
            {
                min = c;
            }
            return min;
        }

        static int SecondMax(int a, int b, int c)
        {
            if(a == b && b == c)
            {
                return a;
            }
            int min = Min(a, b, c);
            int max = Max(a, b, c);
            int secondMax = min;
            if(secondMax < a && a != max)
            {
                secondMax = a;
            }
            if(secondMax < b && b != max)
            {
                secondMax=b;
            }
            if(secondMax < c && c != max)
            {
                secondMax = c;
            }
            return secondMax;
        }

        // nạp chồng tìm max2 trong 3 số kiểu long
        static long Max(long a, long b, long c)
        {
            long max = a;
            if (max < c)
            {
                max = c;
            }
            if (max < b)
            {
                max = b;
            }
            return max;
        }

        static long Min(long a, long b, long c)
        {
            long min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            return min;
        }

        static long SecondMax(long a, long b, long c)
        {
            if (a == b && b == c)
            {
                return a;
            }
            long min = Min(a, b, c);
            long max = Max(a, b, c);
            long secondMax = min;
            if (secondMax < a && a != max)
            {
                secondMax = a;
            }
            if (secondMax < b && b != max)
            {
                secondMax = b;
            }
            if (secondMax < c && c != max)
            {
                secondMax = c;
            }
            return secondMax;
        }
        // nạp chồng cho 3 số float
        static float Max(float a, float b, float c)
        {
            float max = a;
            if (max < c)
            {
                max = c;
            }
            if (max < b)
            {
                max = b;
            }
            return max;
        }

        static float Min(float a, float b, float c)
        {
            float min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            return min;
        }

        static float SecondMax(float a, float b, float c)
        {
            if (a == b && b == c)
            {
                return a;
            }
            float min = Min(a, b, c);
            float max = Max(a, b, c);
            float secondMax = min;
            if (secondMax < a && a != max)
            {
                secondMax = a;
            }
            if (secondMax < b && b != max)
            {
                secondMax = b;
            }
            if (secondMax < c && c != max)
            {
                secondMax = c;
            }
            return secondMax;
        }
        // cho 3 số double
        static double Max(double a, double b, double c)
        {
            double max = a;
            if (max < c)
            {
                max = c;
            }
            if (max < b)
            {
                max = b;
            }
            return max;
        }

        static double Min(double a, double b, double c)
        {
            double min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            return min;
        }

        static double SecondMax(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return a;
            }
            double min = Min(a, b, c);
            double max = Max(a, b, c);
            double secondMax = min;
            if (secondMax < a && a != max)
            {
                secondMax = a;
            }
            if (secondMax < b && b != max)
            {
                secondMax = b;
            }
            if (secondMax < c && c != max)
            {
                secondMax = c;
            }
            return secondMax;
        }
        // cho 3 số decimal
        static decimal Max(decimal a, decimal b, decimal c)
        {
            decimal max = a;
            if (max < c)
            {
                max = c;
            }
            if (max < b)
            {
                max = b;
            }
            return max;
        }

        static decimal Min(decimal a, decimal b, decimal c)
        {
            decimal min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            return min;
        }

        static decimal SecondMax(decimal a, decimal b, decimal c)
        {
            if (a == b && b == c)
            {
                return a;
            }
            decimal min = Min(a, b, c);
            decimal max = Max(a, b, c);
            decimal secondMax = min;
            if (secondMax < a && a != max)
            {
                secondMax = a;
            }
            if (secondMax < b && b != max)
            {
                secondMax = b;
            }
            if (secondMax < c && c != max)
            {
                secondMax = c;
            }
            return secondMax;
        }
    }
}
