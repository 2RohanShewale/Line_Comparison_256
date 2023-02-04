using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateLength line_One = new CalculateLength(1,2,3,4);
            double length_One = line_One.Calculate();

            CalculateLength line_two = new CalculateLength(5,6,7,9);
            double length_two = line_two.Calculate();

            if (length_One.Equals(length_two))
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");

            //UC3
            int a = length_One.CompareTo(length_two);
            if (a == 0)
                Console.WriteLine("Both Lines are equal");
            else if (a > 0)
                Console.WriteLine("Line one is greater");
            else
                Console.WriteLine("Line two is greater");

            Console.ReadKey();
        }
    }
}
