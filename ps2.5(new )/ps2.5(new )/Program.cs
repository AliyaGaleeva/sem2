using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2._5_new__
{
    class Program
    {
        public static double Summarize(double e)
        {
            double a=1;
            double sum = 0;
            double k = 2;
            
            while (a > e)
            {
                sum = sum + a;
                a = a * 2.0 * k * k / (2 * k) / (2 * k - 1);
                k++;
            }
            return sum+a;
        }
        static void Main(string[] args)
        {
            double e= 0.000001;
            double pi = -2;
            pi = pi + 2 * Summarize(e);
            Console.WriteLine(pi);
        }
    }
}
