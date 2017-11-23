using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps3._2
{
    class Program
    {
        public static double Square(double e, double x)
        {
            double a0 = 1;
            double a1 = 0.5 * (a0 + x / a0);
            while (Math.Abs(a1-a0)>=e)
            {
                a0 = a1;
                a1 = 0.5 * (a0 + x / a0);
            }
            return a1;
        }
        static void Main(string[] args)
        {
            double e = 0.01;
            double x = double.Parse(Console.ReadLine());
            double a = Square(e, x);
            Console.WriteLine(a);
        }
    }
}
