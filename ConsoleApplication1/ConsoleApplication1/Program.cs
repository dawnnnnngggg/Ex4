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
            Console.WriteLine(Rand2());
            int[] arr = new int[5];
            InputArray(arr);
            VLine(4, 'i');
            Square(4, 'o');
            SquareHollow(4, 'o');
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
        public static float Rand2()
        {
            Random r=new Random();
            return (float)r.NextDouble();

        }
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
        public static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("A[{0}]= ", i);
                string str = Console.ReadLine();
                arr[i] = int.Parse(str);
            }
        }
        public static bool IsContains5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    return true;
            }
            return false;
        }
        public static bool IsContains5or6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                    return true;
            }
            return false;
        }
        public static bool IsContains5and6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                    if (arr[i] == 5 && arr[j] == 6)
                        return true;
            }
            return false;
        }
        public static int Count5(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 5)
                    c++;
            return c;
        }
        public static int Count5or6(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                    c++;
            }
            return c;
        }
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        public static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }

        static void Square(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                HLine(n, c);
                Console.WriteLine();
            }
        }

        static void SquareHollow(int n, char c)
        {
            HLine(n, c);
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                HLine(1, c);
                HLine(n-2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n, c);
            Console.WriteLine();
        }

        static void DrawU(int n, char c)
        {
            for (int i = 0; i < n - 1; i++)
            {
                HLine(1, c);
                HLine(n - 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n, c);
            Console.WriteLine();
        }

        static void DrawV(int n, char c)
        {
            int b = 2 * n - 3;
            for (int i = 0; i < n - 1; i++)
            {
                HLine(i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b -= 2;
            }
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
        }

        static void RevTriangle(int n, char c)
        {
            HLine(2 * n - 1, c);
            Console.WriteLine();
            int a = 1, b = 2 * n - 5;
            for (int i = 0; i < n - 2; i++)
            {
                HLine(a, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                a += 1;
                b -= 2;
            }
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
        }

        static void Triangle(int n, char c)
        {
            HLine(n - 1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int b = 1;
            for (int i = 2; i < n ; i++)
            {
                HLine(n - i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b += 2;
            }
            HLine(2 * n - 1, c);
            Console.WriteLine();
        }

        static void DrawW(int n, char c)
        {
            HLine(1, c);
            HLine(n +1, ' ');
            HLine(1, c);
            HLine(n +1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int b = n - 1;
            for (int i = 1; i <= n-2; i++)
            {
                HLine(i, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                HLine(i+1, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                b -= 2;
            }
            HLine(n - 1, ' ');
            HLine(1, c);
            HLine(n +1, ' ');
            HLine(1, c);
            Console.WriteLine();
        }

        static void DrawA(int n, char c)
        {
            HLine(n + 1, ' ');
            HLine(1, c);
            Console.WriteLine();
            int a = 1, b = n;
            for (int i = 1; i < n/2 ; i++)
            {
                HLine(b, ' ');
                HLine(1, c);
                HLine(a, ' ');
                HLine(1, c);
                Console.WriteLine();
                b --;
                a += 2;
            }
            HLine(b, ' ');
            HLine(n + 1, c);
            b--;
            a += 2;
            Console.WriteLine();
            for (int i = 1; i < n / 2 + 1; i++)
            {
                HLine(b, ' ');
                HLine(1, c);
                HLine(a, ' ');
                HLine(1, c);
                Console.WriteLine();
                b--;
                a += 2;
            }
        }

        static void DrawX(int n, char c)
        {

            int a = 0, b = 2 * n - 3;
            while (b != 1)
            {
                //HLine(1, ' ');
                HLine(a, ' ');
                HLine(1, c);
                HLine(b - 2, ' ');
                HLine(1, c);
                Console.WriteLine();
                a++;
                b -= 2;
            }
            HLine(n - 2, ' ');
            HLine(1, c);
            Console.WriteLine();
            b += 2;
            a--;
            while (b != 2 * n - 1)
            {
                //HLine(1, ' ');
                HLine(a, ' ');
                HLine(1, c);
                HLine(b - 2, ' ');
                HLine(1, c);
                Console.WriteLine();
                b += 2;
                a--;
            }
        }

        static void DrawPlus(int n, char c)
        {
            for (int i = 0; i < n/2; i++)
            {
                HLine(n / 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
            HLine(n+1, c);
            Console.WriteLine();
            for (int i = 0; i < n/2; i++)
            {
                HLine(n / 2, ' ');
                HLine(1, c);
                Console.WriteLine();
            }
        }
    }
}

    

