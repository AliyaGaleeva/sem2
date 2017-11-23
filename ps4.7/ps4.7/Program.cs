using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps4._7
{
    class Program
    {
        public static double LeftRectangle(double a, double b, double h)
        {
            double sum = 0;
            while (a<b-h)
            {
                sum = sum + h * (-1) * Math.Cos(2 * a) / Math.Sin(a);
                a = a + h;
            }
            return sum;
        }

        public static double RightRectangle(double a, double b, double h)
        {
            double sum = 0;
            while (a+h<b)
            {
                a = a + h;
                sum = sum - h *Math.Cos(2 * a) / Math.Sin(a); 
            }
            return sum;
        }

        public static double Trapeze(double a, double b, double h)
        {
            double sum = 0;
            double fa = -1 * Math.Cos(2 * a) / Math.Sin(a);
            double fb;
            a = a + h;
            while (a<b)
            {
                fb = -1 * Math.Cos(2 * a) / Math.Sin(a);
                sum = sum + h * (fa + fb) / 2;
                fa = fb;
                a = a + h;

            }
            return sum;
        }

        public static double Simpson(double a, double b, double h, int n)
        {
            double sum = - Math.Cos(2 * a) / Math.Sin(a) - Math.Cos(2 * b) / Math.Sin(b);
            double s0 = 0, s1 = 0; 
            for (int i=1; i<n; i++)
            {
                a = a + h;
                if (i%2==0) s0=s0 - Math.Cos(2 * a) / Math.Sin(a);
                else s1= s1 - Math.Cos(2 * a) / Math.Sin(a);
            }
            sum = h / 3 * (sum + 4 * s1 + 2 * s0);
            return sum;
        }

        public static double MonteKarlo(double a, double b, int n)
        {
            double sum = 0;
            Random rand = new Random();
            double x;
            for (int i = 1; i < n; i++)
            {
                x = rand.Next((int)a*100, (int)b*100)/100.0;
                sum=sum - Math.Cos(2 * x) / Math.Sin(x);
            }
            sum = sum / n;

            return sum;
        }
     
        static void Main(string[] args)
        {
            int n = 1000;
            double a = 1;
            double b = 2;
            double h = (b - a) / n;

            Console.WriteLine(LeftRectangle(a, b, h));
            Console.WriteLine(RightRectangle(a, b, h));
            Console.WriteLine(Trapeze(a, b, h));
            Console.WriteLine(Simpson(a, b, h, n));
            Console.WriteLine(MonteKarlo(a, b, n));

        }
    }
}
