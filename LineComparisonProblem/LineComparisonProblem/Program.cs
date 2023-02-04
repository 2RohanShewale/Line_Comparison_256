using System;
using System.Collections.Generic;
using System.Linq;
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

            CalculateLength line_two = new CalculateLength(5,6,7,6);
            double length_two = line_two.Calculate();

            if (length_One.Equals(length_two))
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
            Console.ReadKey();
        }
    }
}
