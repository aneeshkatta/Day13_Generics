using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatMaxcheckGenerics
{
    internal class TestCase01
    {
        public static void Maxf1()
        {
            Console.WriteLine("Find max Number");

            double doubleoutput = MaximumFloatCheck.MaximumFloatNumber(91.52, 22.95, 77.56);
            Console.WriteLine(doubleoutput);

        }
    }
}
