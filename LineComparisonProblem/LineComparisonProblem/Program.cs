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
            CalculateLength length_One = new CalculateLength(1,2,3,4);
            length_One.Calculate();


            Console.ReadKey();
        }
    }
}
