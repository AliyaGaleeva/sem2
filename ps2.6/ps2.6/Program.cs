using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2._6
{
    class Program
    {
        public static double[] Sum (double a, double b, double e, double x, double k, double s)
        {   while (a / b >= e)
            {
                a = a * x * x;
                b = b + 2;
                k++;
                if (k % 2 == 0) s = s + a/b;
                else s = s - a / b;
            }
            return new double [] {s, k};
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double e = 0.001;
            double s = 1;
            double a = x;
            double b = 1;
            int k = 1;
            double [] c = Sum(a, b, e, x, k, s);
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
        }
    }
}
