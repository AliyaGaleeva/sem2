using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2._12
{
    class Program
    {
        public static double[] Sum(double x, double sum, double k, double e)
        {
            double f = 0.5;
            while (f >= e)
            {
                f = f * 4 * x * x / (2 * k - 1) / (2 * k);
                k++;
                if (k % 2 == 0) sum = sum - f;
                else sum = sum + f; 
            }
            return new double[] { sum, k };

        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double k = 1;
            double sum = 1;
            double e = 0.01;

            double[] c = Sum(x, sum, k, e);
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
        }
    }
}
