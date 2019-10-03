using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Equation(2));
        }
        public static bool IsOdd(int n)
        {
            if (n % 2 == 0)
                return false;
            return true;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 != 0)
                return false;
            return true;
        }
        public static bool IsPrime(int n)
        {
            int c = 0;
            if(n>=2)
            {
                for(int i=1;i<=n;i++)
                {
                    if (n % i == 0)
                        c++;
                }
            }
            if (c == 2)
                return true;
            return false;
        }
        public static int Square(int n)
        {
            return n * n;
        }
        public static int Cube(int n)
        {
            return n * n * n;
        }
        public static double Pow(double x, double y)
        {
            double p = 1;
            if (x == 0)
                p = 0;
            else if (x != 0 && y > 0)
                for (int i = 1; i <= y; i++)
                {
                    p *= x;
                }
            else if (x != 0 && y < 0)
                for (int i = 1; i <= -y; i++)
                {
                    p *= 1 / x;
                }
            return p;
        }
        public static int Abs(int n)
        {
            if (n < 0)
                n *= (-1);
            return n;
        }
        public static int Ceil(float n)
        {
            if(n!=(int)n)
                if(n>0)
                    return (int)n + 1;
            return (int)n;
        }
        public static int Floor(float n)
        {
            if (n != (int)n)
                if(n<0)
                    return (int)n - 1;
            return (int)n;
        }
        public static int Rand1()
        {
            Random r = new Random();
            return r.Next(0, (int)Pow(2, 31)-1);
        }
        //public static float Rand2()
        //{
            //Random r=new Random();
           // return r.Next(((float)0), (float)1);

        //}
        public static int Factorial(long n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }
        public static double Equation(double x)
        {
            double sinx = 0;
            for (int i = 0; i <= x; i++)
                sinx += Pow(-1, i) * (Pow(x, 2 * i + 1) / Factorial(2 * i + 1));
            return sinx;
        }
    }
}
