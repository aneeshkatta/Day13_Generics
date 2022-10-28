using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaxCheckGenerics
{
    internal class TestCase01
    {
        public static void First()
        {

            string strigoutput = MaxStringCheck.MaximumStringNumber("Z", "R", "A");
            Console.WriteLine("input :", "Z", "R", "A");
            Console.WriteLine(strigoutput);
            Console.ReadKey();
        }


      
    }
    
}
